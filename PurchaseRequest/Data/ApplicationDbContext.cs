﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PurchaseRequest.Configurations.Entities;
using PurchaseRequest.Models;

namespace PurchaseRequest.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        public DbSet<PurchaseType> PurchaseTypes { get; set; }
        public DbSet<PurchaseAllocation> PurchaseAllocations { get; set; }
        public DbSet<PurchasingRequest> PurchasingRequests { get; set; }
    }
}