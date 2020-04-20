using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardDetection.Service
{
    public class ROI
    {
        public int ID;

        public Rectangle location;

        public bool slipHazard;
        public bool tripHazard;
        public bool fallHazard;

        public ROI(int id, Rectangle rect)
        {
            ID = id;
            location = rect;
            slipHazard = false;
            tripHazard = false;
            fallHazard = false;
        }
    }
}
