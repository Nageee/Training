using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq;
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

        //get Order Id
        internal static int GetOrderId()
        {
            var line = "";
            int counter = 0;
            int orderId = 0;
            using (var reader = new StreamReader(Environment.CurrentDirectory + @"/Data/OrderInfoData.csv")) //defining StreamReader
            {
                var csvFileLength = new System.IO.FileInfo(Environment.CurrentDirectory + @"/Data/OrderInfoData.csv").Length;

                if (csvFileLength > -1)
                {
                    try
                    {
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            counter++;
                            line = counter + "," + line;
                            var values = line.Split(',', StringSplitOptions.RemoveEmptyEntries);
                            orderId = Convert.ToInt32(values[0]);
                        }
                        return orderId++;
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("Exception occured as the CSV file is empty" + ":" +  e);
                    }
                }

                else
                {
                    orderId = 1;

                }
                return orderId;
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

    }

}



