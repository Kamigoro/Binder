using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.ProgramFlow
{
    public class Step
    {
        /// <summary>
        /// Position of the step in the queue.
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Temperature order to give to the chamber in °C.
        /// </summary>
        public int Temperature { get; set; }
        /// <summary>
        /// Humidity order to give to the chamber in %.
        /// </summary>
        public int Humidity { get; set; }
        /// <summary>
        /// The time in minutes to wait before taking measure after hitting the desired temperature.
        /// </summary>
        public int StabilisationTime { get; set; }
    }
}
