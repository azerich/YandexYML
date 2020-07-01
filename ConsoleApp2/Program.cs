using ConsoleApp2.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Encodings;
using System.Xml;
using System.Xml.Linq;
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
            XmlSerializer serializer = new XmlSerializer(typeof(Catalog));

            WebClient client = new WebClient();

            string data = Encoding.Default.GetString(client.DownloadData(uri));
            Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
            Catalog catalog = (Catalog)serializer.Deserialize(stream);

            Console.WriteLine(catalog.Date);

            Console.ReadKey();
        }
    }
}
