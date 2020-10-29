using Sensy.Binder.Domain;
using Sensy.Binder.Domain.Devices;
using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sensy.Binder
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*Settings.PythonScriptPath = @"PythonScript/Binder.py";
            IChamberDevice climatronix = new Climatronix("192.168.0.50");
            var result = await climatronix.GetChamberDataAsync();
            Console.WriteLine($"Humidité : {result.Humidity}%");
            Console.WriteLine($"Température : {result.Temperature}°C");
            Console.WriteLine($"Température visée : {result.TargetTemperature}°C");*/

            Cycle cycle = new Cycle();
            List<Sensor> sensors = new List<Sensor>()
            {
                new Sensor(){ SerialNumber = "Test-123", MeasurementChannel = 101 },
                new Sensor(){ SerialNumber = "Test-456", MeasurementChannel = 102},
                new Sensor(){ SerialNumber = "Test-789", MeasurementChannel = 103}
            };
            List<Step> steps = new List<Step>()
            {
                new Step(){Number = 1, Temperature = 50, Humidity = 50, StabilisationTime=20},
                new Step(){Number = 2, Temperature = 75, Humidity = 10, StabilisationTime=20},
                new Step(){Number = 3, Temperature = -20, Humidity = 20, StabilisationTime=20},
                new Step(){Number = 4, Temperature = -40, Humidity = 30, StabilisationTime=20}
            };
            cycle.Sensors = sensors;
            cycle.Steps = steps;

            cycle.CurrentState.Run();

        }
    }
}
