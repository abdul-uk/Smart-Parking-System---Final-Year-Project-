using Emgu.CV;
using System;

namespace SmartParking.Dtos
{
    public class Location
    {
        private int id;
        private string name;
        private string description;
        private int totalROIs;
        private int occupiedROIs;
        private DateTime timestammp;
        private bool truckActive;
        private bool carActive;
        private bool mcActive;
        private bool violationActive;
        private CameraDevice cameras;

        public Location(int id, string name, string description, CameraDevice cameras)
        {
            Id = id;
            Name = name;
            Description = description;
            Cameras = cameras;
            Timestamp = DateTime.Now;
            TruckActive = CarActive = McActive = ViolationActive = false;
            TotalROIs = OccupiedROIs = 0;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public bool TruckActive { get => truckActive; set => truckActive = value; }
        public bool CarActive { get => carActive; set => carActive = value; }
        public bool McActive { get => mcActive; set => mcActive = value; }
        public CameraDevice Cameras { get => cameras; set => cameras = value; }
        public DateTime Timestamp { get => timestammp; set => timestammp = value; }
        public bool ViolationActive { get => violationActive; set => violationActive = value; }
        public int TotalROIs { get => totalROIs; set => totalROIs = value; }
        public int OccupiedROIs { get => occupiedROIs; set => occupiedROIs = value; }


    }
}