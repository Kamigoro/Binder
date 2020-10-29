using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public class SensorsMeasurementState : IState
    {
        public Cycle Cycle { get; set; }
        public List<Sensor> Sensors { get; set; }

        public SensorsMeasurementState(List<Sensor> sensors)
        {
            Sensors = sensors;
        }

        public void Run()
        {
            Console.WriteLine("Running SensorMeasurementState");
            foreach (Sensor sensor in Sensors)
            {
                Console.WriteLine($"\tMesure du capteur : {sensor.SerialNumber} sur le canal {sensor.MeasurementChannel}");
            }
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
