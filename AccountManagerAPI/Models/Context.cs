using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AccountManagerAPI.SeedData;

namespace AccountManagerAPI.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Account> Accounts {get;set;}
        public DbSet<Code> Codes {get;set;}
        public DbSet<EmailAccount> EmailAccounts {get;set;}
        public DbSet<Event> Events {get;set;}
        public DbSet<Game> Games {get;set;}
        public DbSet<GamePlatform> GamePlatforms {get;set;}
        public DbSet<Platform> Platforms {get;set;}

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            // Make sure each Email is unique
            ModelBuilder.Entity<EmailAccount>().HasIndex(ea => ea.Email).IsUnique();

            // Create All Keys for Manay to Many tables
            ModelBuilder.Entity<Account>().HasKey(a => new { a.EmailAccountId, a.PlatformId });
            // ModelBuilder.Entity<Code>().HasKey(c => new { c.AccountId, c.GameId });
            ModelBuilder.Entity<GamePlatform>().HasKey(gp => new { gp.GameId, gp.PlatformId });

            // Create base model
            base.OnModelCreating(ModelBuilder);

            // Use static class for seeded data
            ModelBuilder.AccountSeedData();
            ModelBuilder.CodeSeedData();
            ModelBuilder.EmailAccountSeedData();
            ModelBuilder.EventSeedData();
            ModelBuilder.GamePlatformSeedData();
            ModelBuilder.GameSeedData();
            ModelBuilder.PlatformSeedData();
        }
    }
}