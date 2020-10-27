using Sensy.Binder.Domain.Devices.Data;
using Sensy.Binder.Domain.Devices.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Sensy.Binder.Domain.Devices
{
    public class Binder : IChamberDevice
    {
        public string IPAddress { get; set; }
        private const int MaximumTemperature = 180;
        private const int MinimumTemperature = -40;
        private const int MaximumHumidity = 100;
        private const int MinimumHumidity = 0;

        public Binder(string ipAddress)
        {
            IPAddress = ipAddress;
        }

        public async Task<DeviceStatus> IsConnectedAsync()
        {
            Ping ping = new Ping();
            PingReply pingReply = await ping.SendPingAsync(IPAddress);
            if (pingReply.Status == IPStatus.Success)
            {
                return DeviceStatus.Connected;
            }
            else
            {
                return DeviceStatus.Disconnected;
            }
        }

        public async Task SetIdleAsync()
        {
            await ExecutePythonCommand("-I");
        }

        public async Task SetHumidityAsync(int humidity)
        {
            if (humidity <= MaximumHumidity && humidity >= MinimumHumidity)
            {
                await ExecutePythonCommand($"-H {humidity}");
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(humidity), humidity, $"Humidity should be between {MinimumHumidity}% and {MaximumHumidity}%");
            }
        }

        public async Task SetTemperatureAsync(int temperature)
        {
            if (temperature <= MaximumTemperature && temperature >= MinimumTemperature)
            {
                await ExecutePythonCommand($"-T {temperature}");
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(temperature), temperature, $"Humidity should be between {MinimumTemperature}°C and {MaximumTemperature}°C");
            }
        }

        public async Task<ChamberData> GetChamberDataAsync()
        {
            // TODO Implement chamber data retrieving
            throw new NotImplementedException();
        }

        /// <summary>
        /// Execute the python script controlling the chamber with specified parameters and force the command.
        /// </summary>
        /// <param name="parameters">Temperature or humidity percentage.</param>
        /// <returns></returns>
        private async Task ExecutePythonCommand(string parameters)
        {
            await Task.Run(() =>
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "python";
                startInfo.Arguments = $"{Settings.PythonScriptPath} -A {IPAddress} {parameters} -f";
                process.StartInfo = startInfo;
                process.Start();
            });
        }

    }
}
