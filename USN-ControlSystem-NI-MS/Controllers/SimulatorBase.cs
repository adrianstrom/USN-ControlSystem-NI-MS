using System;

namespace USN_ControlSystem_NI_MS.Controllers
{
    public abstract class SimulatorBase
    {
        public TimeSpan TimeStep { get; set; } = new TimeSpan(0, 0, 0, 0, 100);
    }
}
