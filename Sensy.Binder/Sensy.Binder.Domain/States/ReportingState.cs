using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public class ReportingState : IState
    {
        public Cycle Cycle { get; set; }

        public void Run()
        {
            Console.WriteLine("Running reporting state");
            Cycle.ChangeState(new IdleState());
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
