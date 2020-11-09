using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySql.DAL.Core.MyDbData
{
    public class MyDbContext : DbContext
    {
        public DbSet<biz_GeomagCurrentStatus> biz_GeomagCurrentStatus { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) :base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<biz_GeomagCurrentStatus>(builder =>
            {
                builder.HasKey(nameof(MySql.DAL.Core.MyDbData.biz_GeomagCurrentStatus.Id));
            });
        }
    }
}
