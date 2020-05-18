using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QLKho.Data.EF
{
    class QLKhoDbContextFactory : IDesignTimeDbContextFactory<QLKhoDbContext>
    {
        public QLKhoDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("QLKhoDB");
            var optionsBuilder = new DbContextOptionsBuilder<QLKhoDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new QLKhoDbContext(optionsBuilder.Options);

        }
    }
}
