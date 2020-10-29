using Sensy.Binder.Domain.ProgramFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain.States
{
    public class StepExecutionState : IState
    {
        public Cycle Cycle { get; set; }

        public void Run()
        {
            foreach (Step step in Cycle.Steps)
            {
                Console.WriteLine("Running step");
                Console.WriteLine($"\tSending command to Chamber\n\tTemperature : {step.Temperature}\n\tHumidity : {step.Humidity}");
                new StabilisationState(step.StabilisationTime).Run();
                new SensorsMeasurementState(Cycle.Sensors).Run();
            }
            Cycle.ChangeState(new ReportingState());
            Cycle.CurrentState.Run();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
