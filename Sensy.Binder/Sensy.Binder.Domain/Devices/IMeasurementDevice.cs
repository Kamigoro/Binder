using Sensy.Binder.Domain.Devices.Data;
using Sensy.Binder.Domain.Devices.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sensy.Binder.Domain.Devices
{
    public interface IMeasurementDevice : IDevice
    {
        Task<SensorMeasure> MeasureChannelAsync(string channel, MeasurementFunction function);
        Task<IEnumerable<SensorMeasure>> MeasureChannelsAsync(IEnumerable<string> channels, MeasurementFunction function);
    }
}
