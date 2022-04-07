// See https://aka.ms/new-console-template for more information
using System;
using System.Net;
using Newtonsoft.Json;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String url = "http://localhost:8080/Rut";
            Console.WriteLine(url);

            WebClient client = new WebClient();
            string Json = client.DownloadString(url);  

            dynamic m = JsonConvert.DeserializeObject(Json);
            Console.WriteLine(Json);
        }
    }
}