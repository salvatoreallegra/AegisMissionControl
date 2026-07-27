using System;
using System.Collections.Generic;
using System.Text;

namespace Aeugis.TelemetrySimulator
{
    public class Spacecraft
    {
        public Spacecraft(string name)
        {
            Name = name;
            Console.WriteLine("Creating spacecraft...");
        }
        public string Name { get; set; } = "";

        public double Temperature { get; set; }

        public double BatteryVoltage { get; set; }

        public bool AntennaOnline { get; set; }

        public bool HasLowBattery()
        {
            return BatteryVoltage < 20.0;
        }
        public bool IsOverheating(double limit)
        {
            return Temperature > limit;
        }
        public bool IsTemperatureWithinRange(double minimum, double maximum)
        {
            return Temperature >= minimum &&
                   Temperature <= maximum;
        }
        public void SetTemperature(double temperature)
        {
            if (temperature < -273.15)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(temperature),
                    "Temperature cannot be below absolute zero.");
            }

            Temperature = temperature;
        }
        public void PrintStatus()
        {
            Console.WriteLine("Spacecraft: " + Name);
            Console.WriteLine("Temperature: " + Temperature);
            Console.WriteLine("Battery Voltage: " + BatteryVoltage);
            Console.WriteLine("Antenna Online: " + AntennaOnline);
        }
    }
}
