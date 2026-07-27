using Aeugis.TelemetrySimulator;

List<Spacecraft> fleet =
[
    new Spacecraft("Odyssey-1")
    {
        Temperature = 84.2,
        BatteryVoltage = 21.7,
        AntennaOnline = true
    },

    new Spacecraft("Voyager-7")
    {
        Temperature = 62.8,
        BatteryVoltage = 18.4,
        AntennaOnline = true
    },

    new Spacecraft("Europa-Probe")
    {
        Temperature = 91.3,
        BatteryVoltage = 14.2,
        AntennaOnline = false
    }
];

foreach (Spacecraft spacecraft in fleet)
{
    spacecraft.PrintStatus();

    if (spacecraft.IsOverheating(80))
    {
        Console.WriteLine("ALERT: Critical temperature.");
    }

    if (!spacecraft.AntennaOnline)
    {
        Console.WriteLine("ALERT: Antenna offline.");
    }

    Console.WriteLine();
}

List<Spacecraft> overHeatingSpacecraft =
    fleet.Where(spacecraft => spacecraft.IsOverheating(80))
    .ToList();

Console.WriteLine("Overheating Spacecraft:");
foreach (Spacecraft spacecraft in overHeatingSpacecraft)
{
    Console.WriteLine($"{spacecraft.Name}: {spacecraft.Temperature}");
}

