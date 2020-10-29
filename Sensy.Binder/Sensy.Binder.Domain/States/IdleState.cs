using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public class IdleState : IState
    {

        public Cycle Cycle { get; set; }

        public void Run()
        {
            Console.WriteLine("Running Idle state");
            Cycle.ChangeState(new ConnexionCheckState());
            Cycle.CurrentState.Run();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
