using Sensy.Binder.Domain;
using Sensy.Binder.Domain.Devices;
using System;
using System.Text;
using System.Threading;

namespace Sensy.Binder
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Settings.PythonScriptPath = @"PythonScript/Binder.py";
            IChamberDevice binder = new Domain.Devices.Binder("192.168.0.50");
            var result = await binder.GetChamberDataAsync();
            Console.WriteLine(result.Note);
            Console.WriteLine(result.Mode);
            Console.WriteLine(result.Door);
            Console.WriteLine(result.Humidity);
            Console.WriteLine(result.Temperature);
            Console.WriteLine(result.TargetTemperature);
        }
    }
}
