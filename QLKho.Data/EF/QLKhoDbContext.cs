﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QLKho.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Data.EF
{
    public class QLKhoDbContext : IdentityDbContext<User,Role,Guid>
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
            //Customer
            modelBuilder.Entity<Customer>().ToTable("Customers").HasKey(x=>x.Id);
            modelBuilder.Entity<Customer>()
                .HasMany<OutputInfo>(o => o.OutputInfos)
                .WithOne(c => c.Customer)
                .HasForeignKey(f=>f.IdCustomer);
            //Input
            modelBuilder.Entity<Input>().ToTable("Inputs").HasKey(i => i.Id);
            modelBuilder.Entity<Input>()
                .HasMany<InputInfo>(IIF => IIF.InputInfos)
                .WithOne(i => i.Input)
                .HasForeignKey(f => f.IdInput);
            //InputInfo
            modelBuilder.Entity<InputInfo>().ToTable("InputInfos").HasKey(iif => iif.Id);
            modelBuilder.Entity<InputInfo>()
                .HasMany<OutputInfo>(o => o.OutputInfos)
                .WithOne(i => i.InputInfo)
                .HasForeignKey(f => f.IdInputInfo);
            //Item 
            modelBuilder.Entity<Item>().ToTable("Items").HasKey(I => I.Id);
            modelBuilder.Entity<Item>()
                .HasMany<InputInfo>(i => i.InputInfos)
                .WithOne(i => i.Item)
                .HasForeignKey(f => f.IdItem);
            modelBuilder.Entity<Item>()
                .HasMany<OutputInfo>(o => o.OutputInfos)
                .WithOne(i => i.Item)
                .HasForeignKey(f => f.IdItem);
            //Output
            modelBuilder.Entity<Output>().ToTable("Outputs").HasKey(o => o.Id);
            modelBuilder.Entity<Output>()
                .HasMany<OutputInfo>(o => o.OutputInfos)
                .WithOne(o => o.Output)
                .HasForeignKey(f => f.IdOutput);
            //Output Info
            modelBuilder.Entity<OutputInfo>().ToTable("OutputInfos").HasKey(o => o.Id);
            //Suplier
            modelBuilder.Entity<Suplier>().ToTable("Supliers").HasKey(s => s.Id);
            modelBuilder.Entity<Suplier>()
                .HasMany<Item>(i => i.Items)
                .WithOne(s => s.Suplier)
                .HasForeignKey(f => f.IdSuplier);
            //Unit
            modelBuilder.Entity<Unit>().ToTable("Units").HasKey(u => u.Id);
            modelBuilder.Entity<Unit>()
                .HasMany<Item>(i => i.Items)
                .WithOne(u => u.Unit)
                .HasForeignKey(f => f.IdUnit);
            //User
            modelBuilder.Entity<User>().ToTable("Users").HasKey(u => u.Id);
            modelBuilder.Entity<User>()
                .HasMany<Input>(i => i.Inputs)
                .WithOne(u => u.User)
                .HasForeignKey(f => f.IdUser);
            modelBuilder.Entity<User>()
                .HasMany<Output>(o => o.Outputs)
                .WithOne(u => u.User)
                .HasForeignKey(f => f.IdUser);
            //Role
            modelBuilder.Entity<Role>().ToTable("Roles").HasKey(r => r.Id);
            modelBuilder.Entity<Role>().Property(r => r.Notes).IsRequired();

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles").HasKey(o=>new { o.UserId, o.RoleId});
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins").HasKey(o=>o.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens").HasKey(o=>o.UserId);
               
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer();
        //}
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
