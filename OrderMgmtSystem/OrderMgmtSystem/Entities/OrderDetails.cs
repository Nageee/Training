using System;
namespace OrderMgmtSystem.Entities
{
    public class OrderDetails
    {
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string AddressDetails { get; set; }
        public int PhoneNumber { get; set; }

        public string ItemNumber { get; set; }
        
    }
}
