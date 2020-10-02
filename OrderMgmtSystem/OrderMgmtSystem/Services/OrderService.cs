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

        public int PlaceOrder(OrderDetails ordertdetials)
        {

            csvHelper.UpdateFile(ordertdetials);

         

            return 12;

            // return orderID
        }

   
    }
}