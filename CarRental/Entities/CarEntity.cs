using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    public class CarEntity
    {
        public int Id { get; set; }
        public string NameCode { get; set; } = null!;
        public CarType CarType { get; set; }
        public FuelType FuelType { get; set; }
        public string Brand { get; set; } = null!;
        public float PricePerDay { get; set; } = 0;

        // feature
        public bool Map { get; set; }
        public bool MarginalCamera { get; set; }
        public bool TireSensor { get; set; }
        public bool ReversingCamera { get; set; }
        public bool Sunroof { get; set; }
        public bool USB { get; set; }
        public bool PickupTruckTrunkCover { get; set; }
        public bool SpeedWarningKit { get; set; }
        public bool BlueTooth { get; set; }
        public bool DashCam { get; set; }
        public bool CollisionSensor { get; set; }
        public bool GPS { get; set; }
        public bool SpareTire { get; set; }
        public bool Camera360 { get; set; }
    }
}
