using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public class ConnexionCheckState : IState
    {
        public Cycle Cycle { get; set; }

        public void Run()
        {
            Console.WriteLine("Running ConnexionCheckState");
            Cycle.ChangeState(new CountDownState());
            Cycle.CurrentState.Run();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
