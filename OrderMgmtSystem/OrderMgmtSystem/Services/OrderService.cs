using System;
using System.IO;
using OrderMgmtSystem.Entities;
using OrderMgmtSystem.Helper;
using OrderMgmtSystem.Services;

namespace OrderMgmtSystem.Services
{
    public class OrderService
    {

        CsvHelper csvHelper = new CsvHelper();

        public OrderService()
        {
        }

        public int PlaceOrder(OrderDetails orderdetails)
        {
            int orderId = CsvHelper.GetOrderId();
            //csvHelper.ReadFile();
            csvHelper.UpdateFile(orderdetails);
            return orderId;
        }


        public string ChooseCourier(OrderDetails orderdetails)
        {

            if (orderdetails.ItemType == OrderDetails.Type.Chilled)
            {
                return "CourierOne";
            }
            else if (orderdetails.ItemType == OrderDetails.Type.Frozen)
            {
                return "CourierTwo";
            }
            else if (orderdetails.ItemType == OrderDetails.Type.Ambient)
            {
                return "CourierThree";
            }
            return "Undefined Type";
        }
    }
}
