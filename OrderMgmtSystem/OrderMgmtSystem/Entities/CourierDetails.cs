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


        /*public CourierDetails(int _CourierID, string _CourierName, double _Price, string _VehicleType, int _ETA, int _ItemNumber)
        {
            this.CourierID = _CourierID;
            this.CourierName = _CourierName;
            this.Price = _Price;
            this.VehicleType = _VehicleType;
            this.ETA = _ETA;
            this.ItemNumber = _ItemNumber;

        }*/
    }
}
