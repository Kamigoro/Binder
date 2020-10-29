using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.ProgramFlow
{
    public class Sensor
    {
        /// <summary>
        /// Serial number of the sensor. Has to be not empty
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// On wich channel of the measurement device is the sensor linked.
        /// </summary>
        public int MeasurementChannel { get; set; }
    }
}
