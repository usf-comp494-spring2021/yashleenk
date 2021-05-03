/**
 * Author:           Yashleen Kheterpal
 * Date:             03/29/2021
 * Assignment:       Midterm
 * Course: COMP494:  C#
 * Purpose: Model for the Hourly Forecast
 *
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KheterpalFinalAplication.Models
{
    // Inheriting defination from WeatherForecast to HourlyForecast
    public class HourlyForecast : WeatherForecast
    {
        public int precipitationPercent { get; set; }
        public double precipitationAmount { get; set; }
        public int cloudCover { get; set; }
        public int dewPoint { get; set; }
        public int humidity { get; set; }

    }
}
