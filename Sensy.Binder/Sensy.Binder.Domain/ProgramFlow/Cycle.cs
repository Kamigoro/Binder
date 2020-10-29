using Sensy.Binder.Domain.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.ProgramFlow
{
    public class Cycle
    {
        public IState CurrentState { get; set; }
        public DateTime StartingTime { get; set; }
        public List<Step> Steps { get; set; }
        public List<Sensor> Sensors { get; set; }

        public Cycle()
        {
            CurrentState = new IdleState() { Cycle = this };
        }

        public void ChangeState(IState newState)
        {
            newState.Cycle = this;
            this.CurrentState = newState;
        }
    }
}
