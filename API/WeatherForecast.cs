using System;

namespace API
{
    public class WeatherForecast
    {
        private DateTime date;

        public System.DateTime Date { get => date; set => date = value; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

}

