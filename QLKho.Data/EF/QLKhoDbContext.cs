using Microsoft.EntityFrameworkCore;
using QLKho.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Data.EF
{
    public class QLKhoDbContext : DbContext
    {
        public QLKhoDbContext(DbContextOptions options) : base(options)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LTHIENDUC\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Suplier> Supliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Input> Inputs { get; set; }
        public DbSet<InputInfo> InputInfos { get; set; }
        public DbSet<Output> Outputs { get; set; }
        public DbSet<OutputInfo> OutputInfos { get; set; }

    }
}
