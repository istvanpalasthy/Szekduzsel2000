using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Szkeduel2000
{
    public class Program
    {
        private static readonly string dbHost = Environment.GetEnvironmentVariable("DBHOST");
        private static readonly string dbUser = Environment.GetEnvironmentVariable("DBUSER");
        private static readonly string dbPass = Environment.GetEnvironmentVariable("DBPASS");
        private static readonly string dbName = Environment.GetEnvironmentVariable("DBNAME");

        public static readonly string connectionString = $"Host={dbHost};Username={dbUser};Password={dbPass};Database={dbName}";
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
