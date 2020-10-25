using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicVehicleIncidentTracker.Model
{
    public class Incident
    {
        public string VIN { get; set; }
        public DateTime DateTimeOfAccident { get; set; }
        public string Note { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

    }
}
