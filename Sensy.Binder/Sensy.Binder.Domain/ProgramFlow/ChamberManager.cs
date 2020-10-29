using Sensy.Binder.Domain.Devices;
using Sensy.Binder.Domain.Devices.CustomException;
using Sensy.Binder.Domain.Devices.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Sensy.Binder.Domain.ProgramFlow
{
    public class ChamberManager
    {
        public IChamberDevice Chamber { get; set; }
        public EventHandler<ChamberData> NewDataEvent { get; set; }

        public ChamberManager(IChamberDevice chamberDevice)
        {
            Chamber = chamberDevice;
            Timer timer = new Timer(10000);
            timer.Elapsed += OnTimedEventAsync;
            timer.Start();
        }

        private async void OnTimedEventAsync(object sender, ElapsedEventArgs e)
        {
            try
            {
                var chamberData = await Chamber.GetChamberDataAsync();
                NewDataEvent?.Invoke(this, chamberData);
            }
            catch (DeviceNotConnectedException exception)
            {
                //TODO Manage exception
                throw exception;
            }

        }
    }
}
