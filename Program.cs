using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Json
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filename = File.ReadAllText( path + "\\weather.json");
            WeatherInfo weatherinfo = JsonConvert.DeserializeObject<WeatherInfo>(filename);

            Console.WriteLine("test description visibility : " + weatherinfo.visibility);
            Console.WriteLine("test info main : " + weatherinfo.main["temp"]);
            Console.WriteLine("test description méteo : "+ weatherinfo.weather[0].description);
            Console.WriteLine("Deg du vent : " + weatherinfo.wind.deg);

            Console.ReadLine();
        }
    }


}
