double degreesInCelsius = double.Parse(Console.ReadLine());

double degreesInFahrenheit = degreesInCelsius * 1.8  + 32;

Console.WriteLine($"{degreesInFahrenheit:F2}");