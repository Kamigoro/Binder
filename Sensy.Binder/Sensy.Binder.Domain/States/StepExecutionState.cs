using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public class StepExecutionState : IState
    {
        public string DisplayName { get; set; } = "Exécution d'étape";
        public Cycle Cycle { get; set; }

        public StepExecutionState(Cycle cycle)
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
