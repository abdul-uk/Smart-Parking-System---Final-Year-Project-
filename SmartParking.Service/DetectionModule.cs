using Alturos.Yolo;
using Alturos.Yolo.Model;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using SmartParking.Dtos;
using SmartParking.WinFormUI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace SmartParking.Service
{
    public class DetectionModule
    {
        /// <summary>  The first processed location profile</summary>
        readonly bool firstObj;


        /// <summary>The latest location profile object</summary>
        private CapturingDevice latestObj;

        /// <summary>The captures dictionary</summary>
        private List<CapturingDevice> capturesDict = new List<CapturingDevice>();

        /// <summary>The locations repository</summary>
        private BaseRepository<int, Location> LocsRepo;

        /// <summary>dictionary of the detected objects and their bounding boxes</summary>
        private IDictionary<YoloItem, Rectangle> objectsList;

        /// <summary>The YOLO object wrapper</summary>
        private YoloWrapper yoloWrapper = new YoloWrapper(ConfigurationManager.AppSettings["YoloCFG"], ConfigurationManager.AppSettings["YoloWeights"], ConfigurationManager.AppSettings["YoloNames"]);

        /// <summary>
        ///   <para>
        ///  Initializes a new instance of the <see cref="T:SmartParking.Service.DetectionModule"/> class.
        /// </para>
        ///   <para>
        ///   This object uses the passed parameter to retrieve information about location and their cameras
        ///   </para>
        /// </summary>
        /// <param name="repo">The location profiles repository.</param>
        public DetectionModule(BaseRepository<int, Location> repo)
        {
            firstObj = true;
            this.LocsRepo = repo;

            SetupCameras();
            RunDetection();
        }

        /// <summary>
        /// Sets up the Capturing object for each camera installed.
        /// </summary>
        private void SetupCameras()
        {
            var keys = LocsRepo.GetKeys();

            foreach (var key in keys)
            {

                if (LocsRepo.GetById(key, out Location location))
                {
                    capturesDict.Add(new Dtos.CapturingDevice(key, location.Cameras.Device_ID));
                }
            }
        }

        /// <summary>
        /// Runs the detection algorithm by starting all cameras and showing thier respective viewers.
        /// </summary>
        public void RunDetection()
        {
            foreach (var _capture in capturesDict) {
                CvInvoke.UseOpenCL = false;
                try
                {
                    _capture.Camera.ImageGrabbed += (sender, e) => ProcessFrame(sender, e, _capture);
                    _capture.Viewer.Show();
                    _capture.Camera.Start();

                    Console.WriteLine("location: " + _capture.LocationID + " started");
                }
                catch (Exception excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
        }
        public void ProcessFrame(object sender, EventArgs arg, CapturingDevice captureObj)
        {
            try
            {
                if (sender is VideoCapture _capture && _capture.Ptr != IntPtr.Zero && captureObj != null)
                {
                    //get image form camera
                    _capture.Retrieve(captureObj.Frame);

                    //convert to bytes so it can be fed to the detector
                    var frmCpy = ImageToByte2(captureObj.Frame.Bitmap);

                    //run the converted image through the detector
                    var yoloObjects = yoloWrapper.Detect(frmCpy);

                    //draw a bounding box around detected objects
                    captureObj.Frame = Detect(yoloObjects, captureObj.Frame, out objectsList); //draw detected objects in the image obtained from camera

                    //update rois colour if objects are intersected with them
                    captureObj = RoiUpdate(objectsList, captureObj, captureObj.Rois); //update the colour of rois in the case an object is detected within its boundaries.

                    //display adjusted image
                    DisplayImage(captureObj);

                    if (firstObj)
                        latestObj = captureObj;

                    UpdateUIRepo(captureObj);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("encountered an exception whil processing frames: " + e.ToString());
            }
        }

        /// <summary>  controls the colour munctionality of the ROIs in the case of a detection or an alert</summary>
        /// <param name="yoloObjects">The yolo objects.</param>
        /// <param name="capObj">The cap object.</param>
        /// <param name="rois">The rois.</param>
        /// <returns>CapturingDevice.</returns>
        private CapturingDevice RoiUpdate(IDictionary<YoloItem, Rectangle> yoloObjects, CapturingDevice capObj, List<ROI> rois)
        {
            bool CarFound = false;
            bool TruckFound = false;
            bool MCFound = false;
            string Legend = string.Empty;

            //Print Frame legend
            Legend = "Car";
            var legendRect = new Rectangle(5, 20, 10, 2);
            capObj.Frame.Draw(legendRect, new Bgr(Color.Cyan), 2);
            CvInvoke.PutText(capObj.Frame, Legend, new Point(legendRect.Right + 3, legendRect.Y+5), FontFace.HersheyPlain, 1, new Bgr(Color.Cyan).MCvScalar);

            Legend = "Truck";
            legendRect.Y += 20;
            capObj.Frame.Draw(legendRect, new Bgr(Color.LightBlue), 2);
            CvInvoke.PutText(capObj.Frame, Legend, new Point(legendRect.Right + 3, legendRect.Y+5), FontFace.HersheyPlain, 1, new Bgr(Color.LightBlue).MCvScalar);

            Legend = "Bike";
            legendRect.Y += 20;
            capObj.Frame.Draw(legendRect, new Bgr(Color.LightSeaGreen), 2);
            CvInvoke.PutText(capObj.Frame, Legend, new Point(legendRect.Right + 3, legendRect.Y+5), FontFace.HersheyPlain, 1, new Bgr(Color.LightSeaGreen).MCvScalar);


            Legend = "* Create an roi by dragging the mouse left button.";
            CvInvoke.PutText(capObj.Frame, Legend, new Point(10, capObj.Viewer.Height - 65), FontFace.HersheyPlain, 1, new Bgr(Color.White).MCvScalar);

            Legend = "* Hover-over roi and click middle button to change its type.";
            CvInvoke.PutText(capObj.Frame, Legend, new Point(10, capObj.Viewer.Height - 50), FontFace.HersheyPlain, 1, new Bgr(Color.White).MCvScalar);

            foreach (var roi in rois)
            {
                CarFound = false;
                TruckFound = false;
                MCFound = false;
                
                //check if a timer has started
                if (roi.truckTimer.Enabled)
                    roi.truckTotalFrames++;
                else
                {
                    roi.truckTotalFrames = 0;
                    roi.truckTotalFrames = 0;
                }

                if (roi.carTimer.Enabled)
                    roi.carTotalFrames++;
                else
                {
                    roi.truckTotalFrames = 0;
                    roi.truckTotalFrames = 0;
                }

                if (roi.mcTimer.Enabled)
                    roi.mcTotalFrames++;
                else
                {
                    roi.truckTotalFrames = 0;
                    roi.truckTotalFrames = 0;
                }

                string label = String.Format($"ID:{roi.ID}");

                if (roi.Allocation == ROI.ROITypes.Car)
                {
                    capObj.Frame.Draw(roi.location, new Bgr(Color.Cyan), 2);
                }
                else if (roi.Allocation == ROI.ROITypes.Truck)
                {
                    capObj.Frame.Draw(roi.location, new Bgr(Color.LightBlue), 2);
                }
                else
                {
                    capObj.Frame.Draw(roi.location, new Bgr(Color.LightSeaGreen), 2);
                }

                foreach (var item in yoloObjects)
                {
                    if (item.Value.IntersectsWith(roi.location))
                    {
                        if (item.Key.Type == "truck")
                            TruckFound = true;
                        if (item.Key.Type == "car")
                            CarFound = true;
                        if (item.Key.Type == "motorbike")
                            MCFound = true;

                        if ((CarFound && roi.carAlert) || (TruckFound && roi.truckAlert) || (MCFound && roi.mcAlert))
                        {
                            capObj.Frame.Draw(roi.location, new Bgr(Color.Red), 2);
                            break;
                        }
                        else if ((CarFound && !roi.carAlert) || (TruckFound && !roi.truckAlert) || (MCFound && !roi.mcAlert))
                        {
                            capObj.Frame.Draw(roi.location, new Bgr(Color.Orange), 2);
                        }
                    }
                }

                //Save changes to ROI
                if (TruckFound && roi.truckAlert)
                {
                    roi.truckIndic = true;
                }
                else
                    roi.truckIndic = false;
               
                if (CarFound && roi.carAlert)
                {
                    roi.carIndic = true;
                }
                else
                    roi.carIndic = false;

                if (MCFound && roi.mcAlert)
                {
                    roi.MCIndic = true;
                }
                else
                    roi.MCIndic = false;

                //Print output next to the ROI
                CvInvoke.PutText(capObj.Frame, label, roi.location.Location, FontFace.HersheyPlain, 1.3, new Bgr(Color.Blue).MCvScalar);

                //check if a timer has started
                if (TruckFound)
                {
                    roi.truckTimer.Start();
                    roi.truckPosFrames++;
                    TruckFound = false;
                }
                if (CarFound)
                {
                    roi.carTimer.Start();
                    roi.carPosFrames++;
                    CarFound = false;
                }
                if (MCFound)
                {
                    roi.mcTimer.Start();
                    roi.mcPosFrames++;
                    MCFound = false;
                }
            }

            return capObj;
        }

        /// <summary>  Utility function created to convert an Images to byte array. So it can be fed to the YOLO wrapper</summary>
        /// <param name="img">The img.</param>
        /// <returns>System.Byte[].</returns>
        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        /// <summary>Detects the specified yolo objects.</summary>
        /// <param name="yoloObjects">The yolo objects.</param>
        /// <param name="UpdatedFrame">The updated frame.</param>
        /// <param name="secondList">The second list.</param>
        /// <returns>Image&lt;Bgr, System.Byte&gt;.</returns>
        public static Image<Bgr, byte> Detect(IEnumerable<YoloItem> yoloObjects, Image<Bgr, byte> UpdatedFrame, out IDictionary<YoloItem, Rectangle> secondList)
        {
            secondList = new Dictionary<YoloItem, Rectangle>();

            if (yoloObjects != null)
            {
                foreach (var item in yoloObjects.Where(wr => (wr.Type == "car") || (wr.Type == "truck") || (wr.Type == "motorbike") && (wr.Confidence > double.Parse(ConfigurationManager.AppSettings["PredictConf"]))))
                {
                    //Console.WriteLine($"item numebr {counter}: Type: {item.Type}, confidence {item.Confidence}");
                    UpdatedFrame.Draw(new Rectangle(item.X, item.Y, item.Width, item.Height),
                        new Bgr(Color.Blue), 1);

                    var smlrRect = new Rectangle(item.X + (item.Width / 2) / 2, item.Y + (item.Height / 2) / 2, item.Width / 2, item.Height / 2);
                    UpdatedFrame.Draw(smlrRect, new Bgr(Color.Yellow), 2);
                    secondList.Add(item, smlrRect);

                    string label = String.Format($"{item.Type}, {item.Confidence.ToString("0.##")}");
                    CvInvoke.PutText(UpdatedFrame, label, new Point(item.X, item.Y), FontFace.HersheyPlain, 1.3, new Bgr(Color.Blue).MCvScalar);
                }
            }

            return UpdatedFrame;
        }

        /// <summary>Updates the UI's repository by requesting an update.</summary>
        /// <param name="captureObj">The capture object.</param>
        private void UpdateUIRepo(CapturingDevice captureObj)
        {
            Program.appUI.Invoke((MethodInvoker)delegate { Program.appUI.UpdateRepository(captureObj); });
        }

        /// <summary>
        /// Thread safe method to display image in a picturebox that is set to automatic sizing
        /// </summary>
        /// <param name="captureObj"> the camera object</param>
        private delegate void DisplayImageDelegate(CapturingDevice captureObj);
        private void DisplayImage(CapturingDevice captureObj)
        {
            if (captureObj.Viewer.InvokeRequired)
            {
                try
                {
                    DisplayImageDelegate DI = new DisplayImageDelegate(DisplayImage);
                    captureObj.Viewer.BeginInvoke(DI, new object[] { captureObj });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                captureObj.UpdateViewer();
            }
        }

        /// <summary>
        /// Stops the module.
        /// </summary>
        public void StopModule()
        {
            foreach (var _capture in capturesDict)
            {
                CvInvoke.UseOpenCL = false;
                try
                {
                    _capture.Camera.Stop();
                    _capture.Viewer.Close();

                    yoloWrapper.Dispose();
                    _capture.Camera.Dispose();

                    Console.WriteLine("Detection in location: " + _capture.LocationID + " stopped");
                }
                catch (Exception excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
        }
    }
}
