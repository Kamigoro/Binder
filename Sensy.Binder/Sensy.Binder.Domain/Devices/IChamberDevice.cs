using Sensy.Binder.Domain.Devices.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sensy.Binder.Domain.Devices
{
    public interface IChamberDevice : IDevice
    {
        /// <summary>
        /// Set the temperature of the chamber asynchronously. 
        /// <para>The value is checked to be fitting the chamber maximum and minimum.</para>
        /// </summary>
        /// <param name="temperature"></param>
        /// <returns></returns>
        Task SetTemperatureAsync(double temperature);
        /// <summary>
        /// Set the humidity percentage of the chamber asynchronously. 
        /// <para>The value is checked to be fitting the chamber maximum and minimum.</para>
        /// </summary>
        /// <param name="humidity"></param>
        /// <returns></returns>
        Task SetHumidityAsync(double humidity);
        /// <summary>
        /// Set the chamber in idle mode, so that it erases previous commands.
        /// </summary>
        /// <returns></returns>
        Task SetIdleAsync();
        /// <summary>
        /// Query the chamber about its current state.
        /// <para>Returns the temperature and humidity of the chamber</para>
        /// </summary>
        /// <returns></returns>
        Task<ChamberData> GetChamberDataAsync();
    }
}
