using Sensy.Binder.Domain.Devices.Data;
using Sensy.Binder.Domain.Devices.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sensy.Binder.Domain.Devices
{
    public class Binder : IChamberDevice
    {
        public Task<DeviceStatus> IsConnectedAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ChamberData> GetChamberDataAsync()
        {
            throw new NotImplementedException();
        }

        public Task SetHumidityAsync(double temperature)
        {
            throw new NotImplementedException();
        }

        public Task SetIdleAsync()
        {
            throw new NotImplementedException();
        }

        public Task SetTemperatureAsync(double temperature)
        {
            throw new NotImplementedException();
        }
    }
}
