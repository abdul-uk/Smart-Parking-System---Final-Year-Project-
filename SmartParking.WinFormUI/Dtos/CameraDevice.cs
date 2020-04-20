using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParking.Dtos
{
    public class CameraDevice
    {
        public string Device_Name;
        private int device_ID;
        public Guid Identifier;

        public int Device_ID { get => device_ID; set => device_ID = value; }

        public CameraDevice(int ID, string Name, Guid Identity = new Guid())
        {
            Device_ID = ID;
            Device_Name = Name;
            Identifier = Identity;
        }

        /// <summary>
        /// Represent the Device as a String
        /// </summary>
        /// <returns>The string representation of this color</returns>
        public override string ToString()
        {
            return String.Format("{0}", Device_Name);
        }
    }
}
