using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Threading;

namespace SmartParking.WinFormUI
{
    public partial class LocationsTab : UserControl
    {
        //private VideoCapture _capture = null;
        //private bool _captureInProgress;
        ////private Image<Bgr, Byte> _frame;
        //private List<Tuple<bool, Rectangle>> rois;
        //private Rectangle roiSelection;
        //private bool finishedSel;

        public LocationsTab()
        {
            InitializeComponent();

            //var path = Environment.CurrentDirectory;

            //try
            //{
            //    _capture = new VideoCapture();
            //    _capture.ImageGrabbed += ProcessFrame;
            //}
            //catch (NullReferenceException excpt)
            //{
            //    MessageBox.Show(excpt.Message);
            //}

            //rois = LoadROIs();
            //_frame = new Image<Bgr, byte>(_capture.Width, _capture.Height);
            //roiSelection = new Rectangle();
            //finishedSel = false;
        }

        //private void ProcessFrame(object sender, EventArgs arg)
        //{
        //    if (_capture != null && _capture.Ptr != IntPtr.Zero)
        //    {
        //        _capture.Retrieve(_frame, 0);

        //        foreach (var roi in rois)
        //        {
        //            CvInvoke.Rectangle(_frame, roi.Item2, new Bgr(Color.Blue).MCvScalar, 1);
        //        }

        //        Thread.Sleep(100);
        //        imageBox1.Image = _frame;
        //    }
        //}
        //private static List<Tuple<bool, Rectangle>> LoadROIs()
        //{
        //    return new List<Tuple<bool, Rectangle>> {
        //                new Tuple<bool, Rectangle>( false, new Rectangle(new Point(50, 50), new Size(100, 200))),
        //                new Tuple<bool, Rectangle>( false, new Rectangle(new Point(160, 50), new Size(100, 200))),
        //                new Tuple<bool, Rectangle>( false, new Rectangle(new Point(270, 50), new Size(100, 200))),
        //                new Tuple<bool, Rectangle>( false, new Rectangle(new Point(380, 50), new Size(100, 200))),
        //                };
        //}

        //private void ImageBox1_Click(object sender, MouseEventArgs e)
        //{
        //    //var mousePos = e as MouseEventArgs;
        //    //if (!finishedSel && e.Button == MouseButtons.Middle)
        //    //{
        //    //    roiSelection.Location = e.Location;

        //    //    finishedSel = true;
        //    //}
        //    //else if (finishedSel && e.Button == MouseButtons.Middle)
        //    //{
        //    //    roiSelection.Width = e.X - roiSelection.X;
        //    //    roiSelection.Height = e.Y - roiSelection.Y;

        //    //    finishedSel = false;
        //    //    rois.Add(roiSelection);
        //    //}
        //}

        //public void UpdateImage(Image<Bgr, byte> frame)
        //{
        //    imageBox1.Image = frame;
        //}

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    //if (_capture != null)
        //    //{
        //        if (_captureInProgress)
        //        {  //stop the capture
        //            button1.Text = "Start";
        //    //        _capture.Pause();
        //        }
        //        else
        //       {
        //            //start the capture
        //            button1.Text = "Stop";
        //    //        _capture.Start();
        //        }

        //        _captureInProgress = !_captureInProgress;
        //    //}
        //}

    }
}
