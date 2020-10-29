using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public class SensorsMeasurementState : IState
    {
        public string DisplayName { get; set; } = "Mesure des capteurs";
        public Cycle Cycle { get; set; }

        public SensorsMeasurementState(Cycle cycle)
        {
            Cycle = cycle;
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
