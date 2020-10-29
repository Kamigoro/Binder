using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public interface IState
    {
        public Cycle Cycle { get; set; }
        void Run();
        void Stop();
    }
}
