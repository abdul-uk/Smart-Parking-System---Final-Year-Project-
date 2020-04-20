using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SmartParking.Dtos
{
    public class ROI
    {
        public enum ROITypes { Car, Truck, Motorbike}

        public int ID;

        public Rectangle location;

        public ROITypes Allocation;
        public bool truckIndic;
        public bool carIndic;
        public bool MCIndic;
        
        /// <summary>the number of frames recorded during the alert timer state</summary>
        public double truckPosFrames, truckTotalFrames;
        public double carPosFrames, carTotalFrames;
        public double mcPosFrames, mcTotalFrames;

        /// <summary>The locations repository</summary>
        public System.Timers.Timer truckTimer, carTimer, mcTimer;

        /// <summary>The alert state for different detections</summary>
        public bool truckAlert, carAlert, mcAlert;

        public ROI(int id, Rectangle rect)
        {
            ID = id;
            location = rect;
            truckIndic = false;
            carIndic = false;
            MCIndic = false;
            Allocation = ROITypes.Car;

            SetupAlertTimers();
        }

        /// <summary>
        ///  Sets ups the alert timers for the detected vehicles.
        /// </summary>
        private void SetupAlertTimers()
        {
            truckTimer = new System.Timers.Timer(Double.Parse(ConfigurationManager.AppSettings["CheckAlerts"]) * 1000); //timer set up with an interval of 3 seconds
            carTimer = new System.Timers.Timer(Double.Parse(ConfigurationManager.AppSettings["CheckAlerts"]) * 1000); //timer set up with an interval of 3 seconds
            mcTimer = new System.Timers.Timer(Double.Parse(ConfigurationManager.AppSettings["CheckAlerts"]) * 1000); //timer set up with an interval of 3 seconds

            truckAlert = carAlert = mcAlert = false;

            truckTimer.Elapsed += (sender, e) => CheckOccup(sender, e, ref truckPosFrames, ref truckTotalFrames, ref truckAlert);
            carTimer.Elapsed += (sender, e) => CheckOccup(sender, e, ref carPosFrames, ref carTotalFrames, ref carAlert);
            mcTimer.Elapsed += (sender, e) => CheckOccup(sender, e, ref mcPosFrames, ref mcTotalFrames, ref mcAlert);
        }


        /// <summary>
        /// Checks the occupation.
        /// Checks the occupation statefor each roi depending on the trigering timer
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ElapsedEventArgs"/> instance containing the event data.</param>
        /// <param name="occPosFrms">The occupation position frames.</param>
        /// <param name="occTotalFrms">The occupation total frames.</param>
        /// <param name="occAlert">if set to <c>true</c> [occ alert].</param>
        private void CheckOccup(object sender, ElapsedEventArgs e, ref double occPosFrms, ref double occTotalFrms, ref bool occAlert)
        {
            var timer = sender as System.Timers.Timer;

            Console.WriteLine("Checking the " + sender.ToString() + " timer: " + occPosFrms + "/" + occTotalFrms);

            if (occPosFrms / occTotalFrms > Double.Parse(ConfigurationManager.AppSettings["TriggerAlertRatio"]))
            {
                //Console.WriteLine(sender.ToString() + "Occupation confirmed");
                occAlert = true;
            }
            else
            {
                //Console.WriteLine(sender.ToString() + "Occupation stopped");
                occTotalFrms = 0;
                occPosFrms = 0;
                occAlert = false;
            }
        }

    }
}
