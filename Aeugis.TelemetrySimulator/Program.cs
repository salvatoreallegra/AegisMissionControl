using Aeugis.TelemetrySimulator;

Spacecraft odyssey = new Spacecraft
{
    Name = "Odyssey-1",
    Temperature = 82.4,
    BatteryVoltage = 21.7,
    AntennaOnline = true
};

Spacecraft voyager = new Spacecraft
{
    Name = "Voyager-7",
    Temperature = 76.8,
    BatteryVoltage = 22.1,
    AntennaOnline = false
};
odyssey.PrintStatus();
voyager.PrintStatus();
Console.WriteLine(odyssey.HasLowBattery());
Console.WriteLine(voyager.HasLowBattery());
Console.WriteLine(odyssey.IsOverheating(24));
Console.WriteLine(voyager.IsOverheating(88));
