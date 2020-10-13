using System;
using System.IO;
using OrderMgmtSystem.Entities;
using OrderMgmtSystem.Helper;

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

            csvHelper.ReadFile();

           // csvHelper.UpdateFile(orderdetails);

         

            return 12;

            // return orderID
        }
        public int ChooseCourier(OrderDetails orderdetails)
        {
            if(orderdetails.ItemType==OrderDetails.Type.Chilled)
            {
                // call to courier service
            }
            else if(orderdetails.ItemType == OrderDetails.Type.Frozen)
            {
                // call to courier service
            }
            else if(orderdetails.ItemType == OrderDetails.Type.Ambient)
            {
                // call to courier service
            }

            return 1;
        }
   
    }
}