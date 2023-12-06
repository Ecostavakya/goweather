using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherapp.Models
{
    public class Weather
    {
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Description { get; set; }
        public Forecast[] Forecast { get; set; }
    }


    public class Forecast
    {
        public string Day { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
    }
}
