using System;
namespace OrderMgmtSystem.Entities
{
    public class CourierDetails
    {
        public int CourierID { get; set; }
        public string CourierName { get; set; }
        public double Price { get; set; }
        public string VehicleType { get; set; }
        public int ETA { get; set; }
        public int ItemNumber { get; set; }
     
    }
}
