using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.Devices.Data
{
    public class ChamberData
    {
        public string Note { get; set; }
        public string Mode { get; set; }
        public string Door { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double TargetTemperature { get; set; }
    }
}
