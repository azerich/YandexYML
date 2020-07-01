using ConsoleApp2.Entities;
using ConsoleApp2.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    internal static class Program
    {
        internal static void Main()
        {
            string uri = "https://yastatic.net/market-export/_/partner/help/YML.xml";
            string data;

            ConsoleColor currentFG = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("https://spb.hh.ru/vacancy/37736641 \n");
            Console.ForegroundColor = currentFG;

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            WebClient client = new WebClient();
            Encoding cp1251 = Encoding.GetEncoding("Windows-1251");


            Console.Write($"Trying to download XML file from {uri}: ");
            try
            {
                data = cp1251.GetString(client.DownloadData(uri));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success");
                Console.ForegroundColor = currentFG;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("With errors:\n");
                Console.WriteLine(e.Message);
                Console.ForegroundColor = currentFG;
                throw;
            }
            
            Stream stream = new MemoryStream(cp1251.GetBytes(data));
            XmlSerializer serializer;
            Catalog catalog;
            Console.Write("Trying to deserialize yml_catalog: ");
            try
            {
                serializer = new XmlSerializer(typeof(Catalog));
                catalog = (Catalog)serializer.Deserialize(stream);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success");
                Console.ForegroundColor = currentFG;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("With errors:\n");
                Console.WriteLine(e.Message);
                Console.ForegroundColor = currentFG;
                throw;
            }

            Console.Write("Trying to connect to the database: ");
            SqlConnection connection = DbUtils.GetDBConnection();
            try
            {
                connection.Open();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success");
                Console.ForegroundColor = currentFG;
                connection.Close();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("With errors:\n");
                Console.WriteLine(e.Message);
                Console.ForegroundColor = currentFG;
                throw;
            }

            Console.WriteLine($"{catalog.Shop.Offers.Length} offer(s) found");
            int counter = 0;
            connection.Open();
            foreach (Offer offer in catalog.Shop.Offers)
            {
                counter++;
                Console.Write($"Trying to insert offer № {counter} into table: ");
                try
                {
                    DbUtils.AddOffer(connection, offer);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Success");
                    Console.ForegroundColor = currentFG;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("With errors:\n");
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = currentFG;
                    throw;
                }
            }
            connection.Close();

            Console.WriteLine($"{counter} offer(s) inserted to the database");
            Console.WriteLine("Job is Done");
            Console.ReadKey();
        }
    }
    internal static class FieldExtension
    {
        public static string DoPerfectFieldName(this string fieldName)
        {
            if (string.IsNullOrEmpty(fieldName)) return fieldName;
            else
            {
                string result = fieldName.Replace("Field", "");
                return char.ToUpper(result.First()) + result.Substring(1);
            }
        }

    }
}
