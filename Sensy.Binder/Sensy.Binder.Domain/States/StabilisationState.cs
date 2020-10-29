using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public class StabilisationState : IState
    {
        public Cycle Cycle { get; set; }
        public int MinuteToWait { get; set; }

        public StabilisationState(int minuteToWait)
        {
            MinuteToWait = minuteToWait;
        }

        public void Run()
        {
            Console.WriteLine("Running StabilisationState");
            Console.WriteLine($"\tWaiting : {MinuteToWait}mn");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
