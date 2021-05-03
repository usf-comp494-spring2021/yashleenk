/**
 * Author:           Yashleen Kheterpal
 * Date:             05/03/2021
 * Assignment:       Final Program
 * Course: COMP494:  C#
 * Purpose: Working with the MVC pojct to create web app
 *          Working with the APIs web project and using swagger
 *
 */
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KheterpalFinalAplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    
                });
    }
}
