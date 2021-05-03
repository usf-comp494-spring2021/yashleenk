/**
 * Author:           Yashleen Kheterpal
 * Date:             03/29/2021
 * Assignment:       Midterm
 * Course: COMP494:  C#
 * Purpose: Model for Detailed Forecast
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KheterpalFinalAplication.Models
{
    // Inheriting definitions from WeatherForecast to DetailedForecast
    public class DetailedForecast : WeatherForecast
    {
        public int visibility { get; set; }
        public string clouds { get; set; }
        public int humidity { get; set; }
        public double rainfall { get; set; }
        public double snowfall { get; set; }
    }
}
