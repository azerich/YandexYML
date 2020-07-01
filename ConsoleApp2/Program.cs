using ConsoleApp2.Entities;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    internal static class Program
    {
        internal static void Main()
        {
            string uri = "https://yastatic.net/market-export/_/partner/help/YML.xml";
            Console.WriteLine("https://spb.hh.ru/vacancy/37736641");

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            
            WebClient client = new WebClient();
            
            Encoding cp1251 = Encoding.GetEncoding("Windows-1251");
            string data = cp1251.GetString(client.DownloadData(uri));
            
            Stream stream = new MemoryStream(cp1251.GetBytes(data));
            XmlSerializer serializer = new XmlSerializer(typeof(Catalog));
            Catalog catalog = (Catalog)serializer.Deserialize(stream);

            Console.WriteLine(catalog.Date);
            Console.WriteLine(catalog.Shop.Name);
            Console.WriteLine(catalog.Shop.Company);
            Console.WriteLine(catalog.Shop.Url);
            Console.WriteLine(catalog.Shop.Categories.Length);
            Console.WriteLine(catalog.Shop.Currencies.Length);
            Console.WriteLine(catalog.Shop.Offers.Length);

            foreach (Offer offer in catalog.Shop.Offers)
            {
                Console.WriteLine(offer.Id);
                for (int i = 0; i < offer.Items.Length; i++)
                {
                    Console.WriteLine(offer.ItemsElementName[i].ToString() + " " + offer.Items[i].ToString());
                }
            }

            Console.WriteLine("Done?");

            //Console.ReadKey();
        }
    }
}
