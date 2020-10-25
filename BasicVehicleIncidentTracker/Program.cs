using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicVehicleIncidentTracker.DAL;
using BasicVehicleIncidentTracker.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BasicVehicleIncidentTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            var options = new DbContextOptionsBuilder<MyContext>()
                .UseInMemoryDatabase(databaseName: "Test")
                .Options;

            using (var context = new MyContext(options))
            {
                var customer = new Customer
                {
                    FirstName = "Elizabeth",
                    LastName = "Lincoln",
                    Address = "23 Tsawassen Blvd."
                };

                context.Customers.Add(customer);
                context.SaveChanges();

            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
