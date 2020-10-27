using Sensy.Binder.Domain.Devices.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sensy.Binder.Domain.Devices
{
    public interface IDevice
    {
        /// <summary>
        /// Test asynchronously if the device is reachable.
        /// </summary>
        /// <returns>DeviceStatus.Connected if the device reachable, DeviceStatus.Disconnected if it is not reachable.</returns>
        Task<DeviceStatus> IsConnectedAsync();
    }
}
