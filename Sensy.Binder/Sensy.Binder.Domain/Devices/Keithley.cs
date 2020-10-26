using Sensy.Binder.Domain.Devices.Data;
using Sensy.Binder.Domain.Devices.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sensy.Binder.Domain.Devices
{
    public class Keithley : IMeasurementDevice
    {
        public Task<DeviceStatus> IsConnectedAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SensorMeasure> MeasureChannelAsync(string channel, MeasurementFunction function)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SensorMeasure>> MeasureChannelsAsync(IEnumerable<string> channels, MeasurementFunction function)
        {
            throw new NotImplementedException();
        }
    }
}
