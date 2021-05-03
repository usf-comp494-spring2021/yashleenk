/**
 * Author:           Yashleen Kheterpal
 * Date:             03/29/2021
 * Assignment:       Midterm
 * Course: COMP494:  C#
 * Purpose: Model for Weather Forecast where defintions will be inherited for 
 *          Hourly Forecast and Detailed Forecast as well.
 *
 */

using System;

namespace KheterpalFinalAplication.Models
{
    public class WeatherForecast
    {
        public DateTime forecastDate { get; set; }

        public string location { get; set; }

        public double temperature { get; set; }

        public double feelsLike { get; set; }

        public string descriptor { get; set; }

        public string imagePath { get; set; }

        public double windSpeed { get; set; }

        public string windDirection { get; set; }

        public double pressure { get; set; }





    }
}
