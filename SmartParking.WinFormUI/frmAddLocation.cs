using DirectShowLib;
using SmartParking.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking.WinFormUI
{
    /// <summary>
    /// Class FrmAddLocation.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FrmAddLocation : Form
    {
        private CameraDevice[] cams;

        /// <summary>Initializes a new instance of the <see cref="T:SmartParking.WinFormUI.FrmAddLocation"/> class.</summary>
        public FrmAddLocation()
        {
            InitializeComponent();

            var camDevices = CamsExist();

            if (camDevices != null)
            {
                this.CamDropDown.Items.AddRange(camDevices);
                this.CamDropDown.SelectedIndex = 0;
            }
        }

        /// <summary>Handles the Click event of the BunifuImageButton1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>Handles the Click event of the BtnAddContact control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            var Id = Form1.LocationsList.GetAll().Count;
            var locName = txtName.Text.Trim();
            var Description = txtDesc.Text.Trim();
            var Cameras = cams[CamDropDown.SelectedIndex];

            var location = new Location(Id, locName, Description, Cameras);

            Form1.LocationsList.Add(location.Id, location);
            ResetForm();

            //Bunifu.Snackbar.Show(this.FindForm(), txtName.Text.Trim() + " Successfully Added.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
        }

        /// <summary>Camses the exist.</summary>
        /// <returns>array of camera devices.</returns>
        public CameraDevice[] CamsExist()
        {
            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            cams = new CameraDevice[_SystemCamereas.Length];

            for (int i = 0; i < _SystemCamereas.Length; i++)
            {
                cams[i] = new CameraDevice(i, _SystemCamereas[i].Name, _SystemCamereas[i].ClassID); //fill web cam array
            }

            if (cams.Length > 0)
            {
                return cams;
            }
            else
            {
                MessageBox.Show("No video input devices were found. Add a device and click the refresh button");
                this.Close();

                return null;
            }
        }

        /// <summary>Resets the form.</summary>
        private void ResetForm()
        {
            txtName.Text = "";
            txtDesc.Text = "";
            this.CamDropDown.SelectedIndex = 0;
        }
    }
}
