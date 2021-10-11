using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    class WeatherInfo
    {
        public coord coord;
        public List<Weather> weather;
        [JsonProperty("base")]
        public string baSe;
        public Dictionary<String, double> main;
        public int visibility;
        public Wind wind;
        public Dictionary<String, double> clouds;
        public int dt;
        public Sys sys;
        public int id;
        public string name;
        public int cod;



    }

    class coord
    {
        public double lon;
        public double lat;
    }

    //class main
    //{
    //    public int temp { get; set; }
    //    public int pressure { get; set; }
    //    public int humidity { get; set; }
    //    public int temp_min { get; set; }
    //    public int temp_max { get; set; }

    //    public main()
    //    { 
    //    }
    //}
    class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }

    }

    class Wind
    {
        public double speed;
        public int deg;
    }

    class Sys
    {
        public int type;
        public int id;
        public double message;
        public string country;
        public int sunrise;
        public int sunset;
    }
}
