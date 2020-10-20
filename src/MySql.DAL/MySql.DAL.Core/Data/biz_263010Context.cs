using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MySql.DAL.Core
{
    public partial class biz_263010Context : DbContext
    {
        public biz_263010Context(DbContextOptions<biz_263010Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Biz263010AtmosphereDataDay> Biz263010AtmosphereDataDay { get; set; }
        public virtual DbSet<Biz263010AtmosphereDataHour> Biz263010AtmosphereDataHour { get; set; }
        public virtual DbSet<Biz263010AtmosphereObjInfo> Biz263010AtmosphereObjInfo { get; set; }
        public virtual DbSet<Biz263010CgdbsDataCg> Biz263010CgdbsDataCg { get; set; }
        public virtual DbSet<Biz263010CgdbsDataYy> Biz263010CgdbsDataYy { get; set; }
        public virtual DbSet<Biz263010CgdbsObjInfo> Biz263010CgdbsObjInfo { get; set; }
        public virtual DbSet<Biz263010HddbsDataHd> Biz263010HddbsDataHd { get; set; }
        public virtual DbSet<Biz263010HddbsObjInfo> Biz263010HddbsObjInfo { get; set; }
        public virtual DbSet<Biz263010JhpjwgzdDataDayR> Biz263010JhpjwgzdDataDayR { get; set; }
        public virtual DbSet<Biz263010JhpjwgzdDataHourR> Biz263010JhpjwgzdDataHourR { get; set; }
        public virtual DbSet<Biz263010JhpjwgzdDataHourZ> Biz263010JhpjwgzdDataHourZ { get; set; }
        public virtual DbSet<Biz263010SzzdjcjcdDataDay> Biz263010SzzdjcjcdDataDay { get; set; }
        public virtual DbSet<Biz263010SzzdjcjcdDataHour> Biz263010SzzdjcjcdDataHour { get; set; }
        public virtual DbSet<Biz263010SzzdjcjcdDataMonth> Biz263010SzzdjcjcdDataMonth { get; set; }
        public virtual DbSet<Biz263010SzzdjcjcdObjInfo> Biz263010SzzdjcjcdObjInfo { get; set; }
        public virtual DbSet<Biz263010YcjcdDataDay> Biz263010YcjcdDataDay { get; set; }
        public virtual DbSet<Biz263010YcjcdDataHour> Biz263010YcjcdDataHour { get; set; }
        public virtual DbSet<Biz263010YcjcdObjInfo> Biz263010YcjcdObjInfo { get; set; }
        public virtual DbSet<Biz263010YyszdjcdDataHour> Biz263010YyszdjcdDataHour { get; set; }
        public virtual DbSet<Biz263010YyszdjcdObjInfo> Biz263010YyszdjcdObjInfo { get; set; }
        public virtual DbSet<TbAtmosphereDataDay> TbAtmosphereDataDay { get; set; }
        public virtual DbSet<TbAtmosphereDataHour> TbAtmosphereDataHour { get; set; }
        public virtual DbSet<TbAtmosphereObjInfo> TbAtmosphereObjInfo { get; set; }
        public virtual DbSet<TbCgdbsDataCg> TbCgdbsDataCg { get; set; }
        public virtual DbSet<TbCgdbsDataYy> TbCgdbsDataYy { get; set; }
        public virtual DbSet<TbCgdbsObjInfo> TbCgdbsObjInfo { get; set; }
        public virtual DbSet<TbHddbsDataHd> TbHddbsDataHd { get; set; }
        public virtual DbSet<TbHddbsObjInfo> TbHddbsObjInfo { get; set; }
        public virtual DbSet<TbJhpjwgzdDataDayR> TbJhpjwgzdDataDayR { get; set; }
        public virtual DbSet<TbJhpjwgzdDataHourR> TbJhpjwgzdDataHourR { get; set; }
        public virtual DbSet<TbJhpjwgzdDataHourZ> TbJhpjwgzdDataHourZ { get; set; }
        public virtual DbSet<TbSzzdjcjcdDataDay> TbSzzdjcjcdDataDay { get; set; }
        public virtual DbSet<TbSzzdjcjcdDataHour> TbSzzdjcjcdDataHour { get; set; }
        public virtual DbSet<TbSzzdjcjcdDataMonth> TbSzzdjcjcdDataMonth { get; set; }
        public virtual DbSet<TbSzzdjcjcdObjInfo> TbSzzdjcjcdObjInfo { get; set; }
        public virtual DbSet<TbYcjcdDataDay> TbYcjcdDataDay { get; set; }
        public virtual DbSet<TbYcjcdDataHour> TbYcjcdDataHour { get; set; }
        public virtual DbSet<TbYcjcdObjInfo> TbYcjcdObjInfo { get; set; }
        public virtual DbSet<TbYyszdjcdDataHour> TbYyszdjcdDataHour { get; set; }
        public virtual DbSet<TbYyszdjcdObjInfo> TbYyszdjcdObjInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;database=biz_263010;user=root;password=357592895;treattinyasboolean=true", x => x.ServerVersion("5.7.26-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Biz263010AtmosphereDataDay>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_atmosphere_data_day");

                entity.HasComment("大气的对象数据信息（日数据）");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id,数据表主键id（自增）");

                entity.Property(e => e.Aqi)
                    .HasColumnName("aqi")
                    .HasColumnType("double(8,0)")
                    .HasComment("AQI指数");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Co)
                    .HasColumnName("co")
                    .HasColumnType("double(8,0)")
                    .HasComment("一氧化碳");

                entity.Property(e => e.Cofzs)
                    .HasColumnName("cofzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("一氧化碳分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除,1代表正常,0代表删除");

                entity.Property(e => e.Kqzllb)
                    .HasColumnName("kqzllb")
                    .HasColumnType("varchar(255)")
                    .HasComment("空气质量类别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Kqzlys)
                    .HasColumnName("kqzlys")
                    .HasColumnType("varchar(255)")
                    .HasComment("空气质量颜色")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Kqzlzsjb)
                    .HasColumnName("kqzlzsjb")
                    .HasColumnType("varchar(255)")
                    .HasComment("空气质量指数级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.No2)
                    .HasColumnName("no2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化氮");

                entity.Property(e => e.No2fzs)
                    .HasColumnName("no2fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("二氧化氮分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.O3)
                    .HasColumnName("o3")
                    .HasColumnType("double(8,0)")
                    .HasComment("氧3");

                entity.Property(e => e.O38)
                    .HasColumnName("o38")
                    .HasColumnType("double(8,0)")
                    .HasComment("O3最大8小时滑动平均浓度");

                entity.Property(e => e.O3fzs)
                    .HasColumnName("o3fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("氧3分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.O3h1)
                    .HasColumnName("o3h1")
                    .HasColumnType("varchar(255)")
                    .HasComment("O3最大1小时滑动浓度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.O3h1fzs)
                    .HasColumnName("o3h1fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("O3最大1小时滑动分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.O3h8fzs)
                    .HasColumnName("o3h8fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("O3最大8小时滑动平均分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和对象信息表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm10");

                entity.Property(e => e.Pm10fzs)
                    .HasColumnName("pm10fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm10分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm10h24)
                    .HasColumnName("pm10h24")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm10,24小时平均浓度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm10h24fzs)
                    .HasColumnName("pm10h24fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm10,24小时平均分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm2.5");

                entity.Property(e => e.Pm25fzs)
                    .HasColumnName("pm25fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm25分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm25h24)
                    .HasColumnName("pm25h24")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm2.5,24小时平均浓度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm25h24fzs)
                    .HasColumnName("pm25h24fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm2.5,24小时平均分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.So2)
                    .HasColumnName("so2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化硫");

                entity.Property(e => e.So2fzs)
                    .HasColumnName("so2fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("二氧化硫分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Sywrw)
                    .HasColumnName("sywrw")
                    .HasColumnType("varchar(255)")
                    .HasComment("首要污染物")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Sywrwnd)
                    .HasColumnName("sywrwnd")
                    .HasColumnType("varchar(255)")
                    .HasComment("首要污染物浓度,有污染物时有值")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）");
            });

            modelBuilder.Entity<Biz263010AtmosphereDataHour>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_atmosphere_data_hour");

                entity.HasComment("大气的对象数据信息（小时数据）");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增）");

                entity.Property(e => e.Aqi)
                    .HasColumnName("aqi")
                    .HasColumnType("double(8,0)")
                    .HasComment("AQI指数");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Co)
                    .HasColumnName("co")
                    .HasColumnType("double(8,0)")
                    .HasComment("一氧化碳");

                entity.Property(e => e.Cofzs)
                    .HasColumnName("cofzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("一氧化碳分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.Kqzllb)
                    .HasColumnName("kqzllb")
                    .HasColumnType("varchar(255)")
                    .HasComment("空气质量类别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Kqzlys)
                    .HasColumnName("kqzlys")
                    .HasColumnType("varchar(255)")
                    .HasComment("空气质量颜色")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Kqzlzsjb)
                    .HasColumnName("kqzlzsjb")
                    .HasColumnType("varchar(255)")
                    .HasComment("空气质量指数级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.No2)
                    .HasColumnName("no2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化氮");

                entity.Property(e => e.No2fzs)
                    .HasColumnName("no2fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("二氧化氮分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.O3)
                    .HasColumnName("o3")
                    .HasColumnType("double(8,0)")
                    .HasComment("氧3");

                entity.Property(e => e.O38)
                    .HasColumnName("o38")
                    .HasColumnType("double(8,0)")
                    .HasComment("O3最大8小时滑动平均浓度");

                entity.Property(e => e.O3fzs)
                    .HasColumnName("o3fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("氧3分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.O3h1)
                    .HasColumnName("o3h1")
                    .HasColumnType("varchar(255)")
                    .HasComment("O3最大1小时滑动浓度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.O3h1fzs)
                    .HasColumnName("o3h1fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("O3最大1小时滑动分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.O3h8fzs)
                    .HasColumnName("o3h8fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("O3最大8小时滑动平均分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm10");

                entity.Property(e => e.Pm10fzs)
                    .HasColumnName("pm10fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm10分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm10h24)
                    .HasColumnName("pm10h24")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm10  24小时平均浓度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm10h24fzs)
                    .HasColumnName("pm10h24fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm10  24小时平均分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm2.5");

                entity.Property(e => e.Pm25fzs)
                    .HasColumnName("pm25fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm25分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm25h24)
                    .HasColumnName("pm25h24")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm2.5  24小时平均浓度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm25h24fzs)
                    .HasColumnName("pm25h24fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm2.5  24小时平均分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.So2)
                    .HasColumnName("so2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化硫");

                entity.Property(e => e.So2fzs)
                    .HasColumnName("so2fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("二氧化硫分指数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Sywrw)
                    .HasColumnName("sywrw")
                    .HasColumnType("varchar(255)")
                    .HasComment("首要污染物")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Sywrwnd)
                    .HasColumnName("sywrwnd")
                    .HasColumnType("varchar(255)")
                    .HasComment("首要污染物浓度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间");
            });

            modelBuilder.Entity<Biz263010AtmosphereObjInfo>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_atmosphere_obj_info");

                entity.HasComment("大气的对象信息");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)")
                    .HasComment("主键id");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除");

                entity.Property(e => e.Jd)
                    .HasColumnName("jd")
                    .HasColumnType("varchar(255)")
                    .HasComment("经度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Objtypename)
                    .IsRequired()
                    .HasColumnName("objtypename")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象类型名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Sfcypj)
                    .HasColumnName("sfcypj")
                    .HasColumnType("varchar(255)")
                    .HasComment("是否参与评价")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Sfyx)
                    .HasColumnName("sfyx")
                    .HasColumnType("varchar(255)")
                    .HasComment("是否有效")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ssds)
                    .HasColumnName("ssds")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属地市")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ssjd)
                    .HasColumnName("ssjd")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属街道")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ssqx)
                    .HasColumnName("ssqx")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属区县")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Sssf)
                    .HasColumnName("sssf")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属省份")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间");

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("varchar(255)")
                    .HasComment("纬度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Zdbh)
                    .HasColumnName("zdbh")
                    .HasColumnType("varchar(255)")
                    .HasComment("站点编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Zdjc)
                    .HasColumnName("zdjc")
                    .HasColumnType("varchar(255)")
                    .HasComment("站点简称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Zdwz)
                    .HasColumnName("zdwz")
                    .HasColumnType("varchar(255)")
                    .HasComment("站点位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<Biz263010CgdbsDataCg>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_cgdbs_data_cg");

                entity.HasComment("常规地表水的监测数据信息");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增）");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间");

                entity.Property(e => e.Vc1)
                    .HasColumnName("vc_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("高锰酸盐指数");

                entity.Property(e => e.Vc10)
                    .HasColumnName("vc_10")
                    .HasColumnType("double(8,0)")
                    .HasComment("锌");

                entity.Property(e => e.Vc11)
                    .HasColumnName("vc_11")
                    .HasColumnType("double(8,0)")
                    .HasComment("氟化物");

                entity.Property(e => e.Vc12)
                    .HasColumnName("vc_12")
                    .HasColumnType("double(8,0)")
                    .HasComment("硒");

                entity.Property(e => e.Vc13)
                    .HasColumnName("vc_13")
                    .HasColumnType("double(8,0)")
                    .HasComment("砷");

                entity.Property(e => e.Vc14)
                    .HasColumnName("vc_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("汞");

                entity.Property(e => e.Vc15)
                    .HasColumnName("vc_15")
                    .HasColumnType("double(8,0)")
                    .HasComment("镉");

                entity.Property(e => e.Vc16)
                    .HasColumnName("vc_16")
                    .HasColumnType("double(8,0)")
                    .HasComment("铬（六价）");

                entity.Property(e => e.Vc17)
                    .HasColumnName("vc_17")
                    .HasColumnType("double(8,0)")
                    .HasComment("铅");

                entity.Property(e => e.Vc18)
                    .HasColumnName("vc_18")
                    .HasColumnType("double(8,0)")
                    .HasComment("氰化物");

                entity.Property(e => e.Vc19)
                    .HasColumnName("vc_19")
                    .HasColumnType("double(8,0)")
                    .HasComment("挥发酚");

                entity.Property(e => e.Vc2)
                    .HasColumnName("vc_2")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Vc20)
                    .HasColumnName("vc_20")
                    .HasColumnType("double(8,0)")
                    .HasComment("石油类");

                entity.Property(e => e.Vc21)
                    .HasColumnName("vc_21")
                    .HasColumnType("double(8,0)")
                    .HasComment("阴离子表面活性剂");

                entity.Property(e => e.Vc22)
                    .HasColumnName("vc_22")
                    .HasColumnType("double(8,0)")
                    .HasComment("硫化物");

                entity.Property(e => e.Vc23)
                    .HasColumnName("vc_23")
                    .HasColumnType("double(8,0)")
                    .HasComment("粪大肠菌群");

                entity.Property(e => e.Vc24)
                    .HasColumnName("vc_24")
                    .HasColumnType("double(8,0)")
                    .HasComment("叶绿素a");

                entity.Property(e => e.Vc3)
                    .HasColumnName("vc_3")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Vc4)
                    .HasColumnName("vc_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Vc5)
                    .HasColumnName("vc_5")
                    .HasColumnType("double(8,0)")
                    .HasComment("化学需氧量");

                entity.Property(e => e.Vc6)
                    .HasColumnName("vc_6")
                    .HasColumnType("double(8,0)")
                    .HasComment("五日生化需氧量（BOD5）");

                entity.Property(e => e.Vc7)
                    .HasColumnName("vc_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.Vc8)
                    .HasColumnName("vc_8")
                    .HasColumnType("double(8,0)")
                    .HasComment("总氮");

                entity.Property(e => e.Vc9)
                    .HasColumnName("vc_9")
                    .HasColumnType("double(8,0)")
                    .HasComment("铜");
            });

            modelBuilder.Entity<Biz263010CgdbsDataYy>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_cgdbs_data_yy");

                entity.HasComment("饮用水源地的监测数据信息");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("数据表主键id自增）");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间,YYYY-MM-DD HH:MM:SS");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除,1代表正常，0代表删除");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和对象信息表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）");

                entity.Property(e => e.Vc1)
                    .HasColumnName("vc_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("高锰酸盐指数");

                entity.Property(e => e.Vc10)
                    .HasColumnName("vc_10")
                    .HasColumnType("double(8,0)")
                    .HasComment("锌");

                entity.Property(e => e.Vc11)
                    .HasColumnName("vc_11")
                    .HasColumnType("double(8,0)")
                    .HasComment("氟化物");

                entity.Property(e => e.Vc12)
                    .HasColumnName("vc_12")
                    .HasColumnType("double(8,0)")
                    .HasComment("硒");

                entity.Property(e => e.Vc13)
                    .HasColumnName("vc_13")
                    .HasColumnType("double(8,0)")
                    .HasComment("砷");

                entity.Property(e => e.Vc14)
                    .HasColumnName("vc_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("汞");

                entity.Property(e => e.Vc15)
                    .HasColumnName("vc_15")
                    .HasColumnType("double(8,0)")
                    .HasComment("镉");

                entity.Property(e => e.Vc16)
                    .HasColumnName("vc_16")
                    .HasColumnType("double(8,0)")
                    .HasComment("铬（六价）");

                entity.Property(e => e.Vc17)
                    .HasColumnName("vc_17")
                    .HasColumnType("double(8,0)")
                    .HasComment("铅");

                entity.Property(e => e.Vc18)
                    .HasColumnName("vc_18")
                    .HasColumnType("double(8,0)")
                    .HasComment("氰化物");

                entity.Property(e => e.Vc19)
                    .HasColumnName("vc_19")
                    .HasColumnType("double(8,0)")
                    .HasComment("挥发酚");

                entity.Property(e => e.Vc2)
                    .HasColumnName("vc_2")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Vc20)
                    .HasColumnName("vc_20")
                    .HasColumnType("double(8,0)")
                    .HasComment("石油类");

                entity.Property(e => e.Vc21)
                    .HasColumnName("vc_21")
                    .HasColumnType("double(8,0)")
                    .HasComment("阴离子表面活性剂");

                entity.Property(e => e.Vc22)
                    .HasColumnName("vc_22")
                    .HasColumnType("double(8,0)")
                    .HasComment("硫化物");

                entity.Property(e => e.Vc23)
                    .HasColumnName("vc_23")
                    .HasColumnType("double(8,0)")
                    .HasComment("粪大肠菌群");

                entity.Property(e => e.Vc24)
                    .HasColumnName("vc_24")
                    .HasColumnType("double(8,0)")
                    .HasComment("叶绿素a");

                entity.Property(e => e.Vc3)
                    .HasColumnName("vc_3")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Vc4)
                    .HasColumnName("vc_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Vc5)
                    .HasColumnName("vc_5")
                    .HasColumnType("double(8,0)")
                    .HasComment("化学需氧量");

                entity.Property(e => e.Vc6)
                    .HasColumnName("vc_6")
                    .HasColumnType("double(8,0)")
                    .HasComment("五日生化需氧量（BOD5）");

                entity.Property(e => e.Vc7)
                    .HasColumnName("vc_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.Vc8)
                    .HasColumnName("vc_8")
                    .HasColumnType("double(8,0)")
                    .HasComment("总氮");

                entity.Property(e => e.Vc9)
                    .HasColumnName("vc_9")
                    .HasColumnType("double(8,0)")
                    .HasComment("铜");
            });

            modelBuilder.Entity<Biz263010CgdbsObjInfo>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_cgdbs_obj_info");

                entity.HasComment("常规地表水/饮用水源地的对象的对象信息");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)")
                    .HasComment("主键id,对象信息表的主键id（自增）");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Bysz)
                    .HasColumnName("bysz")
                    .HasColumnType("varchar(255)")
                    .HasComment("本月水质")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Hzxm)
                    .HasColumnName("hzxm")
                    .HasColumnType("varchar(255)")
                    .HasComment("河长姓名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除,1代表正常，0代表删除");

                entity.Property(e => e.Kzjb)
                    .HasColumnName("kzjb")
                    .HasColumnType("varchar(255)")
                    .HasComment("控制级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Lxfs)
                    .HasColumnName("lxfs")
                    .HasColumnType("varchar(255)")
                    .HasComment("联系方式")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Mbsz)
                    .HasColumnName("mbsz")
                    .HasColumnType("varchar(255)")
                    .HasComment("目标水质")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和具体数据表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("监测点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Objtypename)
                    .HasColumnName("objtypename")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象类型名称,当前对象所属的类型")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Sshd)
                    .HasColumnName("sshd")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属河道")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ssxzjd)
                    .HasColumnName("ssxzjd")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属乡镇街道")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）");
            });

            modelBuilder.Entity<Biz263010HddbsDataHd>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_hddbs_data_hd");

                entity.HasComment("河道地表水的监测数据信息");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("数据表主键id（自增）");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间,YYYY-MM-DD HH:MM:SS");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除,1代表正常，0代表删除");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和对象信息表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）");

                entity.Property(e => e.Vc1)
                    .HasColumnName("vc_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("高锰酸盐指数");

                entity.Property(e => e.Vc10)
                    .HasColumnName("vc_10")
                    .HasColumnType("double(8,0)")
                    .HasComment("锌");

                entity.Property(e => e.Vc11)
                    .HasColumnName("vc_11")
                    .HasColumnType("double(8,0)")
                    .HasComment("氟化物");

                entity.Property(e => e.Vc12)
                    .HasColumnName("vc_12")
                    .HasColumnType("double(8,0)")
                    .HasComment("硒");

                entity.Property(e => e.Vc13)
                    .HasColumnName("vc_13")
                    .HasColumnType("double(8,0)")
                    .HasComment("砷");

                entity.Property(e => e.Vc14)
                    .HasColumnName("vc_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("汞");

                entity.Property(e => e.Vc15)
                    .HasColumnName("vc_15")
                    .HasColumnType("double(8,0)")
                    .HasComment("镉");

                entity.Property(e => e.Vc16)
                    .HasColumnName("vc_16")
                    .HasColumnType("double(8,0)")
                    .HasComment("铬（六价）");

                entity.Property(e => e.Vc17)
                    .HasColumnName("vc_17")
                    .HasColumnType("double(8,0)")
                    .HasComment("铅");

                entity.Property(e => e.Vc18)
                    .HasColumnName("vc_18")
                    .HasColumnType("double(8,0)")
                    .HasComment("氰化物");

                entity.Property(e => e.Vc19)
                    .HasColumnName("vc_19")
                    .HasColumnType("double(8,0)")
                    .HasComment("挥发酚");

                entity.Property(e => e.Vc2)
                    .HasColumnName("vc_2")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Vc20)
                    .HasColumnName("vc_20")
                    .HasColumnType("double(8,0)")
                    .HasComment("石油类");

                entity.Property(e => e.Vc21)
                    .HasColumnName("vc_21")
                    .HasColumnType("double(8,0)")
                    .HasComment("阴离子表面活性剂");

                entity.Property(e => e.Vc22)
                    .HasColumnName("vc_22")
                    .HasColumnType("double(8,0)")
                    .HasComment("硫化物");

                entity.Property(e => e.Vc23)
                    .HasColumnName("vc_23")
                    .HasColumnType("double(8,0)")
                    .HasComment("粪大肠菌群");

                entity.Property(e => e.Vc24)
                    .HasColumnName("vc_24")
                    .HasColumnType("double(8,0)")
                    .HasComment("叶绿素a");

                entity.Property(e => e.Vc3)
                    .HasColumnName("vc_3")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Vc4)
                    .HasColumnName("vc_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Vc5)
                    .HasColumnName("vc_5")
                    .HasColumnType("double(8,0)")
                    .HasComment("化学需氧量");

                entity.Property(e => e.Vc6)
                    .HasColumnName("vc_6")
                    .HasColumnType("double(8,0)")
                    .HasComment("五日生化需氧量（BOD5）");

                entity.Property(e => e.Vc7)
                    .HasColumnName("vc_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.Vc8)
                    .HasColumnName("vc_8")
                    .HasColumnType("double(8,0)")
                    .HasComment("总氮");

                entity.Property(e => e.Vc9)
                    .HasColumnName("vc_9")
                    .HasColumnType("double(8,0)")
                    .HasComment("铜");
            });

            modelBuilder.Entity<Biz263010HddbsObjInfo>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_hddbs_obj_info");

                entity.HasComment("河道地表水的对象信息");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)")
                    .HasComment("主键id,对象信息表的主键id（自增）");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Duty)
                    .HasColumnName("duty")
                    .HasColumnType("varchar(255)")
                    .HasComment("职位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Gl)
                    .HasColumnName("gl")
                    .HasColumnType("varchar(255)")
                    .HasComment("干流")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Hzxm)
                    .HasColumnName("hzxm")
                    .HasColumnType("varchar(255)")
                    .HasComment("河长姓名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除,1代表正常，0代表删除");

                entity.Property(e => e.Kzjb)
                    .HasColumnName("kzjb")
                    .HasColumnType("varchar(255)")
                    .HasComment("控制级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Lxfs)
                    .HasColumnName("lxfs")
                    .HasColumnType("varchar(255)")
                    .HasComment("联系方式")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Mbsz)
                    .HasColumnName("mbsz")
                    .HasColumnType("varchar(255)")
                    .HasComment("目标水质")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和具体数据表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("监测点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Objtypename)
                    .HasColumnName("objtypename")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象类型名称,当前对象所属的类型")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Skh)
                    .HasColumnName("skh")
                    .HasColumnType("varchar(255)")
                    .HasComment("市考核")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Sshd)
                    .HasColumnName("sshd")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属河道")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ssxzjd)
                    .HasColumnName("ssxzjd")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属乡镇街道")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）");

                entity.Property(e => e.Xzkh)
                    .HasColumnName("xzkh")
                    .HasColumnType("varchar(255)")
                    .HasComment("乡镇考核")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ypbh)
                    .HasColumnName("ypbh")
                    .HasColumnType("varchar(255)")
                    .HasComment("样品编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<Biz263010JhpjwgzdDataDayR>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_jhpjwgzd_data_day_r");

                entity.HasComment("网格站点数据信息（人工日数据）");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增),数据表主键id");

                entity.Property(e => e.Aqi)
                    .HasColumnName("aqi")
                    .HasColumnType("double(8,0)")
                    .HasComment("AQI指数");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Co)
                    .HasColumnName("co")
                    .HasColumnType("double(8,0)")
                    .HasComment("一氧化碳");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间,YYYY-MM-DD HH:MM:SS");

                entity.Property(e => e.Dqyl)
                    .HasColumnName("dqyl")
                    .HasColumnType("varchar(255)")
                    .HasComment("大气压力")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Fs)
                    .HasColumnName("fs")
                    .HasColumnType("varchar(255)")
                    .HasComment("风速,1代表正常，0代表删除")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Fx)
                    .HasColumnName("fx")
                    .HasColumnType("double(8,0)")
                    .HasComment("风向");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.No2)
                    .HasColumnName("no2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化氮");

                entity.Property(e => e.O3)
                    .HasColumnName("o3")
                    .HasColumnType("double(8,0)")
                    .HasComment("氧3");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和对象信息表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm10");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm2.5");

                entity.Property(e => e.So2)
                    .HasColumnName("so2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化硫");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）");

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("double(8,0)")
                    .HasComment("温度");

                entity.Property(e => e.Xdsd)
                    .HasColumnName("xdsd")
                    .HasColumnType("double(8,0)")
                    .HasComment("相对湿度");
            });

            modelBuilder.Entity<Biz263010JhpjwgzdDataHourR>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_jhpjwgzd_data_hour_r");

                entity.HasComment("网格站点数据信息（人工审核小时数据）");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增),数据表主键id");

                entity.Property(e => e.Aqi)
                    .HasColumnName("aqi")
                    .HasColumnType("double(8,0)")
                    .HasComment("AQI指数");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Co)
                    .HasColumnName("co")
                    .HasColumnType("double(8,0)")
                    .HasComment("一氧化碳");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间,YYYY-MM-DD HH:MM:SS");

                entity.Property(e => e.Dqyl)
                    .HasColumnName("dqyl")
                    .HasColumnType("varchar(255)")
                    .HasComment("大气压力")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Fs)
                    .HasColumnName("fs")
                    .HasColumnType("varchar(255)")
                    .HasComment("风速,当前时间没有污染时为空")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Fx)
                    .HasColumnName("fx")
                    .HasColumnType("double(8,0)")
                    .HasComment("风向");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除,1代表正常，0代表删除");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.No2)
                    .HasColumnName("no2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化氮");

                entity.Property(e => e.O3)
                    .HasColumnName("o3")
                    .HasColumnType("double(8,0)")
                    .HasComment("氧3");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和对象信息表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm10");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm2.5");

                entity.Property(e => e.So2)
                    .HasColumnName("so2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化硫");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）");

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("double(8,0)")
                    .HasComment("温度");

                entity.Property(e => e.Xdsd)
                    .HasColumnName("xdsd")
                    .HasColumnType("double(8,0)")
                    .HasComment("相对湿度");
            });

            modelBuilder.Entity<Biz263010JhpjwgzdDataHourZ>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_jhpjwgzd_data_hour_z");

                entity.HasComment("网格站点数据信息（人工审核小时数据）");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增),数据表主键id");

                entity.Property(e => e.Aqi)
                    .HasColumnName("aqi")
                    .HasColumnType("double(8,0)")
                    .HasComment("AQI指数");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Co)
                    .HasColumnName("co")
                    .HasColumnType("double(8,0)")
                    .HasComment("一氧化碳");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间,YYYY-MM-DD HH:MM:SS");

                entity.Property(e => e.Dqyl)
                    .HasColumnName("dqyl")
                    .HasColumnType("varchar(255)")
                    .HasComment("大气压力")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Fs)
                    .HasColumnName("fs")
                    .HasColumnType("varchar(255)")
                    .HasComment("风速,当前时间没有污染时为空")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Fx)
                    .HasColumnName("fx")
                    .HasColumnType("double(8,0)")
                    .HasComment("风向");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除,1代表正常，0代表删除");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.No2)
                    .HasColumnName("no2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化氮");

                entity.Property(e => e.O3)
                    .HasColumnName("o3")
                    .HasColumnType("double(8,0)")
                    .HasComment("氧3");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和对象信息表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm10");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm2.5");

                entity.Property(e => e.So2)
                    .HasColumnName("so2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化硫");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）");

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("double(8,0)")
                    .HasComment("温度");

                entity.Property(e => e.Xdsd)
                    .HasColumnName("xdsd")
                    .HasColumnType("double(8,0)")
                    .HasComment("相对湿度");
            });

            modelBuilder.Entity<Biz263010SzzdjcjcdDataDay>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_szzdjcjcd_data_day");

                entity.HasComment("水质自动监测点数据信息（自动日数据）");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增）");

                entity.Property(e => e.Bh1)
                    .HasColumnName("bh_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Bh14)
                    .HasColumnName("bh_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Bh16)
                    .HasColumnName("bh_16")
                    .HasColumnType("double(8,0)")
                    .HasComment("高锰酸盐指数");

                entity.Property(e => e.Bh4)
                    .HasColumnName("bh_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Bh7)
                    .HasColumnName("bh_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间");
            });

            modelBuilder.Entity<Biz263010SzzdjcjcdDataHour>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_szzdjcjcd_data_hour");

                entity.HasComment("水质自动监测点数据信息（自动小时数据）");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增）");

                entity.Property(e => e.Bh1)
                    .HasColumnName("bh_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Bh10)
                    .HasColumnName("bh_10")
                    .HasColumnType("double(8,0)")
                    .HasComment("隐藻");

                entity.Property(e => e.Bh11)
                    .HasColumnName("bh_11")
                    .HasColumnType("double(8,0)")
                    .HasComment("蓝藻");

                entity.Property(e => e.Bh12)
                    .HasColumnName("bh_12")
                    .HasColumnType("double(8,0)")
                    .HasComment("总叶绿素");

                entity.Property(e => e.Bh14)
                    .HasColumnName("bh_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Bh16)
                    .HasColumnName("bh_16")
                    .HasColumnType("double(8,0)")
                    .HasComment("高锰酸盐指数");

                entity.Property(e => e.Bh2)
                    .HasColumnName("bh_2")
                    .HasColumnType("double(8,0)")
                    .HasComment("总氮");

                entity.Property(e => e.Bh3)
                    .HasColumnName("bh_3")
                    .HasColumnType("double(8,0)")
                    .HasComment("水温");

                entity.Property(e => e.Bh4)
                    .HasColumnName("bh_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Bh5)
                    .HasColumnName("bh_5")
                    .HasColumnType("double(8,0)")
                    .HasComment("电导率");

                entity.Property(e => e.Bh6)
                    .HasColumnName("bh_6")
                    .HasColumnType("double(8,0)")
                    .HasComment("浊度");

                entity.Property(e => e.Bh7)
                    .HasColumnName("bh_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.Bh8)
                    .HasColumnName("bh_8")
                    .HasColumnType("double(8,0)")
                    .HasComment("绿藻");

                entity.Property(e => e.Bh9)
                    .HasColumnName("bh_9")
                    .HasColumnType("double(8,0)")
                    .HasComment("硅甲藻");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间");
            });

            modelBuilder.Entity<Biz263010SzzdjcjcdDataMonth>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_szzdjcjcd_data_month");

                entity.HasComment("水质自动监测点数据信息（自动月数据）");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增）");

                entity.Property(e => e.Bh1)
                    .HasColumnName("bh_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Bh14)
                    .HasColumnName("bh_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Bh16)
                    .HasColumnName("bh_16")
                    .HasColumnType("double(8,0)")
                    .HasComment("高锰酸盐指数");

                entity.Property(e => e.Bh4)
                    .HasColumnName("bh_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Bh7)
                    .HasColumnName("bh_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间");
            });

            modelBuilder.Entity<Biz263010SzzdjcjcdObjInfo>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_szzdjcjcd_obj_info");

                entity.HasComment("水质自动监测点的对象信息");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)")
                    .HasComment("主键id");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Cdbh)
                    .HasColumnName("cdbh")
                    .HasColumnType("varchar(255)")
                    .HasComment("站点编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Dmsx)
                    .HasColumnName("dmsx")
                    .HasColumnType("varchar(255)")
                    .HasComment("断面属性")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除");

                entity.Property(e => e.Jd)
                    .HasColumnName("jd")
                    .HasColumnType("varchar(255)")
                    .HasComment("经度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Jgjb)
                    .HasColumnName("jgjb")
                    .HasColumnType("varchar(255)")
                    .HasComment("监管级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Objtypename)
                    .HasColumnName("objtypename")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象类型名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Qy)
                    .HasColumnName("qy")
                    .HasColumnType("varchar(255)")
                    .HasComment("区域")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ssds)
                    .HasColumnName("ssds")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属地市")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ssjd)
                    .HasColumnName("ssjd")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属街道")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ssly)
                    .HasColumnName("ssly")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属流域")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ssqx)
                    .HasColumnName("ssqx")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属区县")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Sssf)
                    .HasColumnName("sssf")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属省份")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Sssx)
                    .HasColumnName("sssx")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属水系")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Szlb)
                    .HasColumnName("szlb")
                    .HasColumnType("varchar(255)")
                    .HasComment("水质类别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间");

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("varchar(255)")
                    .HasComment("纬度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Xzqhdm)
                    .HasColumnName("xzqhdm")
                    .HasColumnType("varchar(255)")
                    .HasComment("行政区划代码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Zxbzmc)
                    .HasColumnName("zxbzmc")
                    .HasColumnType("varchar(255)")
                    .HasComment("执行标准名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<Biz263010YcjcdDataDay>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_ycjcd_data_day");

                entity.HasComment("扬尘监测点的数据表（日数据）：存放下属站点的日数据");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键ID");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据监测时间");

                entity.Property(e => e.Fpm10)
                    .HasColumnName("fpm10")
                    .HasColumnType("varchar(255)")
                    .HasComment("PM10阀值")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Fpm25)
                    .HasColumnName("fpm25")
                    .HasColumnType("varchar(255)")
                    .HasComment("PM2.5阀值")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("PM10");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("PM2.5");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(255)")
                    .HasComment("扬尘数据状态")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间");
            });

            modelBuilder.Entity<Biz263010YcjcdDataHour>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_ycjcd_data_hour");

                entity.HasComment("扬尘监测点的数据表（小时数据）：存放下属站点的小时数据");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键ID");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据监测时间");

                entity.Property(e => e.Fpm10)
                    .HasColumnName("fpm10")
                    .HasColumnType("varchar(255)")
                    .HasComment("PM10阀值")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Fpm25)
                    .HasColumnName("fpm25")
                    .HasColumnType("varchar(255)")
                    .HasComment("PM2.5阀值")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("PM10");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("PM2.5");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(255)")
                    .HasComment("扬尘数据状态")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间");
            });

            modelBuilder.Entity<Biz263010YcjcdObjInfo>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_ycjcd_obj_info");

                entity.HasComment("扬尘监测点的对象信息表：存放扬尘监测点下属站点的基本信息");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)")
                    .HasComment("主键ID");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("varchar(255)")
                    .HasComment("设备编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除");

                entity.Property(e => e.Jd)
                    .HasColumnName("jd")
                    .HasColumnType("varchar(255)")
                    .HasComment("经度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Objtypename)
                    .HasColumnName("objtypename")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象类型名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(255)")
                    .HasComment("监测区域")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(255)")
                    .HasComment("设备状态")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间");

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("varchar(255)")
                    .HasComment("纬度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<Biz263010YyszdjcdDataHour>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Dataid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_yyszdjcd_data_hour");

                entity.HasComment("饮用水自动监测点数据信息（自动小时数据）");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增）");

                entity.Property(e => e.Bh1)
                    .HasColumnName("bh_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Bh10)
                    .HasColumnName("bh_10")
                    .HasColumnType("double(8,0)")
                    .HasComment("隐藻");

                entity.Property(e => e.Bh11)
                    .HasColumnName("bh_11")
                    .HasColumnType("double(8,0)")
                    .HasComment("蓝藻");

                entity.Property(e => e.Bh12)
                    .HasColumnName("bh_12")
                    .HasColumnType("double(8,0)")
                    .HasComment("总叶绿素");

                entity.Property(e => e.Bh13)
                    .HasColumnName("bh_13")
                    .HasColumnType("double(8,0)")
                    .HasComment("CODmn");

                entity.Property(e => e.Bh14)
                    .HasColumnName("bh_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Bh15)
                    .HasColumnName("bh_15")
                    .HasColumnType("double(8,0)")
                    .HasComment("生物毒性（发光菌）");

                entity.Property(e => e.Bh2)
                    .HasColumnName("bh_2")
                    .HasColumnType("double(8,0)")
                    .HasComment("总氮");

                entity.Property(e => e.Bh3)
                    .HasColumnName("bh_3")
                    .HasColumnType("double(8,0)")
                    .HasComment("水温");

                entity.Property(e => e.Bh4)
                    .HasColumnName("bh_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Bh5)
                    .HasColumnName("bh_5")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Bh6)
                    .HasColumnName("bh_6")
                    .HasColumnType("double(8,0)")
                    .HasComment("浊度");

                entity.Property(e => e.Bh7)
                    .HasColumnName("bh_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.Bh8)
                    .HasColumnName("bh_8")
                    .HasColumnType("double(8,0)")
                    .HasComment("绿藻");

                entity.Property(e => e.Bh9)
                    .HasColumnName("bh_9")
                    .HasColumnType("double(8,0)")
                    .HasComment("硅甲藻");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间");
            });

            modelBuilder.Entity<Biz263010YyszdjcdObjInfo>(entity =>
            {
                entity.HasKey(e => new { e.Estarid, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("biz_263010_yyszdjcd_obj_info");

                entity.HasComment("饮用水自动监测点的对象信息");

                entity.Property(e => e.Estarid)
                    .HasColumnName("estarid")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)")
                    .HasComment("主键id");

                entity.Property(e => e.BizTime)
                    .HasColumnName("biz_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Cdbh)
                    .HasColumnName("cdbh")
                    .HasColumnType("varchar(255)")
                    .HasComment("站点编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除");

                entity.Property(e => e.Jd)
                    .HasColumnName("jd")
                    .HasColumnType("varchar(255)")
                    .HasComment("经度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.LoadTime)
                    .HasColumnName("load_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("监测点名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Objtypename)
                    .HasColumnName("objtypename")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象类型名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ssds)
                    .HasColumnName("ssds")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属地市")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ssqx)
                    .HasColumnName("ssqx")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属区县")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Sssf)
                    .HasColumnName("sssf")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属省份")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasComment("数据更新时间");

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("varchar(255)")
                    .HasComment("纬度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<TbAtmosphereDataDay>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_atmosphere_data_day");

                entity.HasComment("大气的对象数据信息（日数据）");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id,数据表主键id（自增）");

                entity.Property(e => e.Aqi)
                    .HasColumnName("aqi")
                    .HasColumnType("double(8,0)")
                    .HasComment("AQI指数");

                entity.Property(e => e.Co)
                    .HasColumnName("co")
                    .HasColumnType("double(8,0)")
                    .HasComment("一氧化碳");

                entity.Property(e => e.Cofzs)
                    .HasColumnName("cofzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("一氧化碳分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除,1代表正常,0代表删除");

                entity.Property(e => e.Kqzllb)
                    .HasColumnName("kqzllb")
                    .HasColumnType("varchar(255)")
                    .HasComment("空气质量类别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Kqzlys)
                    .HasColumnName("kqzlys")
                    .HasColumnType("varchar(255)")
                    .HasComment("空气质量颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Kqzlzsjb)
                    .HasColumnName("kqzlzsjb")
                    .HasColumnType("varchar(255)")
                    .HasComment("空气质量指数级别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.No2)
                    .HasColumnName("no2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化氮");

                entity.Property(e => e.No2fzs)
                    .HasColumnName("no2fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("二氧化氮分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.O3)
                    .HasColumnName("o3")
                    .HasColumnType("double(8,0)")
                    .HasComment("氧3");

                entity.Property(e => e.O38)
                    .HasColumnName("o38")
                    .HasColumnType("double(8,0)")
                    .HasComment("O3最大8小时滑动平均浓度");

                entity.Property(e => e.O3fzs)
                    .HasColumnName("o3fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("氧3分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.O3h1)
                    .HasColumnName("o3h1")
                    .HasColumnType("varchar(255)")
                    .HasComment("O3最大1小时滑动浓度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.O3h1fzs)
                    .HasColumnName("o3h1fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("O3最大1小时滑动分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.O3h8fzs)
                    .HasColumnName("o3h8fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("O3最大8小时滑动平均分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和对象信息表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm10");

                entity.Property(e => e.Pm10fzs)
                    .HasColumnName("pm10fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm10分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm10h24)
                    .HasColumnName("pm10h24")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm10,24小时平均浓度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm10h24fzs)
                    .HasColumnName("pm10h24fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm10,24小时平均分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm2.5");

                entity.Property(e => e.Pm25fzs)
                    .HasColumnName("pm25fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm25分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm25h24)
                    .HasColumnName("pm25h24")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm2.5,24小时平均浓度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm25h24fzs)
                    .HasColumnName("pm25h24fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm2.5,24小时平均分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.So2)
                    .HasColumnName("so2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化硫");

                entity.Property(e => e.So2fzs)
                    .HasColumnName("so2fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("二氧化硫分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sywrw)
                    .HasColumnName("sywrw")
                    .HasColumnType("varchar(255)")
                    .HasComment("首要污染物")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sywrwnd)
                    .HasColumnName("sywrwnd")
                    .HasColumnType("varchar(255)")
                    .HasComment("首要污染物浓度,有污染物时有值")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TbAtmosphereDataHour>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_atmosphere_data_hour");

                entity.HasComment("大气的对象数据信息（小时数据）");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增）");

                entity.Property(e => e.Aqi)
                    .HasColumnName("aqi")
                    .HasColumnType("double(8,0)")
                    .HasComment("AQI指数");

                entity.Property(e => e.Co)
                    .HasColumnName("co")
                    .HasColumnType("double(8,0)")
                    .HasComment("一氧化碳");

                entity.Property(e => e.Cofzs)
                    .HasColumnName("cofzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("一氧化碳分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.Kqzllb)
                    .HasColumnName("kqzllb")
                    .HasColumnType("varchar(255)")
                    .HasComment("空气质量类别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Kqzlys)
                    .HasColumnName("kqzlys")
                    .HasColumnType("varchar(255)")
                    .HasComment("空气质量颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Kqzlzsjb)
                    .HasColumnName("kqzlzsjb")
                    .HasColumnType("varchar(255)")
                    .HasComment("空气质量指数级别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.No2)
                    .HasColumnName("no2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化氮");

                entity.Property(e => e.No2fzs)
                    .HasColumnName("no2fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("二氧化氮分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.O3)
                    .HasColumnName("o3")
                    .HasColumnType("double(8,0)")
                    .HasComment("氧3");

                entity.Property(e => e.O38)
                    .HasColumnName("o38")
                    .HasColumnType("double(8,0)")
                    .HasComment("O3最大8小时滑动平均浓度");

                entity.Property(e => e.O3fzs)
                    .HasColumnName("o3fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("氧3分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.O3h1)
                    .HasColumnName("o3h1")
                    .HasColumnType("varchar(255)")
                    .HasComment("O3最大1小时滑动浓度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.O3h1fzs)
                    .HasColumnName("o3h1fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("O3最大1小时滑动分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.O3h8fzs)
                    .HasColumnName("o3h8fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("O3最大8小时滑动平均分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm10");

                entity.Property(e => e.Pm10fzs)
                    .HasColumnName("pm10fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm10分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm10h24)
                    .HasColumnName("pm10h24")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm10  24小时平均浓度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm10h24fzs)
                    .HasColumnName("pm10h24fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm10  24小时平均分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm2.5");

                entity.Property(e => e.Pm25fzs)
                    .HasColumnName("pm25fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm25分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm25h24)
                    .HasColumnName("pm25h24")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm2.5  24小时平均浓度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm25h24fzs)
                    .HasColumnName("pm25h24fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("pm2.5  24小时平均分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.So2)
                    .HasColumnName("so2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化硫");

                entity.Property(e => e.So2fzs)
                    .HasColumnName("so2fzs")
                    .HasColumnType("varchar(255)")
                    .HasComment("二氧化硫分指数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sywrw)
                    .HasColumnName("sywrw")
                    .HasColumnType("varchar(255)")
                    .HasComment("首要污染物")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sywrwnd)
                    .HasColumnName("sywrwnd")
                    .HasColumnType("varchar(255)")
                    .HasComment("首要污染物浓度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TbAtmosphereObjInfo>(entity =>
            {
                entity.ToTable("tb_atmosphere_obj_info");

                entity.HasComment("大气的对象信息");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)")
                    .HasComment("主键id");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除");

                entity.Property(e => e.Jd)
                    .HasColumnName("jd")
                    .HasColumnType("varchar(255)")
                    .HasComment("经度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objtypename)
                    .IsRequired()
                    .HasColumnName("objtypename")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象类型名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sfcypj)
                    .HasColumnName("sfcypj")
                    .HasColumnType("varchar(255)")
                    .HasComment("是否参与评价")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sfyx)
                    .HasColumnName("sfyx")
                    .HasColumnType("varchar(255)")
                    .HasComment("是否有效")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssds)
                    .HasColumnName("ssds")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属地市")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssjd)
                    .HasColumnName("ssjd")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属街道")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssqx)
                    .HasColumnName("ssqx")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属区县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sssf)
                    .HasColumnName("sssf")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属省份")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("varchar(255)")
                    .HasComment("纬度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zdbh)
                    .HasColumnName("zdbh")
                    .HasColumnType("varchar(255)")
                    .HasComment("站点编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zdjc)
                    .HasColumnName("zdjc")
                    .HasColumnType("varchar(255)")
                    .HasComment("站点简称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zdwz)
                    .HasColumnName("zdwz")
                    .HasColumnType("varchar(255)")
                    .HasComment("站点位置")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TbCgdbsDataCg>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_cgdbs_data_cg");

                entity.HasComment("常规地表水的监测数据信息");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增）");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Vc1)
                    .HasColumnName("vc_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("高锰酸盐指数");

                entity.Property(e => e.Vc10)
                    .HasColumnName("vc_10")
                    .HasColumnType("double(8,0)")
                    .HasComment("锌");

                entity.Property(e => e.Vc11)
                    .HasColumnName("vc_11")
                    .HasColumnType("double(8,0)")
                    .HasComment("氟化物");

                entity.Property(e => e.Vc12)
                    .HasColumnName("vc_12")
                    .HasColumnType("double(8,0)")
                    .HasComment("硒");

                entity.Property(e => e.Vc13)
                    .HasColumnName("vc_13")
                    .HasColumnType("double(8,0)")
                    .HasComment("砷");

                entity.Property(e => e.Vc14)
                    .HasColumnName("vc_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("汞");

                entity.Property(e => e.Vc15)
                    .HasColumnName("vc_15")
                    .HasColumnType("double(8,0)")
                    .HasComment("镉");

                entity.Property(e => e.Vc16)
                    .HasColumnName("vc_16")
                    .HasColumnType("double(8,0)")
                    .HasComment("铬（六价）");

                entity.Property(e => e.Vc17)
                    .HasColumnName("vc_17")
                    .HasColumnType("double(8,0)")
                    .HasComment("铅");

                entity.Property(e => e.Vc18)
                    .HasColumnName("vc_18")
                    .HasColumnType("double(8,0)")
                    .HasComment("氰化物");

                entity.Property(e => e.Vc19)
                    .HasColumnName("vc_19")
                    .HasColumnType("double(8,0)")
                    .HasComment("挥发酚");

                entity.Property(e => e.Vc2)
                    .HasColumnName("vc_2")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Vc20)
                    .HasColumnName("vc_20")
                    .HasColumnType("double(8,0)")
                    .HasComment("石油类");

                entity.Property(e => e.Vc21)
                    .HasColumnName("vc_21")
                    .HasColumnType("double(8,0)")
                    .HasComment("阴离子表面活性剂");

                entity.Property(e => e.Vc22)
                    .HasColumnName("vc_22")
                    .HasColumnType("double(8,0)")
                    .HasComment("硫化物");

                entity.Property(e => e.Vc23)
                    .HasColumnName("vc_23")
                    .HasColumnType("double(8,0)")
                    .HasComment("粪大肠菌群");

                entity.Property(e => e.Vc24)
                    .HasColumnName("vc_24")
                    .HasColumnType("double(8,0)")
                    .HasComment("叶绿素a");

                entity.Property(e => e.Vc3)
                    .HasColumnName("vc_3")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Vc4)
                    .HasColumnName("vc_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Vc5)
                    .HasColumnName("vc_5")
                    .HasColumnType("double(8,0)")
                    .HasComment("化学需氧量");

                entity.Property(e => e.Vc6)
                    .HasColumnName("vc_6")
                    .HasColumnType("double(8,0)")
                    .HasComment("五日生化需氧量（BOD5）");

                entity.Property(e => e.Vc7)
                    .HasColumnName("vc_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.Vc8)
                    .HasColumnName("vc_8")
                    .HasColumnType("double(8,0)")
                    .HasComment("总氮");

                entity.Property(e => e.Vc9)
                    .HasColumnName("vc_9")
                    .HasColumnType("double(8,0)")
                    .HasComment("铜");
            });

            modelBuilder.Entity<TbCgdbsDataYy>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_cgdbs_data_yy");

                entity.HasComment("饮用水源地的监测数据信息");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("数据表主键id自增）");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间,YYYY-MM-DD HH:MM:SS");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除,1代表正常，0代表删除");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和对象信息表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Vc1)
                    .HasColumnName("vc_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("高锰酸盐指数");

                entity.Property(e => e.Vc10)
                    .HasColumnName("vc_10")
                    .HasColumnType("double(8,0)")
                    .HasComment("锌");

                entity.Property(e => e.Vc11)
                    .HasColumnName("vc_11")
                    .HasColumnType("double(8,0)")
                    .HasComment("氟化物");

                entity.Property(e => e.Vc12)
                    .HasColumnName("vc_12")
                    .HasColumnType("double(8,0)")
                    .HasComment("硒");

                entity.Property(e => e.Vc13)
                    .HasColumnName("vc_13")
                    .HasColumnType("double(8,0)")
                    .HasComment("砷");

                entity.Property(e => e.Vc14)
                    .HasColumnName("vc_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("汞");

                entity.Property(e => e.Vc15)
                    .HasColumnName("vc_15")
                    .HasColumnType("double(8,0)")
                    .HasComment("镉");

                entity.Property(e => e.Vc16)
                    .HasColumnName("vc_16")
                    .HasColumnType("double(8,0)")
                    .HasComment("铬（六价）");

                entity.Property(e => e.Vc17)
                    .HasColumnName("vc_17")
                    .HasColumnType("double(8,0)")
                    .HasComment("铅");

                entity.Property(e => e.Vc18)
                    .HasColumnName("vc_18")
                    .HasColumnType("double(8,0)")
                    .HasComment("氰化物");

                entity.Property(e => e.Vc19)
                    .HasColumnName("vc_19")
                    .HasColumnType("double(8,0)")
                    .HasComment("挥发酚");

                entity.Property(e => e.Vc2)
                    .HasColumnName("vc_2")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Vc20)
                    .HasColumnName("vc_20")
                    .HasColumnType("double(8,0)")
                    .HasComment("石油类");

                entity.Property(e => e.Vc21)
                    .HasColumnName("vc_21")
                    .HasColumnType("double(8,0)")
                    .HasComment("阴离子表面活性剂");

                entity.Property(e => e.Vc22)
                    .HasColumnName("vc_22")
                    .HasColumnType("double(8,0)")
                    .HasComment("硫化物");

                entity.Property(e => e.Vc23)
                    .HasColumnName("vc_23")
                    .HasColumnType("double(8,0)")
                    .HasComment("粪大肠菌群");

                entity.Property(e => e.Vc24)
                    .HasColumnName("vc_24")
                    .HasColumnType("double(8,0)")
                    .HasComment("叶绿素a");

                entity.Property(e => e.Vc3)
                    .HasColumnName("vc_3")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Vc4)
                    .HasColumnName("vc_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Vc5)
                    .HasColumnName("vc_5")
                    .HasColumnType("double(8,0)")
                    .HasComment("化学需氧量");

                entity.Property(e => e.Vc6)
                    .HasColumnName("vc_6")
                    .HasColumnType("double(8,0)")
                    .HasComment("五日生化需氧量（BOD5）");

                entity.Property(e => e.Vc7)
                    .HasColumnName("vc_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.Vc8)
                    .HasColumnName("vc_8")
                    .HasColumnType("double(8,0)")
                    .HasComment("总氮");

                entity.Property(e => e.Vc9)
                    .HasColumnName("vc_9")
                    .HasColumnType("double(8,0)")
                    .HasComment("铜");
            });

            modelBuilder.Entity<TbCgdbsObjInfo>(entity =>
            {
                entity.ToTable("tb_cgdbs_obj_info");

                entity.HasComment("常规地表水/饮用水源地的对象的对象信息");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)")
                    .HasComment("主键id,对象信息表的主键id（自增）");

                entity.Property(e => e.Bysz)
                    .HasColumnName("bysz")
                    .HasColumnType("varchar(255)")
                    .HasComment("本月水质")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hzxm)
                    .HasColumnName("hzxm")
                    .HasColumnType("varchar(255)")
                    .HasComment("河长姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除,1代表正常，0代表删除");

                entity.Property(e => e.Kzjb)
                    .HasColumnName("kzjb")
                    .HasColumnType("varchar(255)")
                    .HasComment("控制级别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lxfs)
                    .HasColumnName("lxfs")
                    .HasColumnType("varchar(255)")
                    .HasComment("联系方式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mbsz)
                    .HasColumnName("mbsz")
                    .HasColumnType("varchar(255)")
                    .HasComment("目标水质")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和具体数据表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("监测点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objtypename)
                    .HasColumnName("objtypename")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象类型名称,当前对象所属的类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sshd)
                    .HasColumnName("sshd")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属河道")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssxzjd)
                    .HasColumnName("ssxzjd")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属乡镇街道")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TbHddbsDataHd>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_hddbs_data_hd");

                entity.HasComment("河道地表水的监测数据信息");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("数据表主键id（自增）");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间,YYYY-MM-DD HH:MM:SS");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除,1代表正常，0代表删除");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和对象信息表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Vc1)
                    .HasColumnName("vc_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("高锰酸盐指数");

                entity.Property(e => e.Vc10)
                    .HasColumnName("vc_10")
                    .HasColumnType("double(8,0)")
                    .HasComment("锌");

                entity.Property(e => e.Vc11)
                    .HasColumnName("vc_11")
                    .HasColumnType("double(8,0)")
                    .HasComment("氟化物");

                entity.Property(e => e.Vc12)
                    .HasColumnName("vc_12")
                    .HasColumnType("double(8,0)")
                    .HasComment("硒");

                entity.Property(e => e.Vc13)
                    .HasColumnName("vc_13")
                    .HasColumnType("double(8,0)")
                    .HasComment("砷");

                entity.Property(e => e.Vc14)
                    .HasColumnName("vc_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("汞");

                entity.Property(e => e.Vc15)
                    .HasColumnName("vc_15")
                    .HasColumnType("double(8,0)")
                    .HasComment("镉");

                entity.Property(e => e.Vc16)
                    .HasColumnName("vc_16")
                    .HasColumnType("double(8,0)")
                    .HasComment("铬（六价）");

                entity.Property(e => e.Vc17)
                    .HasColumnName("vc_17")
                    .HasColumnType("double(8,0)")
                    .HasComment("铅");

                entity.Property(e => e.Vc18)
                    .HasColumnName("vc_18")
                    .HasColumnType("double(8,0)")
                    .HasComment("氰化物");

                entity.Property(e => e.Vc19)
                    .HasColumnName("vc_19")
                    .HasColumnType("double(8,0)")
                    .HasComment("挥发酚");

                entity.Property(e => e.Vc2)
                    .HasColumnName("vc_2")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Vc20)
                    .HasColumnName("vc_20")
                    .HasColumnType("double(8,0)")
                    .HasComment("石油类");

                entity.Property(e => e.Vc21)
                    .HasColumnName("vc_21")
                    .HasColumnType("double(8,0)")
                    .HasComment("阴离子表面活性剂");

                entity.Property(e => e.Vc22)
                    .HasColumnName("vc_22")
                    .HasColumnType("double(8,0)")
                    .HasComment("硫化物");

                entity.Property(e => e.Vc23)
                    .HasColumnName("vc_23")
                    .HasColumnType("double(8,0)")
                    .HasComment("粪大肠菌群");

                entity.Property(e => e.Vc24)
                    .HasColumnName("vc_24")
                    .HasColumnType("double(8,0)")
                    .HasComment("叶绿素a");

                entity.Property(e => e.Vc3)
                    .HasColumnName("vc_3")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Vc4)
                    .HasColumnName("vc_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Vc5)
                    .HasColumnName("vc_5")
                    .HasColumnType("double(8,0)")
                    .HasComment("化学需氧量");

                entity.Property(e => e.Vc6)
                    .HasColumnName("vc_6")
                    .HasColumnType("double(8,0)")
                    .HasComment("五日生化需氧量（BOD5）");

                entity.Property(e => e.Vc7)
                    .HasColumnName("vc_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.Vc8)
                    .HasColumnName("vc_8")
                    .HasColumnType("double(8,0)")
                    .HasComment("总氮");

                entity.Property(e => e.Vc9)
                    .HasColumnName("vc_9")
                    .HasColumnType("double(8,0)")
                    .HasComment("铜");
            });

            modelBuilder.Entity<TbHddbsObjInfo>(entity =>
            {
                entity.ToTable("tb_hddbs_obj_info");

                entity.HasComment("河道地表水的对象信息");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)")
                    .HasComment("主键id,对象信息表的主键id（自增）");

                entity.Property(e => e.Duty)
                    .HasColumnName("duty")
                    .HasColumnType("varchar(255)")
                    .HasComment("职位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gl)
                    .HasColumnName("gl")
                    .HasColumnType("varchar(255)")
                    .HasComment("干流")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hzxm)
                    .HasColumnName("hzxm")
                    .HasColumnType("varchar(255)")
                    .HasComment("河长姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除,1代表正常，0代表删除");

                entity.Property(e => e.Kzjb)
                    .HasColumnName("kzjb")
                    .HasColumnType("varchar(255)")
                    .HasComment("控制级别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lxfs)
                    .HasColumnName("lxfs")
                    .HasColumnType("varchar(255)")
                    .HasComment("联系方式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mbsz)
                    .HasColumnName("mbsz")
                    .HasColumnType("varchar(255)")
                    .HasComment("目标水质")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和具体数据表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("监测点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objtypename)
                    .HasColumnName("objtypename")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象类型名称,当前对象所属的类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Skh)
                    .HasColumnName("skh")
                    .HasColumnType("varchar(255)")
                    .HasComment("市考核")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sshd)
                    .HasColumnName("sshd")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属河道")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssxzjd)
                    .HasColumnName("ssxzjd")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属乡镇街道")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Xzkh)
                    .HasColumnName("xzkh")
                    .HasColumnType("varchar(255)")
                    .HasComment("乡镇考核")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ypbh)
                    .HasColumnName("ypbh")
                    .HasColumnType("varchar(255)")
                    .HasComment("样品编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TbJhpjwgzdDataDayR>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_jhpjwgzd_data_day_r");

                entity.HasComment("网格站点数据信息（人工日数据）");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增),数据表主键id");

                entity.Property(e => e.Aqi)
                    .HasColumnName("aqi")
                    .HasColumnType("double(8,0)")
                    .HasComment("AQI指数");

                entity.Property(e => e.Co)
                    .HasColumnName("co")
                    .HasColumnType("double(8,0)")
                    .HasComment("一氧化碳");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间,YYYY-MM-DD HH:MM:SS");

                entity.Property(e => e.Dqyl)
                    .HasColumnName("dqyl")
                    .HasColumnType("varchar(255)")
                    .HasComment("大气压力")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fs)
                    .HasColumnName("fs")
                    .HasColumnType("varchar(255)")
                    .HasComment("风速,1代表正常，0代表删除")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fx)
                    .HasColumnName("fx")
                    .HasColumnType("double(8,0)")
                    .HasComment("风向");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.No2)
                    .HasColumnName("no2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化氮");

                entity.Property(e => e.O3)
                    .HasColumnName("o3")
                    .HasColumnType("double(8,0)")
                    .HasComment("氧3");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和对象信息表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm10");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm2.5");

                entity.Property(e => e.So2)
                    .HasColumnName("so2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化硫");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("double(8,0)")
                    .HasComment("温度");

                entity.Property(e => e.Xdsd)
                    .HasColumnName("xdsd")
                    .HasColumnType("double(8,0)")
                    .HasComment("相对湿度");
            });

            modelBuilder.Entity<TbJhpjwgzdDataHourR>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_jhpjwgzd_data_hour_r");

                entity.HasComment("网格站点数据信息（人工审核小时数据）");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增),数据表主键id");

                entity.Property(e => e.Aqi)
                    .HasColumnName("aqi")
                    .HasColumnType("double(8,0)")
                    .HasComment("AQI指数");

                entity.Property(e => e.Co)
                    .HasColumnName("co")
                    .HasColumnType("double(8,0)")
                    .HasComment("一氧化碳");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间,YYYY-MM-DD HH:MM:SS");

                entity.Property(e => e.Dqyl)
                    .HasColumnName("dqyl")
                    .HasColumnType("varchar(255)")
                    .HasComment("大气压力")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fs)
                    .HasColumnName("fs")
                    .HasColumnType("varchar(255)")
                    .HasComment("风速,当前时间没有污染时为空")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fx)
                    .HasColumnName("fx")
                    .HasColumnType("double(8,0)")
                    .HasComment("风向");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除,1代表正常，0代表删除");

                entity.Property(e => e.No2)
                    .HasColumnName("no2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化氮");

                entity.Property(e => e.O3)
                    .HasColumnName("o3")
                    .HasColumnType("double(8,0)")
                    .HasComment("氧3");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和对象信息表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm10");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm2.5");

                entity.Property(e => e.So2)
                    .HasColumnName("so2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化硫");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("double(8,0)")
                    .HasComment("温度");

                entity.Property(e => e.Xdsd)
                    .HasColumnName("xdsd")
                    .HasColumnType("double(8,0)")
                    .HasComment("相对湿度");
            });

            modelBuilder.Entity<TbJhpjwgzdDataHourZ>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_jhpjwgzd_data_hour_z");

                entity.HasComment("网格站点数据信息（人工审核小时数据）");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增),数据表主键id");

                entity.Property(e => e.Aqi)
                    .HasColumnName("aqi")
                    .HasColumnType("double(8,0)")
                    .HasComment("AQI指数");

                entity.Property(e => e.Co)
                    .HasColumnName("co")
                    .HasColumnType("double(8,0)")
                    .HasComment("一氧化碳");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间,YYYY-MM-DD HH:MM:SS");

                entity.Property(e => e.Dqyl)
                    .HasColumnName("dqyl")
                    .HasColumnType("varchar(255)")
                    .HasComment("大气压力")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fs)
                    .HasColumnName("fs")
                    .HasColumnType("varchar(255)")
                    .HasComment("风速,当前时间没有污染时为空")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fx)
                    .HasColumnName("fx")
                    .HasColumnType("double(8,0)")
                    .HasComment("风向");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除,1代表正常，0代表删除");

                entity.Property(e => e.No2)
                    .HasColumnName("no2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化氮");

                entity.Property(e => e.O3)
                    .HasColumnName("o3")
                    .HasColumnType("double(8,0)")
                    .HasComment("氧3");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID,对象站点的id，和对象信息表关联");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm10");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("pm2.5");

                entity.Property(e => e.So2)
                    .HasColumnName("so2")
                    .HasColumnType("double(8,0)")
                    .HasComment("二氧化硫");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间,当前数据导入表中的时间（自动更新）")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("double(8,0)")
                    .HasComment("温度");

                entity.Property(e => e.Xdsd)
                    .HasColumnName("xdsd")
                    .HasColumnType("double(8,0)")
                    .HasComment("相对湿度");
            });

            modelBuilder.Entity<TbSzzdjcjcdDataDay>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_szzdjcjcd_data_day");

                entity.HasComment("水质自动监测点数据信息（自动日数据）");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增）");

                entity.Property(e => e.Bh1)
                    .HasColumnName("bh_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Bh14)
                    .HasColumnName("bh_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Bh16)
                    .HasColumnName("bh_16")
                    .HasColumnType("double(8,0)")
                    .HasComment("高锰酸盐指数");

                entity.Property(e => e.Bh4)
                    .HasColumnName("bh_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Bh7)
                    .HasColumnName("bh_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TbSzzdjcjcdDataHour>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_szzdjcjcd_data_hour");

                entity.HasComment("水质自动监测点数据信息（自动小时数据）");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增）");

                entity.Property(e => e.Bh1)
                    .HasColumnName("bh_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Bh10)
                    .HasColumnName("bh_10")
                    .HasColumnType("double(8,0)")
                    .HasComment("隐藻");

                entity.Property(e => e.Bh11)
                    .HasColumnName("bh_11")
                    .HasColumnType("double(8,0)")
                    .HasComment("蓝藻");

                entity.Property(e => e.Bh12)
                    .HasColumnName("bh_12")
                    .HasColumnType("double(8,0)")
                    .HasComment("总叶绿素");

                entity.Property(e => e.Bh14)
                    .HasColumnName("bh_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Bh16)
                    .HasColumnName("bh_16")
                    .HasColumnType("double(8,0)")
                    .HasComment("高锰酸盐指数");

                entity.Property(e => e.Bh2)
                    .HasColumnName("bh_2")
                    .HasColumnType("double(8,0)")
                    .HasComment("总氮");

                entity.Property(e => e.Bh3)
                    .HasColumnName("bh_3")
                    .HasColumnType("double(8,0)")
                    .HasComment("水温");

                entity.Property(e => e.Bh4)
                    .HasColumnName("bh_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Bh5)
                    .HasColumnName("bh_5")
                    .HasColumnType("double(8,0)")
                    .HasComment("电导率");

                entity.Property(e => e.Bh6)
                    .HasColumnName("bh_6")
                    .HasColumnType("double(8,0)")
                    .HasComment("浊度");

                entity.Property(e => e.Bh7)
                    .HasColumnName("bh_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.Bh8)
                    .HasColumnName("bh_8")
                    .HasColumnType("double(8,0)")
                    .HasComment("绿藻");

                entity.Property(e => e.Bh9)
                    .HasColumnName("bh_9")
                    .HasColumnType("double(8,0)")
                    .HasComment("硅甲藻");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TbSzzdjcjcdDataMonth>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_szzdjcjcd_data_month");

                entity.HasComment("水质自动监测点数据信息（自动月数据）");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增）");

                entity.Property(e => e.Bh1)
                    .HasColumnName("bh_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Bh14)
                    .HasColumnName("bh_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Bh16)
                    .HasColumnName("bh_16")
                    .HasColumnType("double(8,0)")
                    .HasComment("高锰酸盐指数");

                entity.Property(e => e.Bh4)
                    .HasColumnName("bh_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Bh7)
                    .HasColumnName("bh_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TbSzzdjcjcdObjInfo>(entity =>
            {
                entity.ToTable("tb_szzdjcjcd_obj_info");

                entity.HasComment("水质自动监测点的对象信息");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)")
                    .HasComment("主键id");

                entity.Property(e => e.Cdbh)
                    .HasColumnName("cdbh")
                    .HasColumnType("varchar(255)")
                    .HasComment("站点编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dmsx)
                    .HasColumnName("dmsx")
                    .HasColumnType("varchar(255)")
                    .HasComment("断面属性")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除");

                entity.Property(e => e.Jd)
                    .HasColumnName("jd")
                    .HasColumnType("varchar(255)")
                    .HasComment("经度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Jgjb)
                    .HasColumnName("jgjb")
                    .HasColumnType("varchar(255)")
                    .HasComment("监管级别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objtypename)
                    .HasColumnName("objtypename")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象类型名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Qy)
                    .HasColumnName("qy")
                    .HasColumnType("varchar(255)")
                    .HasComment("区域")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssds)
                    .HasColumnName("ssds")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属地市")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssjd)
                    .HasColumnName("ssjd")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属街道")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssly)
                    .HasColumnName("ssly")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属流域")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssqx)
                    .HasColumnName("ssqx")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属区县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sssf)
                    .HasColumnName("sssf")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属省份")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sssx)
                    .HasColumnName("sssx")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属水系")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Szlb)
                    .HasColumnName("szlb")
                    .HasColumnType("varchar(255)")
                    .HasComment("水质类别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("varchar(255)")
                    .HasComment("纬度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Xzqhdm)
                    .HasColumnName("xzqhdm")
                    .HasColumnType("varchar(255)")
                    .HasComment("行政区划代码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zxbzmc)
                    .HasColumnName("zxbzmc")
                    .HasColumnType("varchar(255)")
                    .HasComment("执行标准名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TbYcjcdDataDay>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_ycjcd_data_day");

                entity.HasComment("扬尘监测点的数据表（日数据）：存放下属站点的日数据");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键ID");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据监测时间");

                entity.Property(e => e.Fpm10)
                    .HasColumnName("fpm10")
                    .HasColumnType("varchar(255)")
                    .HasComment("PM10阀值")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fpm25)
                    .HasColumnName("fpm25")
                    .HasColumnType("varchar(255)")
                    .HasComment("PM2.5阀值")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("PM10");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("PM2.5");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(255)")
                    .HasComment("扬尘数据状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TbYcjcdDataHour>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_ycjcd_data_hour");

                entity.HasComment("扬尘监测点的数据表（小时数据）：存放下属站点的小时数据");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键ID");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据监测时间");

                entity.Property(e => e.Fpm10)
                    .HasColumnName("fpm10")
                    .HasColumnType("varchar(255)")
                    .HasComment("PM10阀值")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fpm25)
                    .HasColumnName("fpm25")
                    .HasColumnType("varchar(255)")
                    .HasComment("PM2.5阀值")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("double(8,0)")
                    .HasComment("PM10");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("double(8,0)")
                    .HasComment("PM2.5");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(255)")
                    .HasComment("扬尘数据状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TbYcjcdObjInfo>(entity =>
            {
                entity.ToTable("tb_ycjcd_obj_info");

                entity.HasComment("扬尘监测点的对象信息表：存放扬尘监测点下属站点的基本信息");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)")
                    .HasComment("主键ID");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("varchar(255)")
                    .HasComment("设备编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除");

                entity.Property(e => e.Jd)
                    .HasColumnName("jd")
                    .HasColumnType("varchar(255)")
                    .HasComment("经度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objtypename)
                    .HasColumnName("objtypename")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象类型名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(255)")
                    .HasComment("监测区域")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(255)")
                    .HasComment("设备状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("varchar(255)")
                    .HasComment("纬度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TbYyszdjcdDataHour>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("PRIMARY");

                entity.ToTable("tb_yyszdjcd_data_hour");

                entity.HasComment("饮用水自动监测点数据信息（自动小时数据）");

                entity.Property(e => e.Dataid)
                    .HasColumnName("dataid")
                    .HasColumnType("int(8)")
                    .HasComment("主键id（自增）");

                entity.Property(e => e.Bh1)
                    .HasColumnName("bh_1")
                    .HasColumnType("double(8,0)")
                    .HasComment("总磷");

                entity.Property(e => e.Bh10)
                    .HasColumnName("bh_10")
                    .HasColumnType("double(8,0)")
                    .HasComment("隐藻");

                entity.Property(e => e.Bh11)
                    .HasColumnName("bh_11")
                    .HasColumnType("double(8,0)")
                    .HasComment("蓝藻");

                entity.Property(e => e.Bh12)
                    .HasColumnName("bh_12")
                    .HasColumnType("double(8,0)")
                    .HasComment("总叶绿素");

                entity.Property(e => e.Bh13)
                    .HasColumnName("bh_13")
                    .HasColumnType("double(8,0)")
                    .HasComment("CODmn");

                entity.Property(e => e.Bh14)
                    .HasColumnName("bh_14")
                    .HasColumnType("double(8,0)")
                    .HasComment("氨氮");

                entity.Property(e => e.Bh15)
                    .HasColumnName("bh_15")
                    .HasColumnType("double(8,0)")
                    .HasComment("生物毒性（发光菌）");

                entity.Property(e => e.Bh2)
                    .HasColumnName("bh_2")
                    .HasColumnType("double(8,0)")
                    .HasComment("总氮");

                entity.Property(e => e.Bh3)
                    .HasColumnName("bh_3")
                    .HasColumnType("double(8,0)")
                    .HasComment("水温");

                entity.Property(e => e.Bh4)
                    .HasColumnName("bh_4")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Bh5)
                    .HasColumnName("bh_5")
                    .HasColumnType("double(8,0)")
                    .HasComment("PH值");

                entity.Property(e => e.Bh6)
                    .HasColumnName("bh_6")
                    .HasColumnType("double(8,0)")
                    .HasComment("浊度");

                entity.Property(e => e.Bh7)
                    .HasColumnName("bh_7")
                    .HasColumnType("double(8,0)")
                    .HasComment("溶解氧");

                entity.Property(e => e.Bh8)
                    .HasColumnName("bh_8")
                    .HasColumnType("double(8,0)")
                    .HasComment("绿藻");

                entity.Property(e => e.Bh9)
                    .HasColumnName("bh_9")
                    .HasColumnType("double(8,0)")
                    .HasComment("硅甲藻");

                entity.Property(e => e.Collecttime)
                    .HasColumnName("collecttime")
                    .HasColumnType("datetime")
                    .HasComment("数据的监测时间");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否被删除");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象站点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TbYyszdjcdObjInfo>(entity =>
            {
                entity.ToTable("tb_yyszdjcd_obj_info");

                entity.HasComment("饮用水自动监测点的对象信息");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(8)")
                    .HasComment("主键id");

                entity.Property(e => e.Cdbh)
                    .HasColumnName("cdbh")
                    .HasColumnType("varchar(255)")
                    .HasComment("站点编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isused)
                    .HasColumnName("isused")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否删除");

                entity.Property(e => e.Jd)
                    .HasColumnName("jd")
                    .HasColumnType("varchar(255)")
                    .HasComment("经度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objid)
                    .HasColumnName("objid")
                    .HasColumnType("int(8)")
                    .HasComment("对象ID");

                entity.Property(e => e.Objname)
                    .HasColumnName("objname")
                    .HasColumnType("varchar(255)")
                    .HasComment("监测点名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Objtypename)
                    .HasColumnName("objtypename")
                    .HasColumnType("varchar(255)")
                    .HasComment("对象类型名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssds)
                    .HasColumnName("ssds")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属地市")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssqx)
                    .HasColumnName("ssqx")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属区县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sssf)
                    .HasColumnName("sssf")
                    .HasColumnType("varchar(255)")
                    .HasComment("所属省份")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("数据更新时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Wd)
                    .HasColumnName("wd")
                    .HasColumnType("varchar(255)")
                    .HasComment("纬度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
