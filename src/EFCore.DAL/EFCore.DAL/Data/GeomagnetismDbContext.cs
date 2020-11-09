using EFCore.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.DAL
{
    public class GeomagnetismDbContext : DbContext
    {
        #region 公共属性

        /// <summary>
        /// 设备状态
        /// </summary>
        public DbSet<Status> Status { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        public DbSet<Info> Info { get; set; }

        #endregion

        #region 构造函数

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="options"></param>
        public GeomagnetismDbContext(DbContextOptions<GeomagnetismDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Info>(builder => builder.HasKey(nameof(EFCore.DAL.Model.Info.serial)));
            modelBuilder.Entity<Status>(builder => builder.HasKey(nameof(EFCore.DAL.Model.Status.serial)));
        }

        #endregion
    }
}
