using DirectShowLib;
using Emgu.CV;
using Emgu.CV.Structure;
using SmartParking.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SmartParking.WinFormUI
{
    /// <summary>
    /// Class Form1.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form
    {
        public IList<Location> LastSavedLocations;
        public static bool capturingInProgress;
        public CameraDevice[] cams; //List containing all the camera available
        public static BaseRepository<int, Location> LocationsList { get; set; }
        private System.Timers.Timer logLocations;

        public OverviewTab overviewTab;
        public FrmAddLocation addLocFrm;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            capturingInProgress = false;
            StopDeteBtn.Enabled = false;
            LocationsList = new BaseRepository<int, Location>("LocationProfiles.json");
            logLocations = new System.Timers.Timer(3000);

            LastSavedLocations = LocationsList.GetAll();

            logLocations.Elapsed += new ElapsedEventHandler(this.LogLocations);

            //default tab
            overviewTab1.BringToFront();

            logLocations.Start();

            CamsExist(false);
        }

        /// <summary>Handles the Click event of the BunifuImageButton1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void BtnTab_Click(object sender, EventArgs e)
        {
            lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();

            if (lblCurTab.Text.Contains("Location"))
            {
                this.locationsTab1.BringToFront();
            }
            else
            {
                this.overviewTab1.BringToFront();
                this.overviewTab1.PopulateDatatoDatagrid();
            }
        }

        /// <summary>Handles the Shown event of the Form1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.overviewTab1.PopulateDatatoDatagrid();
        }

        /// <summary>Sets the loading.</summary>
        /// <param name="displayLoader">if set to <c>true</c> [display loader].</param>
        public void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Cursor = Cursors.WaitCursor;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Cursor = Cursors.Default;
                });
            }
        }

        /// <summary>Camses the exist.</summary>
        /// <returns>array of CameraDevices.</returns>
        public CameraDevice[] CamsExist(bool showMsg)
        {
            DsDevice[] _SystemCameras = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            cams = new CameraDevice[_SystemCameras.Length];

            for (int i = 0; i < _SystemCameras.Length; i++)
            {
                cams[i] = new CameraDevice(i, _SystemCameras[i].Name, _SystemCameras[i].ClassID); //fill web cam array
            }

            if (cams.Length > 0)
            {
                overviewTab1.btnAdd.Enabled = true;
                overviewTab1.btnDelete.Enabled = true;
                camBtn.Show();

                if (showMsg)
                {
                    MessageBox.Show(cams.Length.ToString() + " video devices were found on refresh");
                }

                return cams;
            }
            else
            {
                overviewTab1.btnAdd.Enabled = false;
                overviewTab1.btnDelete.Enabled = false;
                camBtn.Show();

                MessageBox.Show("No video input devices were found. Add a device and click the refresh button");
                return null;
            }
        }

        /// <summary>RFRSHs the cams BTN click.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RfrshCamsBtnClick(object sender, EventArgs e)
        {
            CamsExist(true);
        }

        /// <summary>Handles the Click event of the StartDeteBtn control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void StartDeteBtn_Click(object sender, EventArgs e)
        {
            if (LocationsList.GetAll().Count > 0)
            {
                capturingInProgress = true;

                //start the capture
                StopDeteBtn.ButtonText = "Stop";
                StartDeteBtn.ButtonText = "Running";
                StopDeteBtn.Enabled = true;
                StartDeteBtn.Enabled = false;
                camBtn.Enabled = false;
            }
        }

        /// <summary>Handles the Click event of the StopDeteBtn control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void StopDeteBtn_Click(object sender, EventArgs e)
        {
            capturingInProgress = false;

            //Stop the capture
            StopDeteBtn.ButtonText = "Stopped";
            StartDeteBtn.ButtonText = "Start";
            StopDeteBtn.Enabled = false;
            StartDeteBtn.Enabled = true;
            camBtn.Enabled = true;
        }

        /// <summary>Updates the repository.</summary>
        /// <param name="locObj">The loc object.</param>
        public void UpdateRepository (Dtos.CapturingDevice locObj)
        {
            LocationsList.GetById(locObj.LocationID, out Location location);

            var states = locObj.OccupationState();

            location.TruckActive = states.Item2[0];
            location.CarActive = states.Item2[1];
            location.McActive = states.Item2[2];
            location.ViolationActive = states.Item2[3];

            location.OccupiedROIs = states.Item1[0];
            location.TotalROIs = states.Item1[1];
            location.Timestamp = DateTime.Now;

            LocationsList.Add(locObj.LocationID, location);

            this.overviewTab1.PopulateDatatoDatagrid();
        }

        /// <summary>Logs the locations.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ElapsedEventArgs"/> instance containing the event data.</param>
        private void LogLocations(object sender, ElapsedEventArgs e)
        {
            bool saveCopy = false;
            bool newId;

            if (LocationsList.GetAll().Count > 0)
            {
                if (LastSavedLocations.Count == LocationsList.GetAll().Count)
                {
                    foreach (var loc in LocationsList.GetAll())
                    {
                        newId = false;

                        foreach (var output in LastSavedLocations)
                        {
                            if (loc.Id == output.Id)
                            {
                                newId = false;

                                if ((output.CarActive != loc.CarActive) ||
                                    (output.McActive != loc.McActive) ||
                                    (output.OccupiedROIs != loc.OccupiedROIs) ||
                                    (output.TotalROIs != loc.TotalROIs) ||
                                    (output.TruckActive != loc.TruckActive) ||
                                    (output.ViolationActive != loc.ViolationActive))
                                {
                                    saveCopy = true;
                                    break;
                                }
                            }
                        }

                        if (newId)
                        {
                            saveCopy = true;
                            break;
                        }
                    }
                }
                else
                {
                    saveCopy = true;
                }
            }
            if (saveCopy)
            {
                saveCopy = false;
                LastSavedLocations = LocationsList.GetAll();
                LocationsList.WriteDictionaryToDisk();
            }
        }
    }
}
