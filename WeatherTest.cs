using System;

class Program

{

    static void Main(string[] args)

    {

        // Create a new instance of WeatherData

        WeatherData weatherData = new WeatherData();



        // Set some values

        weatherData.Temperature = 25.0;

        weatherData.Humidity = 60.0;

        weatherData.Scale = 'C';



        // Print the current values

        Console.WriteLine("Temperature: {0} {1}", weatherData.Temperature, weatherData.Scale);

        Console.WriteLine("Humidity: {0}%", weatherData.Humidity);



        // Convert to Fahrenheit

        weatherData.Convert();



        // Print the new values

        Console.WriteLine("Temperature: {0} {1}", weatherData.Temperature, weatherData.Scale);

        Console.WriteLine("Humidity: {0}%", weatherData.Humidity);



        // Convert back to Celsius

        weatherData.Convert();



        // Print the original values

        Console.WriteLine("Temperature: {0} {1}", weatherData.Temperature, weatherData.Scale);

        Console.WriteLine("Humidity: {0}%", weatherData.Humidity);



        // Try setting an invalid temperature value

        weatherData.Temperature = 80.0;

        Console.WriteLine("Temperature: {0} {1}", weatherData.Temperature, weatherData.Scale);
        Console.ReadLine();

    }

}