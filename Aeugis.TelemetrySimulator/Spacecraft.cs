using System;
using System.Collections.Generic;
using System.Text;

namespace Aeugis.TelemetrySimulator
{
    public class Spacecraft
    {
        public string Name { get; set; } = "";

        public double Temperature { get; set; }

        public double BatteryVoltage { get; set; }

        public bool AntennaOnline { get; set; }
    }
}
