using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace TrackRoad.Infra.Persistence
{
    public class TrackRoadContextFactory
    {
        public TrackRoadContext CreateDbContext(string[] args)
        {
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.json", optional: true)
                .Build();

            var builder = new DbContextOptionsBuilder<TrackRoadContext>();

            var connectionString = configuration.GetConnectionString("dbConnection");

            builder.UseSqlServer(connectionString);

            return new TrackRoadContext(builder.Options);
        }
    }
}
