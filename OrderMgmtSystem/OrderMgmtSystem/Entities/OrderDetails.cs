using System;
namespace OrderMgmtSystem.Entities
{
    public class OrderDetails
    {
        //private static object sync = new object();
        //private static int IdCount;
        //public int OrderId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string AddressDetails { get; set; }
        public int PhoneNumber { get; set; }
        public string ItemNumber { get; set; }
        public Type ItemType { get; set; }
      

        public enum Type
        {
            Chilled,
            Frozen,
            Ambient
        }

       /* public OrderDetails(string _CustomerFirstName, string _CustomerLastName, string _AddressDetails, int _PhoneNumber, string _ItemNumber, string _ItemType)
        {
            this.CustomerFirstName = _CustomerFirstName;
            this.CustomerLastName = _CustomerLastName;
            this.AddressDetails = _AddressDetails;
            this.PhoneNumber = _PhoneNumber;
            this.ItemNumber = _ItemNumber;
            this.ItemType = _ItemType;
            lock (sync)//add lock section to avoid duplicate of Ids
            {
                this.OrderId = ++IdCount;
            }
        }
       */
    }
}
