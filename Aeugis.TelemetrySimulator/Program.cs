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
Console.WriteLine("AEGIS MISSION CONTROL");
Console.WriteLine("Spacecraft: " + odyssey.Name);
Console.WriteLine("Temperature: " + odyssey.Temperature);
Console.WriteLine("Battery Voltage: " + odyssey.BatteryVoltage);
Console.WriteLine("Antenna Online: " + odyssey.AntennaOnline);