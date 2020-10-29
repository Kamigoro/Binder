using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public class CountDownState : IState
    {
        public Cycle Cycle { get; set; }

        public void Run()
        {
            Console.WriteLine("Running CountDownState");
            Cycle.ChangeState(new StepExecutionState());
            Cycle.CurrentState.Run();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
