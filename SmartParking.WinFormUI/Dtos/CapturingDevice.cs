using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SmartParking.Dtos.ROI;

namespace SmartParking.Dtos
{
    /// <summary>Class CapturingDevice.</summary>
    public class CapturingDevice
    {
        private bool btnReleased;
        private Rectangle roiSelection;

        public int LocationID { get; set; }
        public VideoCapture Camera { get; set; }
        public ImageViewer Viewer { get; set; }
        public Image<Bgr,byte> Frame { get; set; }
        public List<ROI> Rois { get; set; }


        /// <summary>Initializes a new instance of the <see cref="T:SmartParking.Dtos.CapturingDevice"/> class.</summary>
        /// <param name="LocId">The loc identifier.</param>
        /// <param name="cameraID">The camera identifier.</param>
        public CapturingDevice(int LocId, int cameraID)
        {
            this.LocationID = LocId;
            this.Rois = new List<ROI>();
            this.Camera = new VideoCapture(cameraID);
            this.Frame = new Image<Bgr, byte>(Camera.Width, Camera.Height);
            this.Viewer = new ImageViewer(Frame);

            SetupViewer();
        }

        /// <summary>Setups the viewer.</summary>
        private void SetupViewer()
        {
            this.Viewer.ImageBox.FunctionalMode = ImageBox.FunctionalModeOption.RightClickMenu;
            this.Viewer.ImageBox.MouseDown += new MouseEventHandler(RoiSelection_click);
            this.Viewer.ImageBox.MouseUp += new MouseEventHandler(RoiSelection_click);
            this.Viewer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Viewer.MinimizeBox = true;
            this.Viewer.MaximizeBox = false;
        }

        /// <summary>Handles the click event of the RoiSelection control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void RoiSelection_click (object sender, MouseEventArgs e)
        {
            var test = Control.ModifierKeys;
            if (!btnReleased && e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.None)
            {
                roiSelection.X = e.X;
                roiSelection.Y = e.Y;

                btnReleased = true;
            }
            else if (btnReleased && e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.None)
            {
                var copyX = e.X;
                var copyY = e.Y;


                if (roiSelection.X > e.X)
                {
                    copyX = roiSelection.X;
                    roiSelection.X = e.X;
                }

                if (roiSelection.Y > e.Y)
                {
                    copyY = roiSelection.Y;
                    roiSelection.Y = e.Y;
                }

                roiSelection.Width = copyX - roiSelection.X;
                roiSelection.Height = copyY - roiSelection.Y;

                btnReleased = false;
                this.Rois.Add(new ROI (Rois.Count, roiSelection));
            }
            else if (e.Button == MouseButtons.Middle && !btnReleased && Control.ModifierKeys == Keys.None)
            {
                foreach (var roi in Rois)
                {
                    if (roi.location.Contains(e.Location))
                    {
                        var newType = (int)roi.Allocation;

                        roi.Allocation = (ROITypes)((newType + 1) % 3);
                    }
                }
            }
            else if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                foreach (var roi in Rois)
                {
                    if (roi.location.Contains(e.Location))
                    {
                        Rois.Remove(roi);
                        break;
                    }
                }
            }
        }

        /// <summary>Updates the viewer.</summary>
        public void UpdateViewer()
        {
            this.Viewer.Image = this.Frame;
        }

        public void ShowViewer()
        {
            this.Viewer.Show();
        }

        public Tuple<int[], bool[]> OccupationState()
        {
            bool[] retVal = { false, false, false, false };

            int totalRois = this.Rois.Count;
            int occupiedRois = 0;

            foreach (var roi in this.Rois)
            {
                retVal[0] = false;
                retVal[1] = false;
                retVal[2] = false;

                if (roi.truckIndic)
                {
                    retVal[0] = true;
                    if (roi.Allocation != ROITypes.Truck)
                        retVal[3] = true;
                }
                if (roi.carIndic)
                {
                    retVal[1] = true;
                    if (roi.Allocation != ROITypes.Car)
                        retVal[3] = true;
                }
                if (roi.MCIndic)
                {
                    retVal[2] = true;
                    if (roi.Allocation != ROITypes.Motorbike)
                        retVal[3] = true;

                }
                if (retVal[0] || retVal[1] || retVal[2])
                {
                    occupiedRois++;
                }
            }

            int[] occupationPerce = { occupiedRois, totalRois};
            return new Tuple<int[], bool[]>(occupationPerce, retVal);
        }
    }
}
