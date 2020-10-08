using System;
using System.IO;
using OrderMgmtSystem.Entities;

namespace OrderMgmtSystem.Helper
{
    public class CsvHelper
    {
        public CsvHelper()
        {
        }

        internal void UpdateFile(OrderDetails ordertdetials)
        {
            // open CSV file


            using (var reader = new StreamReader(Environment.CurrentDirectory + @"/Data/OrderInfoData.csv"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    // write csv function
                }
            }


            // TextWriter sw = new StreamWriter(Environment.CurrentDirectory + @"/Data/OrderInfoData.csv"));
            OrderDetails od = new OrderDetails();

            string CustomerFirstName = od.CustomerFirstName;
            string CustomerLastName = od.CustomerLastName;
            using (TextWriter sw = new StreamWriter((Environment.CurrentDirectory + @"/Data/OrderInfoData.csv"))

            {
                string firstname = CustomerFirstName;
            string lastname = CustomerLastName;

            sw.WriteLine("{0},{1}", firstname, lastname);

        }

            // Write Data




            // Save



            // Close



            // return the required info i.c. OrderID
        }
    }
}
