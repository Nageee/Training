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

                   
                }
            }




            // Write Data




            // Save



            // Close



            // return the required info i.c. OrderID
        }
    }
}
