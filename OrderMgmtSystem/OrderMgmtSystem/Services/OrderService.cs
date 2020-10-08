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

            csvHelper.UpdateFile(orderdetails);

         

            return 12;

            // return orderID
        }

   
    }
}