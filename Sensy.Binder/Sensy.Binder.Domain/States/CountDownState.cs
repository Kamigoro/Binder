using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public class CountDownState : IState
    {
        public string DisplayName { get; set; } = "Attente de l'heure de départ";
        public Cycle Cycle { get; set; }

        public CountDownState(Cycle cycle)
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
