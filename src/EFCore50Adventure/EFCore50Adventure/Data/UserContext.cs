using EFCore50Adventure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore50Adventure.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseSqlite($"Data Source=user.db")
            .LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted })
            .EnableSensitiveDataLogging();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 字段在继承层次的同一个表
            //modelBuilder.Entity<ExternalUser>();
            //modelBuilder.Entity<TimeRestrictedUser>();

            // 字段在新的表
            modelBuilder.Entity<ExternalUser>().ToTable("ExternalUsers");
            modelBuilder.Entity<TimeRestrictedUser>().ToTable("TimeRestrictedUsers");

            modelBuilder.Entity<User>()
                .HasMany(u => u.Groups)
                .WithMany(g => g.Users)
                .UsingEntity<Membership>(
                    j => j.HasOne(m => m.Group).WithMany(g => g.Memberships),
                    j => j.HasOne(m => m.User).WithMany(g => g.Memberships));
        }
    }
}
