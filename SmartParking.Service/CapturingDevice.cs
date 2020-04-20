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

namespace HazardDetection.Service
{
    public class CapturingDevice
    {
        private bool finishedSel;
        private Rectangle roiSelection;

        public int LocationID { get; set; }
        public VideoCapture Camera { get; set; }
        public ImageViewer Viewer { get; set; }
        public Image<Bgr,byte> Frame { get; set; }
        public List<ROI> Rois { get; set; }


        public CapturingDevice(int LocId, int cameraID)
        {
            this.LocationID = LocId;
            this.Rois = new List<ROI>();
            this.Camera = new VideoCapture(cameraID);
            this.Frame = new Image<Bgr, byte>(Camera.Width, Camera.Height);
            this.Viewer = new ImageViewer(Frame);

            setupViewer();
        }

        private void setupViewer()
        {
            this.Viewer.ImageBox.FunctionalMode = ImageBox.FunctionalModeOption.RightClickMenu;
            this.Viewer.ImageBox.MouseDown += new MouseEventHandler(RoiSelection_click);
            this.Viewer.ImageBox.MouseUp += new MouseEventHandler(RoiSelection_click);
            this.Viewer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Viewer.MinimizeBox = false;
            this.Viewer.MaximizeBox = false;
        }

        private void RoiSelection_click (object sender, MouseEventArgs e)
        {
            //var mousePos = e as MouseEventArgs;
            if (!finishedSel && e.Button == MouseButtons.Left)
            {
                roiSelection.X = e.X;
                roiSelection.Y = e.Y;

                finishedSel = true;
            }
            else if (finishedSel && e.Button == MouseButtons.Left)
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

                finishedSel = false;
                this.Rois.Add(new ROI (Rois.Count, roiSelection));
            }
        }

        public void updateViewer()
        {
            this.Viewer.Image = this.Frame;
        }

        public void showViewer()
        {
            this.Viewer.Show();
        }

        public bool[] HazardState()
        {
            bool[] retVal = { false, false, false };

            foreach (var roi in this.Rois)
            {
                if (roi.slipHazard)
                    retVal[0] = true;
                if (roi.tripHazard)
                    retVal[1] = true;
                if (roi.fallHazard)
                    retVal[2] = true;

                if (retVal[0] && retVal[1] && retVal[2])
                    break;
            }

            return retVal;
        }
    }
}
