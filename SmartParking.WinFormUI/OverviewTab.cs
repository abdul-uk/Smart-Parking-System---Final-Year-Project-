using System;
using System.Linq;
using System.Windows.Forms;
using SmartParking.Dtos;

namespace SmartParking.WinFormUI
{
    public partial class OverviewTab : UserControl
    {
        public Location[] locations;

        public OverviewTab()
        {
            InitializeComponent();
        }

        /// <summary>Handles the 1 event of the BtnDelete_Click control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            if (!Form1.capturingInProgress)
            {
                if (grid.RowCount > 0)
                {
                    //delete selected rows
                    foreach (DataGridViewRow row in grid.SelectedRows)
                    {
                        var profile = (Location)row.Tag;

                        Form1.LocationsList.Remove(profile.Id);
                        grid.Rows.Remove(row);
                    }
                    MessageBox.Show("Selected item(s) are deleted");
                }
                else
                {
                    MessageBox.Show("No items are selected");
                }
            }
            else
            {
                MessageBox.Show("Please stop the detection before adding or deleting location profiles");
            }
        }

        /// <summary>Handles the 1 event of the BtnAdd_Click control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            if (!Form1.capturingInProgress)
            {
                new PopupEffect.TransparentBg(this.FindForm(), new FrmAddLocation());

                PopulateDatatoDatagrid();
            }
            else
            {
                MessageBox.Show("Please stop the detection before adding or deleting location profiles");
            }
        }

        /// <summary>Populates the datato datagrid.</summary>
        public void PopulateDatatoDatagrid()
        {
            grid.Rows.Clear();

            var mockresult = Form1.LocationsList.GetAll();
            var results = mockresult.AsQueryable();

            foreach (var item in results)
            {

                string occupationPerce = "No spaces";

                if (item.TotalROIs > 0)
                {
                    occupationPerce = ((Double)item.OccupiedROIs / (Double)item.TotalROIs).ToString("P");
                }

                this.grid.Rows.Add(
                           new object[]
                           {
                             item.Name,
                             occupationPerce,
                             item.ViolationActive,
                             item.Timestamp
                           }
                          );
                this.grid.Rows[grid.RowCount - 1].Tag = item;
            }
        }
    }
}
