using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.Devices.CustomException
{
    public class DeviceNotConnectedException : Exception
    {
        public DeviceNotConnectedException(string message) : base(message)
        {

        }

        public DeviceNotConnectedException(string message, string deviceName) : this(message)
        {

        }
    }
}
