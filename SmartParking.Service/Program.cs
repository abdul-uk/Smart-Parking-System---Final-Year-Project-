using System;
using System.Windows.Forms;
using SmartParking.WinFormUI;
using SmartParking.Dtos;
using Alturos.Yolo;
using System.Configuration;

namespace SmartParking.Service
{
    /// <summary>Class Program, the main entry point of the application.</summary>
    static class Program
    {
        /// <summary>The application UI</summary>
        public static Form1 appUI;
        /// <summary>The detection module</summary>
        private static DetectionModule detectionModule;

        /// <summary>Defines the entry point of the application.</summary>
        static void Main()
        {
            try
            {
                RunForm();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception ecountered :" + e.ToString());
            }
        }

        /// <summary>Runs the form.</summary>
        [STAThread]
        private static void RunForm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            appUI = new Form1();
            appUI.StartDeteBtn.Click += StartDetection;
            appUI.StopDeteBtn.Click += StopDetection;
            Application.Run(appUI);
        }

        /// <summary>Starts the detection.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private static void StartDetection(object sender, EventArgs e)
        {
            var repo = Form1.LocationsList;

            if (repo.GetAll().Count > 0)
            {
                appUI.SetLoading(true);
                detectionModule = new DetectionModule(repo);
                appUI.SetLoading(false);

                Console.WriteLine("detection module created");
            }
            else
            {
                MessageBox.Show("No locations of interest have been created");
            }
        }

        /// <summary>Stops the detection.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private static void StopDetection(object sender, EventArgs e)
        {
            var repo = Form1.LocationsList;

            appUI.SetLoading(true);
            detectionModule.StopModule();
            appUI.SetLoading(false);

            Console.WriteLine("detection module stopped");
        }
    }
}
