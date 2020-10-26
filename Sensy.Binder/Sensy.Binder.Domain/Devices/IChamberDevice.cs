using Sensy.Binder.Domain.Devices.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sensy.Binder.Domain.Devices
{
    public interface IChamberDevice : IDevice
    {
        Task SetTemperatureAsync(double temperature);
        Task SetHumidityAsync(double temperature);
        Task SetIdleAsync();
        Task<ChamberData> GetChamberDataAsync();
    }
}
