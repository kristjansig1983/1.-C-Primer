using System;

public class WeatherData
{

    private double _temperature;
    private double _humidity;
    private char _scale;

    public double Temperature
    {
        get { return _temperature; }
        set
        {
            if (value < -60 || value > 60)
            {
                Console.WriteLine("Error: Temperature must be between -60 and 60 Celsius (-76 and 140 Farenheit).");
            }
            else
            {
                _temperature = value;
            }
        }
    }

    public double Humidity
    {
        get { return _humidity; }
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine("Error: Humidity must be between 0% and 100%.");
            }
            else
            {
                _humidity = value;
            }
        }
    }
    public char Scale
    {
        get { return _scale; }
        set { _scale = value; }
    }

    public void Convert()
    {
        if (_scale == 'C')
        {
            _temperature = (_temperature * 9 / 5) + 32;
            _scale = 'F';
        }
        else if (_scale == 'F')
        {
            _temperature = (_temperature - 32) * 5 / 9;
            _scale = 'C';
        }
    }
}




