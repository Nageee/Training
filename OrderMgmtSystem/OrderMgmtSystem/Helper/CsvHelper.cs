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

        internal void ReadFile()
        {
            // open CSV file

            using (var reader = new StreamReader(Environment.CurrentDirectory + @"/Data/OrderInfoData.csv")) //defining StreamReader
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',', StringSplitOptions.RemoveEmptyEntries);

                    foreach (var value in values)
                    {
                        Console.WriteLine(value);
                    }


                    
                }

            }
        }


        // Write Data to CSV

        internal void UpdateFile(OrderDetails orderdetails)
        {
            using (var writer = new StreamWriter(Environment.CurrentDirectory + @"/Data/OrderInfoData.csv", true))//append data
            {
                writer.Write(Environment.NewLine);
                writer.Write(orderdetails.CustomerFirstName + "," + orderdetails.CustomerLastName + "," + orderdetails.AddressDetails + "," + orderdetails.ItemNumber + "," + orderdetails.ItemType + "," + orderdetails.PhoneNumber);
                writer.Close();

                
            }
        }


        // Save



        // Close



        // return the required info i.c. OrderID
    }
}

