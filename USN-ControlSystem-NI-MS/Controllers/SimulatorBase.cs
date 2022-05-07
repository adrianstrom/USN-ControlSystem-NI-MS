using System;

namespace USN_ControlSystem_NI_MS.Controllers
{
    public abstract class SimulatorBase
    {
        public TimeSpan TimeStep { get; set; } = new TimeSpan(0, 0, 1);
        public int StartTime { get; set; } // in seconds
        public int EndTime { get; set; } // in seconds
        public double NumberOfSimulations => ((EndTime - StartTime) / TimeStep.TotalSeconds) + 1;
    }
}
