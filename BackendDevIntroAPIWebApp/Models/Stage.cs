using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendDevIntroAPIWebApp.Models
{
    public class Stage
    {
        public long Id { get; set; }
        public string SSE { get; set; } 
        public string Plant { get; set; }
        public string Device { get; set; }
        public string Subsystem { get; set; }
        public string Section { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public int Altitude { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int Year { get; set; }
        public string DeviceType { get; set; }
        public string Up { get; set; }
        public string EcName { get; set; }
        public string Notes { get; set; }
        public string Vendor { get; set; }
        public string DowntimeClass { get; set; }
        public int NominalPower { get; set; }
        public string TechAvailability { get; set; }
        public string ContrAvailability { get; set; }
        public string Municipality { get; set; }
    }
}
