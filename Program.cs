using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace dotnetapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder()
                .ConfigureAppConfiguration((ctx, cfg) =>
                {
                cfg.SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("config.json", true) // require the json file!
                    .AddEnvironmentVariables();
                })
                .ConfigureLogging((ctx, logging) => { }) // No logging
                .UseStartup<Startup>()
                .UseSetting("DesignTime", "true")
                .Build();
        }
    }
}
