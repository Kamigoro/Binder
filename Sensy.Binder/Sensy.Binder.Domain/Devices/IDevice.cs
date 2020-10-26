using Sensy.Binder.Domain.Devices.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sensy.Binder.Domain.Devices
{
    public interface IDevice
    {
        Task<DeviceStatus> IsConnectedAsync();
    }
}
