using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public class ConnexionCheckState : IState
    {
        public Cycle Cycle { get; set; }
        public string DisplayName { get; set; } = "Vérification connexion";

        public ConnexionCheckState(Cycle cycle)
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
