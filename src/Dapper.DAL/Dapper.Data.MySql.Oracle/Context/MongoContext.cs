using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Dapper.Data.MySql.Oracle.Model;

namespace Dapper.Data.MySql.Oracle.Context
{
    public partial class MongoContext : DbContext
    {
        public MongoContext()
        {
        }

        public MongoContext(DbContextOptions<MongoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<Alarmproc> Alarmproc { get; set; }
        public virtual DbSet<Alarmrec> Alarmrec { get; set; }
        public virtual DbSet<Almreport> Almreport { get; set; }
        public virtual DbSet<Autoproc> Autoproc { get; set; }
        public virtual DbSet<CurData> CurData { get; set; }
        public virtual DbSet<CurIdx> CurIdx { get; set; }
        public virtual DbSet<CurRec> CurRec { get; set; }
        public virtual DbSet<Drgrdrcd> Drgrdrcd { get; set; }
        public virtual DbSet<Dutysat> Dutysat { get; set; }
        public virtual DbSet<Dutyset> Dutyset { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Equip> Equip { get; set; }
        public virtual DbSet<Equipgroup> Equipgroup { get; set; }
        public virtual DbSet<Equipoperation> Equipoperation { get; set; }
        public virtual DbSet<ExprocAll> ExprocAll { get; set; }
        public virtual DbSet<Gisconfig> Gisconfig { get; set; }
        public virtual DbSet<Gisrouteconfig> Gisrouteconfig { get; set; }
        public virtual DbSet<GwAlarminfo> GwAlarminfo { get; set; }
        public virtual DbSet<GwHomeMenu> GwHomeMenu { get; set; }
        public virtual DbSet<GwHomeMenuStatus> GwHomeMenuStatus { get; set; }
        public virtual DbSet<GwLanguage> GwLanguage { get; set; }
        public virtual DbSet<GwMjCard> GwMjCard { get; set; }
        public virtual DbSet<GwMjCardatdoor> GwMjCardatdoor { get; set; }
        public virtual DbSet<GwMjCardatdoorKingkang> GwMjCardatdoorKingkang { get; set; }
        public virtual DbSet<GwMjControllerParamKingkang> GwMjControllerParamKingkang { get; set; }
        public virtual DbSet<GwMjDeptment> GwMjDeptment { get; set; }
        public virtual DbSet<GwMjDoorinfo> GwMjDoorinfo { get; set; }
        public virtual DbSet<GwMjDoorparam> GwMjDoorparam { get; set; }
        public virtual DbSet<GwMjDrgrdrcd> GwMjDrgrdrcd { get; set; }
        public virtual DbSet<GwMjHoliday> GwMjHoliday { get; set; }
        public virtual DbSet<GwMjHolidayatdoor> GwMjHolidayatdoor { get; set; }
        public virtual DbSet<GwMjMember> GwMjMember { get; set; }
        public virtual DbSet<GwMjMulticardgroup> GwMjMulticardgroup { get; set; }
        public virtual DbSet<GwMjPreTimezoneKingkang> GwMjPreTimezoneKingkang { get; set; }
        public virtual DbSet<GwMjRealtimeinout> GwMjRealtimeinout { get; set; }
        public virtual DbSet<GwMjTimegroup> GwMjTimegroup { get; set; }
        public virtual DbSet<GwMjTimezoneKingkang> GwMjTimezoneKingkang { get; set; }
        public virtual DbSet<GwMjTrafficGroup> GwMjTrafficGroup { get; set; }
        public virtual DbSet<GwMjTrafficGroupatdoorKingkang> GwMjTrafficGroupatdoorKingkang { get; set; }
        public virtual DbSet<GwPatrolCard> GwPatrolCard { get; set; }
        public virtual DbSet<GwPatrolCardtype> GwPatrolCardtype { get; set; }
        public virtual DbSet<GwPatrolComport> GwPatrolComport { get; set; }
        public virtual DbSet<GwPatrolException> GwPatrolException { get; set; }
        public virtual DbSet<GwPatrolMeter> GwPatrolMeter { get; set; }
        public virtual DbSet<GwPatrolPatrolgroup> GwPatrolPatrolgroup { get; set; }
        public virtual DbSet<GwPatrolPlandetails> GwPatrolPlandetails { get; set; }
        public virtual DbSet<GwPatrolPlantable> GwPatrolPlantable { get; set; }
        public virtual DbSet<GwPatrolPlantabledaylist> GwPatrolPlantabledaylist { get; set; }
        public virtual DbSet<GwPatrolPlantableinspectorlist> GwPatrolPlantableinspectorlist { get; set; }
        public virtual DbSet<GwPatrolPlantabletimelist> GwPatrolPlantabletimelist { get; set; }
        public virtual DbSet<GwPatrolRecordOrigin> GwPatrolRecordOrigin { get; set; }
        public virtual DbSet<GwPatrolResult> GwPatrolResult { get; set; }
        public virtual DbSet<GwPatrolRoute> GwPatrolRoute { get; set; }
        public virtual DbSet<GwPatrolRoutesetting> GwPatrolRoutesetting { get; set; }
        public virtual DbSet<GwPatrolStatus> GwPatrolStatus { get; set; }
        public virtual DbSet<GwPtzcontrol> GwPtzcontrol { get; set; }
        public virtual DbSet<GwQrCheck> GwQrCheck { get; set; }
        public virtual DbSet<GwQrRecord> GwQrRecord { get; set; }
        public virtual DbSet<GwSpArea> GwSpArea { get; set; }
        public virtual DbSet<GwSpChannel> GwSpChannel { get; set; }
        public virtual DbSet<GwSpDvrinfo> GwSpDvrinfo { get; set; }
        public virtual DbSet<GwSpDvrtype> GwSpDvrtype { get; set; }
        public virtual DbSet<GwSpGroup> GwSpGroup { get; set; }
        public virtual DbSet<GwSpMethod> GwSpMethod { get; set; }
        public virtual DbSet<GwSpModul> GwSpModul { get; set; }
        public virtual DbSet<GwUnityMarkview> GwUnityMarkview { get; set; }
        public virtual DbSet<GwUnityModel> GwUnityModel { get; set; }
        public virtual DbSet<GwUnityParade> GwUnityParade { get; set; }
        public virtual DbSet<GwUnityResource> GwUnityResource { get; set; }
        public virtual DbSet<GwUnityScene> GwUnityScene { get; set; }
        public virtual DbSet<GwVideoCyclechannel> GwVideoCyclechannel { get; set; }
        public virtual DbSet<GwVideoPreset> GwVideoPreset { get; set; }
        public virtual DbSet<GwVideoinfo> GwVideoinfo { get; set; }
        public virtual DbSet<Gwaddinmodule> Gwaddinmodule { get; set; }
        public virtual DbSet<Gwassetinfo> Gwassetinfo { get; set; }
        public virtual DbSet<Gwbuttonproperty> Gwbuttonproperty { get; set; }
        public virtual DbSet<Gwdatarecorditems> Gwdatarecorditems { get; set; }
        public virtual DbSet<Gwdatarecordresult> Gwdatarecordresult { get; set; }
        public virtual DbSet<Gwdelayaction> Gwdelayaction { get; set; }
        public virtual DbSet<Gwelevatormaintain> Gwelevatormaintain { get; set; }
        public virtual DbSet<Gwelevatormarker> Gwelevatormarker { get; set; }
        public virtual DbSet<Gwequippages> Gwequippages { get; set; }
        public virtual DbSet<Gwequiptreegroup> Gwequiptreegroup { get; set; }
        public virtual DbSet<Gwequiptreeitem> Gwequiptreeitem { get; set; }
        public virtual DbSet<Gwexproc> Gwexproc { get; set; }
        public virtual DbSet<Gwexproccmd> Gwexproccmd { get; set; }
        public virtual DbSet<Gwmaintainer> Gwmaintainer { get; set; }
        public virtual DbSet<Gwmapmarker> Gwmapmarker { get; set; }
        public virtual DbSet<Gwnavigationproperty> Gwnavigationproperty { get; set; }
        public virtual DbSet<Gwplan> Gwplan { get; set; }
        public virtual DbSet<Gwplanrecord> Gwplanrecord { get; set; }
        public virtual DbSet<Gwproccycletable> Gwproccycletable { get; set; }
        public virtual DbSet<Gwproccycletlist> Gwproccycletlist { get; set; }
        public virtual DbSet<Gwprocspectable> Gwprocspectable { get; set; }
        public virtual DbSet<Gwproctimeeqptable> Gwproctimeeqptable { get; set; }
        public virtual DbSet<Gwproctimesystable> Gwproctimesystable { get; set; }
        public virtual DbSet<Gwproctimetlist> Gwproctimetlist { get; set; }
        public virtual DbSet<Gwprocweektable> Gwprocweektable { get; set; }
        public virtual DbSet<Gwreportinfo> Gwreportinfo { get; set; }
        public virtual DbSet<Gwrole> Gwrole { get; set; }
        public virtual DbSet<Gwsnapshotconfig> Gwsnapshotconfig { get; set; }
        public virtual DbSet<Gwuser> Gwuser { get; set; }
        public virtual DbSet<Gwwebmapmarker> Gwwebmapmarker { get; set; }
        public virtual DbSet<Gwzichanrecord> Gwzichanrecord { get; set; }
        public virtual DbSet<Gwzichantable> Gwzichantable { get; set; }
        public virtual DbSet<Gwzichantableexcolumn> Gwzichantableexcolumn { get; set; }
        public virtual DbSet<Hsncardno> Hsncardno { get; set; }
        public virtual DbSet<IotDevice> IotDevice { get; set; }
        public virtual DbSet<IotDeviceservice> IotDeviceservice { get; set; }
        public virtual DbSet<IotDeviceservicemodel> IotDeviceservicemodel { get; set; }
        public virtual DbSet<IotDevicetype> IotDevicetype { get; set; }
        public virtual DbSet<KingkangCardatdoor> KingkangCardatdoor { get; set; }
        public virtual DbSet<KingkangDept> KingkangDept { get; set; }
        public virtual DbSet<KingkangMember> KingkangMember { get; set; }
        public virtual DbSet<KingkangTmg> KingkangTmg { get; set; }
        public virtual DbSet<Matafun> Matafun { get; set; }
        public virtual DbSet<Mataobj> Mataobj { get; set; }
        public virtual DbSet<Matasubtype> Matasubtype { get; set; }
        public virtual DbSet<Matasymb> Matasymb { get; set; }
        public virtual DbSet<Nsladmission> Nsladmission { get; set; }
        public virtual DbSet<Nslcardno> Nslcardno { get; set; }
        public virtual DbSet<Nsldateg> Nsldateg { get; set; }
        public virtual DbSet<Nslweekg> Nslweekg { get; set; }
        public virtual DbSet<Operationequip> Operationequip { get; set; }
        public virtual DbSet<Operationlog> Operationlog { get; set; }
        public virtual DbSet<Operationrec> Operationrec { get; set; }
        public virtual DbSet<PersonnelFaceimage> PersonnelFaceimage { get; set; }
        public virtual DbSet<Rawequip> Rawequip { get; set; }
        public virtual DbSet<Rawycp> Rawycp { get; set; }
        public virtual DbSet<Rawyxp> Rawyxp { get; set; }
        public virtual DbSet<Resdscp> Resdscp { get; set; }
        public virtual DbSet<Rtuyxtab> Rtuyxtab { get; set; }
        public virtual DbSet<Sc302encode> Sc302encode { get; set; }
        public virtual DbSet<Sc302timeg> Sc302timeg { get; set; }
        public virtual DbSet<Setevt> Setevt { get; set; }
        public virtual DbSet<Setparm> Setparm { get; set; }
        public virtual DbSet<Smsreqcont> Smsreqcont { get; set; }
        public virtual DbSet<Smsreqlist> Smsreqlist { get; set; }
        public virtual DbSet<Spealmreport> Spealmreport { get; set; }
        public virtual DbSet<Station> Station { get; set; }
        public virtual DbSet<Syappg> Syappg { get; set; }
        public virtual DbSet<Sycardno> Sycardno { get; set; }
        public virtual DbSet<Sydatag> Sydatag { get; set; }
        public virtual DbSet<Sysevt> Sysevt { get; set; }
        public virtual DbSet<Sytimeg> Sytimeg { get; set; }
        public virtual DbSet<TcInoutls> TcInoutls { get; set; }
        public virtual DbSet<Telphone> Telphone { get; set; }
        public virtual DbSet<Visitorrecord> Visitorrecord { get; set; }
        public virtual DbSet<Weekalmreport> Weekalmreport { get; set; }
        public virtual DbSet<Weekdatag> Weekdatag { get; set; }
        public virtual DbSet<Welcomingspeech> Welcomingspeech { get; set; }
        public virtual DbSet<Woacceptorder> Woacceptorder { get; set; }
        public virtual DbSet<Woattachment> Woattachment { get; set; }
        public virtual DbSet<Womainfeedbackattachment> Womainfeedbackattachment { get; set; }
        public virtual DbSet<Womainfeedbackconfirm> Womainfeedbackconfirm { get; set; }
        public virtual DbSet<Womaintenancefeedback> Womaintenancefeedback { get; set; }
        public virtual DbSet<Worecord> Worecord { get; set; }
        public virtual DbSet<Workorder> Workorder { get; set; }
        public virtual DbSet<Workstation> Workstation { get; set; }
        public virtual DbSet<Ycp> Ycp { get; set; }
        public virtual DbSet<Ycyxevt> Ycyxevt { get; set; }
        public virtual DbSet<Ycyxevtreport> Ycyxevtreport { get; set; }
        public virtual DbSet<Yxp> Yxp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=localhost;Database=databasesql;User=root;Password=357592895;TreatTinyAsBoolean=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.HasKey(e => e.Administrator1)
                    .HasName("PRIMARY");

                entity.ToTable("administrator");

                entity.Property(e => e.Administrator1)
                    .HasColumnName("Administrator")
                    .HasMaxLength(32);

                entity.Property(e => e.AckLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(32);

                entity.Property(e => e.MobileTel).HasMaxLength(32);

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.Telphone).HasMaxLength(32);
            });

            modelBuilder.Entity<Alarmproc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("alarmproc");

                entity.Property(e => e.Comment).HasMaxLength(240);

                entity.Property(e => e.ProcCode)
                    .HasColumnName("Proc_Code")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProcModule)
                    .HasColumnName("Proc_Module")
                    .HasMaxLength(32);

                entity.Property(e => e.ProcName)
                    .HasColumnName("Proc_name")
                    .HasMaxLength(48);

                entity.Property(e => e.ProcParm)
                    .HasColumnName("Proc_parm")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Alarmrec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("alarmrec");

                entity.Property(e => e.Administrator)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(64);

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasMaxLength(128);

                entity.Property(e => e.ProcName)
                    .HasColumnName("proc_name")
                    .HasMaxLength(48);
            });

            modelBuilder.Entity<Almreport>(entity =>
            {
                entity.ToTable("almreport");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Administrator).HasMaxLength(32);

                entity.Property(e => e.GroupNo)
                    .HasColumnName("group_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Autoproc>(entity =>
            {
                entity.ToTable("autoproc");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Delay)
                    .HasColumnName("delay")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Enable)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IequipNo)
                    .HasColumnName("iequip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IycyxNo)
                    .HasColumnName("iycyx_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IycyxType)
                    .HasColumnName("iycyx_type")
                    .HasMaxLength(16);

                entity.Property(e => e.OequipNo)
                    .HasColumnName("oequip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OsetNo)
                    .HasColumnName("oset_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcDesc).HasMaxLength(255);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CurData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_data");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("EQUIP_NO")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StaN)
                    .HasColumnName("STA_N")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.YcNo)
                    .HasColumnName("YC_NO")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CurIdx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_idx");

                entity.Property(e => e.CurvNo)
                    .HasColumnName("curv_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.YcNo)
                    .HasColumnName("yc_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CurRec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_rec");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("longblob");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("EQUIP_NO")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StaN)
                    .HasColumnName("STA_N")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.YcNo)
                    .HasColumnName("YC_NO")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Drgrdrcd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("drgrdrcd");

                entity.Property(e => e.Action).HasMaxLength(64);

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuardNo)
                    .HasColumnName("guard_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name).HasMaxLength(32);
            });

            modelBuilder.Entity<Dutysat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dutysat");

                entity.Property(e => e.ALateCount)
                    .HasColumnName("A_Late_Count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ALeaveEarlyCount)
                    .HasColumnName("A_LeaveEarly_Count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AOnTmCount)
                    .HasColumnName("A_OnTm_Count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.D1).HasMaxLength(2);

                entity.Property(e => e.D10).HasMaxLength(2);

                entity.Property(e => e.D11).HasMaxLength(2);

                entity.Property(e => e.D12).HasMaxLength(2);

                entity.Property(e => e.D13).HasMaxLength(2);

                entity.Property(e => e.D14).HasMaxLength(2);

                entity.Property(e => e.D15).HasMaxLength(2);

                entity.Property(e => e.D16).HasMaxLength(2);

                entity.Property(e => e.D17).HasMaxLength(2);

                entity.Property(e => e.D18).HasMaxLength(2);

                entity.Property(e => e.D19).HasMaxLength(2);

                entity.Property(e => e.D2).HasMaxLength(2);

                entity.Property(e => e.D20).HasMaxLength(2);

                entity.Property(e => e.D21).HasMaxLength(2);

                entity.Property(e => e.D22).HasMaxLength(2);

                entity.Property(e => e.D23).HasMaxLength(2);

                entity.Property(e => e.D24).HasMaxLength(2);

                entity.Property(e => e.D25).HasMaxLength(2);

                entity.Property(e => e.D26).HasMaxLength(2);

                entity.Property(e => e.D27).HasMaxLength(2);

                entity.Property(e => e.D28).HasMaxLength(2);

                entity.Property(e => e.D29).HasMaxLength(2);

                entity.Property(e => e.D3).HasMaxLength(2);

                entity.Property(e => e.D30).HasMaxLength(2);

                entity.Property(e => e.D31).HasMaxLength(2);

                entity.Property(e => e.D4).HasMaxLength(2);

                entity.Property(e => e.D5).HasMaxLength(2);

                entity.Property(e => e.D6).HasMaxLength(2);

                entity.Property(e => e.D7).HasMaxLength(2);

                entity.Property(e => e.D8).HasMaxLength(2);

                entity.Property(e => e.D9).HasMaxLength(2);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("ID")
                    .HasMaxLength(8);

                entity.Property(e => e.MLateCount)
                    .HasColumnName("M_Late_Count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MLeaveEarlyCount)
                    .HasColumnName("M_LeaveEarly_Count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MOnTmCount)
                    .HasColumnName("M_OnTm_Count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name).HasMaxLength(32);

                entity.Property(e => e.Yymm)
                    .HasColumnName("YYMM")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<Dutyset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dutyset");

                entity.Property(e => e.AInTmBgn)
                    .HasColumnName("A_InTm_Bgn")
                    .HasMaxLength(8);

                entity.Property(e => e.AInTmEnd)
                    .HasColumnName("A_InTm_End")
                    .HasMaxLength(8);

                entity.Property(e => e.ALateBgn)
                    .HasColumnName("A_Late_Bgn")
                    .HasMaxLength(8);

                entity.Property(e => e.ALateEnd)
                    .HasColumnName("A_Late_End")
                    .HasMaxLength(8);

                entity.Property(e => e.ALeaveEarlyBgn)
                    .HasColumnName("A_Leave_Early_Bgn")
                    .HasMaxLength(8);

                entity.Property(e => e.ALeaveEarlyEnd)
                    .HasColumnName("A_Leave_Early_End")
                    .HasMaxLength(8);

                entity.Property(e => e.ALeaveOnTmBgn)
                    .HasColumnName("A_Leave_OnTm_Bgn")
                    .HasMaxLength(8);

                entity.Property(e => e.ALeaveOnTmEnd)
                    .HasColumnName("A_Leave_OnTm_End")
                    .HasMaxLength(8);

                entity.Property(e => e.MInTmBgn)
                    .HasColumnName("M_InTm_Bgn")
                    .HasMaxLength(8);

                entity.Property(e => e.MInTmEnd)
                    .HasColumnName("M_InTm_End")
                    .HasMaxLength(8);

                entity.Property(e => e.MLateBgn)
                    .HasColumnName("M_Late_Bgn")
                    .HasMaxLength(8);

                entity.Property(e => e.MLateEnd)
                    .HasColumnName("M_Late_End")
                    .HasMaxLength(8);

                entity.Property(e => e.MLeaveEarlyBgn)
                    .HasColumnName("M_Leave_Early_Bgn")
                    .HasMaxLength(8);

                entity.Property(e => e.MLeaveEarlyEnd)
                    .HasColumnName("M_Leave_Early_End")
                    .HasMaxLength(8);

                entity.Property(e => e.MLeaveOnTmBgn)
                    .HasColumnName("M_Leave_OnTm_Bgn")
                    .HasMaxLength(8);

                entity.Property(e => e.MLeaveOnTmEnd)
                    .HasColumnName("M_Leave_OnTm_End")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee");

                entity.Property(e => e.CardNo).HasMaxLength(16);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("ID")
                    .HasMaxLength(8);

                entity.Property(e => e.Name).HasMaxLength(32);
            });

            modelBuilder.Entity<Equip>(entity =>
            {
                entity.HasKey(e => e.EquipNo)
                    .HasName("PRIMARY");

                entity.ToTable("equip");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccCyc)
                    .HasColumnName("acc_cyc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlarmRiseCycle)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmScheme)
                    .HasColumnName("alarm_scheme")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attrib)
                    .HasColumnName("attrib")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CommunicationDrv)
                    .HasColumnName("communication_drv")
                    .HasMaxLength(128);

                entity.Property(e => e.CommunicationParam)
                    .HasColumnName("communication_param")
                    .HasColumnType("longtext");

                entity.Property(e => e.CommunicationTimeParam)
                    .HasColumnName("communication_time_param")
                    .HasMaxLength(32);

                entity.Property(e => e.Contacted)
                    .HasColumnName("contacted")
                    .HasMaxLength(64);

                entity.Property(e => e.EquipAddr)
                    .HasColumnName("equip_addr")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipDetail)
                    .HasColumnName("equip_detail")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipNm)
                    .IsRequired()
                    .HasColumnName("equip_nm")
                    .HasMaxLength(64);

                entity.Property(e => e.EventWav)
                    .HasColumnName("event_wav")
                    .HasMaxLength(64);

                entity.Property(e => e.LocalAddr)
                    .HasColumnName("local_addr")
                    .HasMaxLength(128);

                entity.Property(e => e.OutOfContact)
                    .IsRequired()
                    .HasColumnName("out_of_contact")
                    .HasMaxLength(64);

                entity.Property(e => e.PlanNo).HasMaxLength(255);

                entity.Property(e => e.ProcAdvice)
                    .HasColumnName("proc_advice")
                    .HasMaxLength(254);

                entity.Property(e => e.RawEquipNo)
                    .HasColumnName("raw_equip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RelatedPic)
                    .HasColumnName("related_pic")
                    .HasMaxLength(255);

                entity.Property(e => e.RelatedVideo)
                    .HasColumnName("related_video")
                    .HasMaxLength(255);

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.SafeTime).HasColumnType("longtext");

                entity.Property(e => e.StaIp)
                    .HasColumnName("sta_IP")
                    .HasMaxLength(255);

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tabname)
                    .HasColumnName("tabname")
                    .HasMaxLength(15);

                entity.Property(e => e.ZiChanId)
                    .HasColumnName("ZiChanID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Equipgroup>(entity =>
            {
                entity.HasKey(e => e.GroupNo)
                    .HasName("PRIMARY");

                entity.ToTable("equipgroup");

                entity.Property(e => e.GroupNo)
                    .HasColumnName("group_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Equipcomb)
                    .HasColumnName("equipcomb")
                    .HasColumnType("longtext");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasMaxLength(50);

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Equipoperation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("equipoperation");

                entity.Property(e => e.EquipId)
                    .IsRequired()
                    .HasColumnName("equip_id")
                    .HasMaxLength(16);

                entity.Property(e => e.OperationId)
                    .HasColumnName("OPERATION_ID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OperationTitle)
                    .IsRequired()
                    .HasColumnName("OPERATION_TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.StaNm)
                    .IsRequired()
                    .HasColumnName("sta_nm")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ExprocAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("exproc_all");

                entity.Property(e => e.Comment).HasMaxLength(240);

                entity.Property(e => e.ProcCode)
                    .HasColumnName("Proc_Code")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProcModule)
                    .HasColumnName("Proc_Module")
                    .HasMaxLength(32);

                entity.Property(e => e.ProcName)
                    .HasColumnName("Proc_name")
                    .HasMaxLength(48);

                entity.Property(e => e.ProcParm)
                    .HasColumnName("Proc_parm")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Gisconfig>(entity =>
            {
                entity.ToTable("gisconfig");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlarmExpression).HasMaxLength(50);

                entity.Property(e => e.AlarmImage).HasMaxLength(50);

                entity.Property(e => e.CheckImage).HasMaxLength(50);

                entity.Property(e => e.ClickCmd).HasMaxLength(50);

                entity.Property(e => e.ControlType).HasMaxLength(50);

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.ImageHight)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ImageWith)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.MaxZoomNum)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MinZoomNum)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OffsetPoint).HasMaxLength(255);

                entity.Property(e => e.Tooltip).HasMaxLength(50);

                entity.Property(e => e.Zoom)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Gisrouteconfig>(entity =>
            {
                entity.ToTable("gisrouteconfig");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EndPoint).HasMaxLength(255);

                entity.Property(e => e.RouteName).HasMaxLength(255);

                entity.Property(e => e.StartPoint).HasMaxLength(255);
            });

            modelBuilder.Entity<GwAlarminfo>(entity =>
            {
                entity.ToTable("gw_alarminfo");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasColumnType("longtext");

                entity.Property(e => e.PlanNo)
                    .HasColumnName("plan_no")
                    .HasMaxLength(255);

                entity.Property(e => e.RelatedPic)
                    .HasColumnName("related_pic")
                    .HasMaxLength(255);

                entity.Property(e => e.RelatedVideo)
                    .HasColumnName("related_video")
                    .HasMaxLength(255);

                entity.Property(e => e.YcyxNo)
                    .HasColumnName("ycyx_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.YcyxType)
                    .HasColumnName("ycyx_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ZichanNo)
                    .HasColumnName("zichan_no")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwHomeMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_home_menu");

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IconName).HasColumnName("iconName");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MenuName).HasColumnName("menuName");

                entity.Property(e => e.ModulName).HasColumnName("modulName");
            });

            modelBuilder.Entity<GwHomeMenuStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_home_menu_status");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModulName)
                    .HasColumnName("modulName")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("userName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GwLanguage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_language");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LanguageType)
                    .HasColumnName("languageType")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reserve1).HasMaxLength(255);

                entity.Property(e => e.Reserve2).HasMaxLength(255);

                entity.Property(e => e.Reserve3).HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50);

                entity.Property(e => e.VoiceType)
                    .HasColumnName("voiceType")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwMjCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_card");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CardNo)
                    .HasColumnName("card_no")
                    .HasMaxLength(255);

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(255);

                entity.Property(e => e.Reserve1).HasMaxLength(255);

                entity.Property(e => e.Reserve2).HasMaxLength(255);

                entity.Property(e => e.Reserve3).HasMaxLength(255);

                entity.Property(e => e.Reserve4).HasMaxLength(255);

                entity.Property(e => e.Valided)
                    .HasColumnName("valided")
                    .HasColumnType("bit(1)");
            });

            modelBuilder.Entity<GwMjCardatdoor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_cardatdoor");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PermitGroup).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwMjCardatdoorKingkang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_cardatdoor_kingkang");

                entity.Property(e => e.AntiSubmarineBackFlag)
                    .HasColumnName("anti_submarine_back_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HolidayFlag)
                    .HasColumnName("holiday_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.MasterCardFlag)
                    .HasColumnName("master_card_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TimeZoneId)
                    .HasColumnName("time_zone_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WrittenFlag)
                    .HasColumnName("written_flag")
                    .HasColumnType("bit(1)");
            });

            modelBuilder.Entity<GwMjControllerParamKingkang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_controller_param_kingkang");

                entity.Property(e => e.ButtonTimeZoneLimitFlag)
                    .HasColumnName("button_time_zone_limit_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.CardTypeFlag)
                    .HasColumnName("card_type_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DoorInterlockFlag)
                    .HasColumnName("door_interlock_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DoorOpenAlarmTime)
                    .HasColumnName("door_open_alarm_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DoorOpenCloseStatueFlag)
                    .HasColumnName("door_open_close_statue_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DoorOpenTime)
                    .HasColumnName("door_open_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DoorOpenTimeOutAlarmFlag)
                    .HasColumnName("door_open_time_out_alarm_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DoorWithoutOpeningAlarmFlag)
                    .HasColumnName("door_without_opening_alarm_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MultiCardFlag)
                    .HasColumnName("multi_card_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.MultiCardNum)
                    .HasColumnName("multi_card_num")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpenDoorModel)
                    .HasColumnName("open_door_model")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PasswordTimeZoneLimitFlag)
                    .HasColumnName("password_time_zone_limit_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.WrittenFlag)
                    .HasColumnName("written_flag")
                    .HasColumnType("bit(1)");
            });

            modelBuilder.Entity<GwMjDeptment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_deptment");

                entity.Property(e => e.DeptId)
                    .HasColumnName("dept_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeptNm)
                    .HasColumnName("dept_nm")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwMjDoorinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_doorinfo");

                entity.Property(e => e.AttendanceLocusFlag).HasColumnType("bit(1)");

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DoorName)
                    .HasColumnName("door_name")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasColumnType("longtext");

                entity.Property(e => e.PlanNo).HasMaxLength(255);

                entity.Property(e => e.RelatedVideo)
                    .HasColumnName("related_video")
                    .HasMaxLength(255);

                entity.Property(e => e.Reserve1).HasMaxLength(255);

                entity.Property(e => e.Reserve2).HasMaxLength(255);

                entity.Property(e => e.Reserve3).HasMaxLength(255);

                entity.Property(e => e.Reserve4).HasMaxLength(255);

                entity.Property(e => e.Statue).HasMaxLength(255);

                entity.Property(e => e.ZiChanId)
                    .HasColumnName("ZiChanID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwMjDoorparam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_doorparam");

                entity.Property(e => e.DisName)
                    .HasColumnName("disName")
                    .HasMaxLength(255);

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsUse)
                    .HasColumnName("isUse")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Paramtype)
                    .HasColumnName("paramtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwMjDrgrdrcd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_drgrdrcd");

                entity.Property(e => e.Action).HasMaxLength(64);

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.GuardNo)
                    .HasColumnName("guard_no")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Name).HasMaxLength(32);
            });

            modelBuilder.Entity<GwMjHoliday>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_holiday");

                entity.Property(e => e.HolidayId)
                    .HasColumnName("holiday_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HolidayName)
                    .HasColumnName("holiday_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwMjHolidayatdoor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_holidayatdoor");

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HolidayId)
                    .HasColumnName("holiday_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwMjMember>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_mj_member");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasMaxLength(255);

                entity.Property(e => e.DeptId)
                    .HasColumnName("dept_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HeadFlag)
                    .IsRequired()
                    .HasColumnName("head_flag")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.MemberName)
                    .HasColumnName("member_name")
                    .HasMaxLength(255);

                entity.Property(e => e.MemberStatue)
                    .HasColumnName("member_statue")
                    .HasMaxLength(255);

                entity.Property(e => e.Reserve1).HasMaxLength(255);

                entity.Property(e => e.Reserve2).HasMaxLength(255);

                entity.Property(e => e.Reserve3).HasMaxLength(255);

                entity.Property(e => e.Reserve4).HasMaxLength(255);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(255);

                entity.Property(e => e.TrafficGroupId)
                    .HasColumnName("traffic_group_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwMjMulticardgroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_multicardgroup");

                entity.Property(e => e.MultiCardsGroupId)
                    .HasColumnName("multi_cards_group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MultiCardsGroupNm)
                    .HasColumnName("multi_cards_group_nm")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwMjPreTimezoneKingkang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_pre_timezone_kingkang");

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwMjRealtimeinout>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_realtimeinout");

                entity.Property(e => e.Action).HasMaxLength(255);

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuardNo)
                    .HasColumnName("guard_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<GwMjTimegroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_timegroup");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reserve1).HasMaxLength(255);

                entity.Property(e => e.Reserve2).HasMaxLength(255);

                entity.Property(e => e.Reserve3).HasMaxLength(255);

                entity.Property(e => e.Reserve4).HasMaxLength(255);

                entity.Property(e => e.TimeGroupId)
                    .HasColumnName("time_group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TimeGroupName)
                    .HasColumnName("time_group_name")
                    .HasMaxLength(255);

                entity.Property(e => e.WkPermission)
                    .HasColumnName("wk_permission")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwMjTimezoneKingkang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_timezone_kingkang");

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reserve1).HasMaxLength(255);

                entity.Property(e => e.Reserve2).HasMaxLength(255);

                entity.Property(e => e.Reserve3).HasMaxLength(255);

                entity.Property(e => e.Reserve4).HasMaxLength(255);

                entity.Property(e => e.TimeZoneId)
                    .HasColumnName("time_zone_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TimeZoneName)
                    .HasColumnName("time_zone_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwMjTrafficGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_traffic_group");

                entity.Property(e => e.GroupId)
                    .HasColumnName("Group_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupName)
                    .HasColumnName("Group_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwMjTrafficGroupatdoorKingkang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_traffic_groupatdoor_kingkang");

                entity.Property(e => e.AntiSubmarineBackFlag)
                    .HasColumnName("anti_submarine_back_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HolidayFlag)
                    .HasColumnName("holiday_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.MasterCardFlag)
                    .HasColumnName("master_card_flag")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TimeZoneId)
                    .HasColumnName("time_zone_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwPatrolCard>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_card");

                entity.Property(e => e.CardId).HasColumnType("int(11)");

                entity.Property(e => e.CardNo).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Orders).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwPatrolCardtype>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_cardtype");

                entity.Property(e => e.TypeId).HasColumnType("int(11)");

                entity.Property(e => e.TypeName).HasMaxLength(255);
            });

            modelBuilder.Entity<GwPatrolComport>(entity =>
            {
                entity.HasKey(e => e.MeterType)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_comport");

                entity.Property(e => e.MeterType).HasColumnType("int(11)");

                entity.Property(e => e.CommunicationParam).HasMaxLength(255);

                entity.Property(e => e.Port).HasMaxLength(255);
            });

            modelBuilder.Entity<GwPatrolException>(entity =>
            {
                entity.HasKey(e => e.ExpId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_exception");

                entity.Property(e => e.ExpId).HasMaxLength(255);

                entity.Property(e => e.ExpName).HasMaxLength(255);
            });

            modelBuilder.Entity<GwPatrolMeter>(entity =>
            {
                entity.HasKey(e => e.MeterId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_meter");

                entity.Property(e => e.MeterId).HasColumnType("int(11)");

                entity.Property(e => e.MeterNo).HasMaxLength(255);

                entity.Property(e => e.RouteId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwPatrolPatrolgroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_patrolgroup");

                entity.Property(e => e.GroupId).HasColumnType("int(11)");

                entity.Property(e => e.GroupName).HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GwPatrolPlandetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_patrol_plandetails");

                entity.Property(e => e.ExceptionId).HasMaxLength(255);

                entity.Property(e => e.InspectorId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LocusId).HasMaxLength(255);

                entity.Property(e => e.PlanTableId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RouteId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'3'");
            });

            modelBuilder.Entity<GwPatrolPlantable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_patrol_plantable");

                entity.Property(e => e.Later).HasColumnType("int(11)");

                entity.Property(e => e.Permit).HasColumnType("int(11)");

                entity.Property(e => e.PlanMode).HasColumnType("int(11)");

                entity.Property(e => e.PlanTableId).HasColumnType("int(11)");

                entity.Property(e => e.RouteId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwPatrolPlantabledaylist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_patrol_plantabledaylist");

                entity.Property(e => e.Day).HasColumnType("int(11)");

                entity.Property(e => e.Orders).HasColumnType("int(11)");

                entity.Property(e => e.PlanTableDayListId).HasColumnType("int(11)");

                entity.Property(e => e.PlanTableId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwPatrolPlantableinspectorlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_patrol_plantableinspectorlist");

                entity.Property(e => e.InspectorId)
                    .HasColumnName("InspectorID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Orders).HasColumnType("int(11)");

                entity.Property(e => e.PlanTableId)
                    .HasColumnName("PlanTableID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlanTableInspectorListId)
                    .HasColumnName("PlanTableInspectorListID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwPatrolPlantabletimelist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_patrol_plantabletimelist");

                entity.Property(e => e.Orders).HasColumnType("int(11)");

                entity.Property(e => e.PlanTableId).HasColumnType("int(11)");

                entity.Property(e => e.PlanTableTimeListId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwPatrolRecordOrigin>(entity =>
            {
                entity.ToTable("gw_patrol_record_origin");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ExceptionId)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locus).HasMaxLength(255);

                entity.Property(e => e.MeterId).HasMaxLength(255);

                entity.Property(e => e.PatrolMan).HasMaxLength(255);
            });

            modelBuilder.Entity<GwPatrolResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_patrol_result");

                entity.Property(e => e.ExceptionName).HasMaxLength(255);

                entity.Property(e => e.InspectorName).HasMaxLength(255);

                entity.Property(e => e.LocusCardNo).HasMaxLength(255);

                entity.Property(e => e.LocusName).HasMaxLength(255);

                entity.Property(e => e.RouteName).HasMaxLength(255);

                entity.Property(e => e.StateName).HasMaxLength(255);
            });

            modelBuilder.Entity<GwPatrolRoute>(entity =>
            {
                entity.HasKey(e => e.RouteId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_route");

                entity.Property(e => e.RouteId).HasColumnType("int(11)");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RouteName).HasMaxLength(255);
            });

            modelBuilder.Entity<GwPatrolRoutesetting>(entity =>
            {
                entity.HasKey(e => e.SetId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_routesetting");

                entity.Property(e => e.SetId).HasColumnType("int(11)");

                entity.Property(e => e.LocusId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Orders).HasColumnType("int(11)");

                entity.Property(e => e.RouteId).HasColumnType("int(11)");

                entity.Property(e => e.StayTime).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwPatrolStatus>(entity =>
            {
                entity.ToTable("gw_patrol_status");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<GwPtzcontrol>(entity =>
            {
                entity.ToTable("gw_ptzcontrol");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChannelNum)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ControlEquip)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EquipNum)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ptzbottom)
                    .HasColumnName("PTZBottom")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ptzleft)
                    .HasColumnName("PTZLeft")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ptzpreset)
                    .HasColumnName("PTZPreset")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PtzpresetValue)
                    .HasColumnName("PTZPresetValue")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ptzright)
                    .HasColumnName("PTZRight")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ptztop)
                    .HasColumnName("PTZTop")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PtzzoomD)
                    .HasColumnName("PTZZoomD")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PtzzoomP)
                    .HasColumnName("PTZZoomP")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GwQrCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_qr_check");

                entity.Property(e => e.Actionid)
                    .IsRequired()
                    .HasColumnName("actionid")
                    .HasMaxLength(255);

                entity.Property(e => e.Qrcreatname)
                    .HasColumnName("qrcreatname")
                    .HasMaxLength(255);

                entity.Property(e => e.Qrtype)
                    .HasColumnName("qrtype")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Vistorname)
                    .HasColumnName("vistorname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwQrRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_qr_record");

                entity.Property(e => e.Actionid)
                    .IsRequired()
                    .HasColumnName("actionid")
                    .HasMaxLength(255);

                entity.Property(e => e.Qrcreatname)
                    .HasColumnName("qrcreatname")
                    .HasMaxLength(255);

                entity.Property(e => e.Qrtype)
                    .HasColumnName("qrtype")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Vistorname)
                    .HasColumnName("vistorname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwSpArea>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_sp_area");

                entity.Property(e => e.AreaId)
                    .HasColumnName("AreaID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AreaDvrChannel)
                    .HasColumnName("AreaDvr_Channel")
                    .HasColumnType("longtext");

                entity.Property(e => e.AreaName).HasColumnType("longtext");
            });

            modelBuilder.Entity<GwSpChannel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_sp_channel");

                entity.Property(e => e.ChannelId)
                    .HasColumnName("ChannelID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChannelName).HasColumnType("longtext");

                entity.Property(e => e.CommunicationParam)
                    .HasColumnName("communication_param")
                    .HasMaxLength(255);

                entity.Property(e => e.CompactName).HasMaxLength(255);

                entity.Property(e => e.DvrId)
                    .HasColumnName("DvrID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EquipAddr)
                    .HasColumnName("equip_addr")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsCound)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");
            });

            modelBuilder.Entity<GwSpDvrinfo>(entity =>
            {
                entity.HasKey(e => e.DvrId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_sp_dvrinfo");

                entity.Property(e => e.DvrId)
                    .HasColumnName("DvrID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChannelNum).HasColumnType("int(11)");

                entity.Property(e => e.CloudMultiple)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CloudSpeed)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Describe).HasMaxLength(255);

                entity.Property(e => e.DvrName).HasMaxLength(255);

                entity.Property(e => e.DvrType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasColumnType("longtext");

                entity.Property(e => e.PassWord).HasColumnType("longtext");

                entity.Property(e => e.Port).HasColumnType("int(11)");

                entity.Property(e => e.UserName).HasColumnType("longtext");
            });

            modelBuilder.Entity<GwSpDvrtype>(entity =>
            {
                entity.HasKey(e => e.DvrTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_sp_dvrtype");

                entity.Property(e => e.DvrTypeId)
                    .HasColumnName("DvrTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClassName).HasMaxLength(50);

                entity.Property(e => e.DvrTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<GwSpGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_sp_group");

                entity.Property(e => e.GroupList).HasMaxLength(255);

                entity.Property(e => e.GroupName).HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwSpMethod>(entity =>
            {
                entity.HasKey(e => e.MethodId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_sp_method");

                entity.Property(e => e.MethodId)
                    .HasColumnName("MethodID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClassName).HasMaxLength(50);

                entity.Property(e => e.MethodName).HasMaxLength(50);

                entity.Property(e => e.ModulId)
                    .HasColumnName("ModulID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GwSpModul>(entity =>
            {
                entity.HasKey(e => e.ModulId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_sp_modul");

                entity.Property(e => e.ModulId)
                    .HasColumnName("ModulID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClassName).HasMaxLength(50);

                entity.Property(e => e.DvrTypeId)
                    .HasColumnName("DvrTypeID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModulName).HasMaxLength(50);
            });

            modelBuilder.Entity<GwUnityMarkview>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_unity_markview");

                entity.Property(e => e.ResId)
                    .HasColumnName("ResID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rotation).HasMaxLength(255);

                entity.Property(e => e.SceneId)
                    .HasColumnName("SceneID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Vposition)
                    .HasColumnName("VPosition")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwUnityModel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_unity_model");

                entity.Property(e => e.BestViewPos).HasMaxLength(255);

                entity.Property(e => e.BestViewRot).HasMaxLength(255);

                entity.Property(e => e.ClickCmd)
                    .HasColumnName("ClickCMD")
                    .HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ResId).HasColumnName("ResID");

                entity.Property(e => e.Rotation).HasMaxLength(255);

                entity.Property(e => e.Scale).HasMaxLength(255);

                entity.Property(e => e.SceneId).HasColumnName("SceneID");

                entity.Property(e => e.ToolTip).HasMaxLength(255);

                entity.Property(e => e.ValueCmd)
                    .HasColumnName("ValueCMD")
                    .HasMaxLength(255);

                entity.Property(e => e.Vposition)
                    .HasColumnName("VPosition")
                    .HasMaxLength(255);

                entity.Property(e => e.WarCmd)
                    .HasColumnName("WarCMD")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwUnityParade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_unity_parade");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParadeSpeed).HasDefaultValueSql("'0'");

                entity.Property(e => e.Rotation).HasMaxLength(255);

                entity.Property(e => e.SceneId)
                    .HasColumnName("SceneID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Vindex)
                    .HasColumnName("VIndex")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Vposition)
                    .HasColumnName("VPosition")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GwUnityResource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_unity_resource");

                entity.Property(e => e.BestViewPos).HasMaxLength(255);

                entity.Property(e => e.BestViewRot).HasMaxLength(255);

                entity.Property(e => e.DevIconColor).HasMaxLength(255);

                entity.Property(e => e.DevIconName).HasMaxLength(255);

                entity.Property(e => e.DevName).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TexName).HasMaxLength(255);
            });

            modelBuilder.Entity<GwUnityScene>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_unity_scene");

                entity.Property(e => e.BundleName).HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InitPos).HasMaxLength(255);

                entity.Property(e => e.InitRot).HasMaxLength(255);

                entity.Property(e => e.MinMapSize).HasMaxLength(255);

                entity.Property(e => e.MoveSpeed).HasDefaultValueSql("'0'");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OverLookPos).HasMaxLength(255);

                entity.Property(e => e.OverLookRot).HasMaxLength(255);

                entity.Property(e => e.OverLookSize).HasDefaultValueSql("'0'");

                entity.Property(e => e.ParadeId)
                    .HasColumnName("ParadeID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ParadeSpeed).HasDefaultValueSql("'0'");

                entity.Property(e => e.PymoveSpeed)
                    .HasColumnName("PYMoveSpeed")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PyscaleSpeed)
                    .HasColumnName("PYScaleSpeed")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShowName).HasMaxLength(255);

                entity.Property(e => e.SkyBox).HasMaxLength(255);

                entity.Property(e => e.Version).HasMaxLength(255);

                entity.Property(e => e.WalkInitPos).HasMaxLength(255);

                entity.Property(e => e.WalkInitRot).HasMaxLength(255);

                entity.Property(e => e.XrotSpeed)
                    .HasColumnName("XRotSpeed")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.YrotSpeed)
                    .HasColumnName("YRotSpeed")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GwVideoCyclechannel>(entity =>
            {
                entity.ToTable("gw_video_cyclechannel");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Channels).HasColumnType("longtext");

                entity.Property(e => e.Interval)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GwVideoPreset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_video_preset");

                entity.Property(e => e.ChannelId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EquipId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<GwVideoinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_videoinfo");

                entity.Property(e => e.Action).HasMaxLength(255);

                entity.Property(e => e.ChannelName).HasMaxLength(255);

                entity.Property(e => e.ChannelNum).HasMaxLength(255);

                entity.Property(e => e.ChannelType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ControlEquip)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EquipNum)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Path).HasColumnType("longtext");

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.Rtsp)
                    .HasColumnName("RTSP")
                    .HasMaxLength(255);

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StreamType).HasMaxLength(255);
            });

            modelBuilder.Entity<Gwaddinmodule>(entity =>
            {
                entity.ToTable("gwaddinmodule");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClassName).HasMaxLength(255);

                entity.Property(e => e.HelpPath).HasMaxLength(255);

                entity.Property(e => e.MultiScreens).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.WebPage)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Gwassetinfo>(entity =>
            {
                entity.HasKey(e => e.AssetId)
                    .HasName("PRIMARY");

                entity.ToTable("gwassetinfo");

                entity.Property(e => e.AssetId)
                    .HasColumnName("asset_id")
                    .HasMaxLength(64);

                entity.Property(e => e.EquipDetail)
                    .HasColumnName("equip_detail")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipImage)
                    .HasColumnName("equip_image")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipLocation)
                    .HasColumnName("equip_location")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipName)
                    .HasColumnName("equip_name")
                    .HasMaxLength(64);

                entity.Property(e => e.EquipType)
                    .HasColumnName("equip_type")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Gwbuttonproperty>(entity =>
            {
                entity.HasKey(e => e.Gwkey)
                    .HasName("PRIMARY");

                entity.ToTable("gwbuttonproperty");

                entity.Property(e => e.Gwkey)
                    .HasColumnName("gwkey")
                    .HasMaxLength(255);

                entity.Property(e => e.Gwcommand)
                    .HasColumnName("gwcommand")
                    .HasColumnType("longtext");

                entity.Property(e => e.Gwdatasouce)
                    .HasColumnName("gwdatasouce")
                    .HasMaxLength(255);

                entity.Property(e => e.Gwremark)
                    .HasColumnName("gwremark")
                    .HasColumnType("longtext");

                entity.Property(e => e.Gwtooltip)
                    .HasColumnName("gwtooltip")
                    .HasMaxLength(255);

                entity.Property(e => e.Gwtype)
                    .HasColumnName("gwtype")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Gwdatarecorditems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwdatarecorditems");

                entity.Property(e => e.DataName)
                    .HasColumnName("data_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(1);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50);

                entity.Property(e => e.YcyxNo)
                    .HasColumnName("ycyx_no")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Gwdatarecordresult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwdatarecordresult");

                entity.Property(e => e.DataName)
                    .HasColumnName("data_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasColumnName("data_type")
                    .HasMaxLength(1);

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.YcyxNo)
                    .HasColumnName("ycyx_no")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Gwdelayaction>(entity =>
            {
                entity.ToTable("gwdelayaction");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GwDelayNum)
                    .HasColumnName("GW_DelayNum")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GwEquipNo)
                    .HasColumnName("GW_Equip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GwSetNo)
                    .HasColumnName("GW_Set_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GwSource)
                    .HasColumnName("GW_Source")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GwStaN)
                    .HasColumnName("GW_Sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GwState)
                    .HasColumnName("GW_State")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GwUserNm)
                    .HasColumnName("GW_UserNm")
                    .HasMaxLength(255);

                entity.Property(e => e.GwValue)
                    .HasColumnName("GW_Value")
                    .HasMaxLength(255);

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");
            });

            modelBuilder.Entity<Gwelevatormaintain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwelevatormaintain");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Certificate).HasMaxLength(255);

                entity.Property(e => e.CertificateLevel).HasMaxLength(255);

                entity.Property(e => e.EligibilityScope).HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255);

                entity.Property(e => e.MaintainCode).HasMaxLength(255);

                entity.Property(e => e.MaintainName).HasMaxLength(255);

                entity.Property(e => e.MaintainPosition).HasMaxLength(255);

                entity.Property(e => e.VerificationTime).HasMaxLength(255);
            });

            modelBuilder.Entity<Gwelevatormarker>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ElevatorNum })
                    .HasName("PRIMARY");

                entity.ToTable("gwelevatormarker");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ElevatorNum).HasMaxLength(50);

                entity.Property(e => e.ElevatorInfo).HasColumnType("longtext");

                entity.Property(e => e.ElevatorPlace).HasColumnType("longtext");

                entity.Property(e => e.ElevatorPosition).HasMaxLength(50);

                entity.Property(e => e.ElevatorState).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Gwequippages>(entity =>
            {
                entity.ToTable("gwequippages");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HelpPath).HasMaxLength(255);

                entity.Property(e => e.MultiScreens).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Pages).HasColumnType("longtext");

                entity.Property(e => e.WebPage)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Gwequiptreegroup>(entity =>
            {
                entity.ToTable("gwequiptreegroup");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Gwequiptreeitem>(entity =>
            {
                entity.HasKey(e => new { e.EquipId, e.GroupId })
                    .HasName("PRIMARY");

                entity.ToTable("gwequiptreeitem");

                entity.Property(e => e.EquipId)
                    .HasColumnName("EquipID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Gwexproc>(entity =>
            {
                entity.HasKey(e => e.ProcCode)
                    .HasName("PRIMARY");

                entity.ToTable("gwexproc");

                entity.Property(e => e.ProcCode)
                    .HasColumnName("Proc_Code")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcModule)
                    .HasColumnName("Proc_Module")
                    .HasMaxLength(255);

                entity.Property(e => e.ProcName)
                    .HasColumnName("Proc_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ProcParm)
                    .HasColumnName("Proc_parm")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Gwexproccmd>(entity =>
            {
                entity.HasKey(e => new { e.ProcCode, e.CmdNm })
                    .HasName("PRIMARY");

                entity.ToTable("gwexproccmd");

                entity.Property(e => e.ProcCode)
                    .HasColumnName("proc_code")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CmdNm)
                    .HasColumnName("cmd_nm")
                    .HasMaxLength(255);

                entity.Property(e => e.MainInstruction)
                    .HasColumnName("main_instruction")
                    .HasMaxLength(255);

                entity.Property(e => e.MinorInstruction)
                    .HasColumnName("minor_instruction")
                    .HasMaxLength(255);

                entity.Property(e => e.Record)
                    .IsRequired()
                    .HasColumnName("record")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Gwmaintainer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwmaintainer");

                entity.Property(e => e.Company).HasColumnType("longtext");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaintainerInfo).HasColumnType("longtext");

                entity.Property(e => e.MaintainerName).HasColumnType("longtext");

                entity.Property(e => e.MaintainerPosition).HasColumnType("longtext");

                entity.Property(e => e.Phone).HasColumnType("longtext");
            });

            modelBuilder.Entity<Gwmapmarker>(entity =>
            {
                entity.HasKey(e => e.MarkerId)
                    .HasName("PRIMARY");

                entity.ToTable("gwmapmarker");

                entity.Property(e => e.MarkerId).HasColumnType("int(11)");

                entity.Property(e => e.AssemblyName).HasColumnType("longtext");

                entity.Property(e => e.ClassFullName).HasColumnType("longtext");

                entity.Property(e => e.Data).HasColumnType("longtext");

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasColumnName("GroupID")
                    .HasMaxLength(255);

                entity.Property(e => e.MarkerName).HasColumnType("longtext");

                entity.Property(e => e.MaxZoom)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MinZoom)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Offset).HasMaxLength(255);

                entity.Property(e => e.Path).HasColumnType("longtext");

                entity.Property(e => e.Position).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.Xmlns)
                    .HasColumnName("xmlns")
                    .HasColumnType("longtext");

                entity.Property(e => e.ZIndex)
                    .HasColumnName("zIndex")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Gwnavigationproperty>(entity =>
            {
                entity.ToTable("gwnavigationproperty");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlarmImage)
                    .IsRequired()
                    .HasColumnName("alarm_image")
                    .HasColumnType("longtext");

                entity.Property(e => e.Enable)
                    .HasColumnName("enable")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuanlianComb)
                    .HasColumnName("guanlian_comb")
                    .HasColumnType("longtext");

                entity.Property(e => e.NavigateType)
                    .IsRequired()
                    .HasColumnName("navigate_type")
                    .HasMaxLength(255);

                entity.Property(e => e.NormalImage)
                    .IsRequired()
                    .HasColumnName("normal_image")
                    .HasMaxLength(255);

                entity.Property(e => e.PageComb)
                    .HasColumnName("page_comb")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<Gwplan>(entity =>
            {
                entity.HasKey(e => e.PlanNo)
                    .HasName("PRIMARY");

                entity.ToTable("gwplan");

                entity.Property(e => e.PlanNo).HasMaxLength(255);

                entity.Property(e => e.Content).HasColumnType("longtext");

                entity.Property(e => e.IsModel).HasColumnType("int(11)");

                entity.Property(e => e.LastEditor).HasMaxLength(255);

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");
            });

            modelBuilder.Entity<Gwplanrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwplanrecord");

                entity.Property(e => e.Content).HasColumnType("longtext");

                entity.Property(e => e.Editor).HasMaxLength(255);

                entity.Property(e => e.PlanNo).HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);
            });

            modelBuilder.Entity<Gwproccycletable>(entity =>
            {
                entity.HasKey(e => new { e.TableId, e.DoOrder })
                    .HasName("PRIMARY");

                entity.ToTable("gwproccycletable");

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DoOrder).HasColumnType("int(11)");

                entity.Property(e => e.CmdNm)
                    .HasColumnName("cmd_nm")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcCode)
                    .HasColumnName("proc_code")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.SetNo)
                    .HasColumnName("set_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SleepTime).HasColumnType("int(11)");

                entity.Property(e => e.SleepUnit).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Gwproccycletlist>(entity =>
            {
                entity.HasKey(e => e.TableId)
                    .HasName("PRIMARY");

                entity.ToTable("gwproccycletlist");

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CycleMustFinish).HasColumnType("int(11)");

                entity.Property(e => e.MaxCycleNum)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reference).HasColumnType("longtext");

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'new task'");

                entity.Property(e => e.ZhenDianDo).HasColumnType("int(11)");

                entity.Property(e => e.ZhidingDo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Gwprocspectable>(entity =>
            {
                entity.ToTable("gwprocspectable");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateName).HasMaxLength(255);

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<Gwproctimeeqptable>(entity =>
            {
                entity.ToTable("gwproctimeeqptable");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SetNo)
                    .HasColumnName("set_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Gwproctimesystable>(entity =>
            {
                entity.ToTable("gwproctimesystable");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CmdNm)
                    .HasColumnName("cmd_nm")
                    .HasMaxLength(255);

                entity.Property(e => e.ProcCode)
                    .HasColumnName("proc_code")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Gwproctimetlist>(entity =>
            {
                entity.HasKey(e => e.TableId)
                    .HasName("PRIMARY");

                entity.ToTable("gwproctimetlist");

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.Reference).HasColumnType("longtext");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'new schedule'");
            });

            modelBuilder.Entity<Gwprocweektable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwprocweektable");

                entity.Property(e => e.Fri).HasColumnType("longtext");

                entity.Property(e => e.Mon).HasColumnType("longtext");

                entity.Property(e => e.Sat).HasColumnType("longtext");

                entity.Property(e => e.Sun).HasColumnType("longtext");

                entity.Property(e => e.Thurs).HasColumnType("longtext");

                entity.Property(e => e.Tues).HasColumnType("longtext");

                entity.Property(e => e.Wed).HasColumnType("longtext");
            });

            modelBuilder.Entity<Gwreportinfo>(entity =>
            {
                entity.ToTable("gwreportinfo");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Describe).HasMaxLength(255);

                entity.Property(e => e.DllName).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.ReportName).HasMaxLength(255);
            });

            modelBuilder.Entity<Gwrole>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("gwrole");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.BrowseEquips).HasColumnType("longtext");

                entity.Property(e => e.BrowsePages).HasColumnType("longtext");

                entity.Property(e => e.ControlEquips).HasColumnType("longtext");

                entity.Property(e => e.ControlEquipsUnit)
                    .HasColumnName("ControlEquips_Unit")
                    .HasColumnType("longtext");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("longtext");

                entity.Property(e => e.SpecialBrowseEquip).HasColumnType("longtext");

                entity.Property(e => e.SystemModule).HasColumnType("longtext");
            });

            modelBuilder.Entity<Gwsnapshotconfig>(entity =>
            {
                entity.ToTable("gwsnapshotconfig");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IconRes).HasMaxLength(255);

                entity.Property(e => e.IsShow).HasColumnType("int(11)");

                entity.Property(e => e.MaxCount).HasColumnType("int(11)");

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.SnapshotLevelMax).HasColumnType("int(11)");

                entity.Property(e => e.SnapshotLevelMin).HasColumnType("int(11)");

                entity.Property(e => e.SnapshotName).HasMaxLength(128);
            });

            modelBuilder.Entity<Gwuser>(entity =>
            {
                entity.ToTable("gwuser");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoInspectionPages).HasColumnType("longtext");

                entity.Property(e => e.ControlLevel).HasMaxLength(255);

                entity.Property(e => e.HomePages).HasColumnType("longtext");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.OppoUser)
                    .HasColumnName("oppoUser")
                    .HasMaxLength(255);

                entity.Property(e => e.Password).HasColumnType("longtext");

                entity.Property(e => e.Remark).HasColumnType("longtext");

                entity.Property(e => e.Reserve1).HasMaxLength(255);

                entity.Property(e => e.Reserve2).HasMaxLength(255);

                entity.Property(e => e.Reserve3).HasMaxLength(255);

                entity.Property(e => e.Roles).HasColumnType("longtext");
            });

            modelBuilder.Entity<Gwwebmapmarker>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwwebmapmarker");

                entity.Property(e => e.BindCmd).HasMaxLength(50);

                entity.Property(e => e.Data).HasColumnType("longtext");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.EnableRotation).HasColumnType("int(11)");

                entity.Property(e => e.MarkerId).HasColumnType("int(11)");

                entity.Property(e => e.MarkerName).HasColumnType("longtext");

                entity.Property(e => e.MarkerType).HasColumnType("decimal(18,0)");

                entity.Property(e => e.OffSet)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProjectName).HasMaxLength(50);

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.Template).HasMaxLength(50);
            });

            modelBuilder.Entity<Gwzichanrecord>(entity =>
            {
                entity.ToTable("gwzichanrecord");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemAddMan).HasMaxLength(255);

                entity.Property(e => e.Pictures).HasColumnType("longtext");

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.WeiHuName).HasMaxLength(255);

                entity.Property(e => e.WeiHuRecord).HasColumnType("longtext");

                entity.Property(e => e.ZiChanId)
                    .IsRequired()
                    .HasColumnName("ZiChanID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Gwzichantable>(entity =>
            {
                entity.HasKey(e => e.ZiChanId)
                    .HasName("PRIMARY");

                entity.ToTable("gwzichantable");

                entity.Property(e => e.ZiChanId)
                    .HasColumnName("ZiChanID")
                    .HasMaxLength(255);

                entity.Property(e => e.ChangJia).HasMaxLength(255);

                entity.Property(e => e.LastEditMan).HasMaxLength(255);

                entity.Property(e => e.LianxiMail).HasMaxLength(255);

                entity.Property(e => e.LianxiRen).HasMaxLength(255);

                entity.Property(e => e.LianxiTel).HasMaxLength(255);

                entity.Property(e => e.RelatedPic)
                    .HasColumnName("related_pic")
                    .HasMaxLength(255);

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.WeiHuCycle).HasColumnType("int(11)");

                entity.Property(e => e.ZiChanImage).HasMaxLength(255);

                entity.Property(e => e.ZiChanName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ZiChanSite).HasMaxLength(255);

                entity.Property(e => e.ZiChanType).HasMaxLength(255);
            });

            modelBuilder.Entity<Gwzichantableexcolumn>(entity =>
            {
                entity.HasKey(e => e.ColumnNo)
                    .HasName("PRIMARY");

                entity.ToTable("gwzichantableexcolumn");

                entity.Property(e => e.ColumnNo).HasMaxLength(255);

                entity.Property(e => e.ColumnName).HasMaxLength(255);
            });

            modelBuilder.Entity<Hsncardno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hsncardno");

                entity.Property(e => e.CardCode)
                    .IsRequired()
                    .HasColumnName("Card_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasColumnName("Card_No")
                    .HasMaxLength(6);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<IotDevice>(entity =>
            {
                entity.HasKey(e => e.DeviceId)
                    .HasName("PRIMARY");

                entity.ToTable("iot_device");

                entity.Property(e => e.DeviceId)
                    .HasColumnName("deviceId")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaName)
                    .HasColumnName("areaName")
                    .HasMaxLength(50);

                entity.Property(e => e.BridgeId)
                    .HasColumnName("bridgeId")
                    .HasMaxLength(50);

                entity.Property(e => e.BuildName)
                    .HasColumnName("buildName")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DeviceType)
                    .HasColumnName("deviceType")
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceTypeId)
                    .HasColumnName("deviceTypeId")
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceTypeName)
                    .HasColumnName("deviceTypeName")
                    .HasMaxLength(50);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equipNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FwVersion)
                    .HasColumnName("fwVersion")
                    .HasMaxLength(50);

                entity.Property(e => e.GatewayId)
                    .HasColumnName("gatewayId")
                    .HasMaxLength(50);

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasMaxLength(255);

                entity.Property(e => e.HwVersion)
                    .HasColumnName("hwVersion")
                    .HasMaxLength(50);

                entity.Property(e => e.Imsi)
                    .HasColumnName("imsi")
                    .HasMaxLength(50);

                entity.Property(e => e.Lnglat)
                    .HasColumnName("lnglat")
                    .HasMaxLength(255);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(255);

                entity.Property(e => e.Mac)
                    .HasColumnName("mac")
                    .HasMaxLength(50);

                entity.Property(e => e.ManufactureId)
                    .HasColumnName("manufactureId")
                    .HasMaxLength(50);

                entity.Property(e => e.ManufactureName)
                    .HasColumnName("manufactureName")
                    .HasMaxLength(255);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(50);

                entity.Property(e => e.NodeId)
                    .HasColumnName("nodeId")
                    .HasMaxLength(50);

                entity.Property(e => e.NodeType)
                    .HasColumnName("nodeType")
                    .HasMaxLength(50);

                entity.Property(e => e.ProtocolType)
                    .HasColumnName("protocolType")
                    .HasMaxLength(50);

                entity.Property(e => e.RadiusIp)
                    .HasColumnName("radiusIp")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportData)
                    .HasColumnName("reportData")
                    .HasColumnType("longtext");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serialNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.SigVersion)
                    .HasColumnName("sigVersion")
                    .HasMaxLength(50);

                entity.Property(e => e.SwVersion)
                    .HasColumnName("swVersion")
                    .HasMaxLength(50);

                entity.Property(e => e.SystemType)
                    .HasColumnName("systemType")
                    .HasMaxLength(50);

                entity.Property(e => e.SystemTypeName)
                    .HasColumnName("systemTypeName")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitName)
                    .HasColumnName("unitName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IotDeviceservice>(entity =>
            {
                entity.HasKey(e => new { e.ServiceId, e.DeviceId })
                    .HasName("PRIMARY");

                entity.ToTable("iot_deviceservice");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("serviceId")
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceId)
                    .HasColumnName("deviceId")
                    .HasMaxLength(50);

                entity.Property(e => e.CurrentDate)
                    .HasColumnName("currentDate")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("longtext");

                entity.Property(e => e.ReportLimit).HasColumnName("reportLimit");

                entity.Property(e => e.ReportMode)
                    .HasColumnName("reportMode")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportTimespan)
                    .HasColumnName("reportTimespan")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceModel)
                    .HasColumnName("serviceModel")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceModelId)
                    .HasColumnName("serviceModelId")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceModelName)
                    .HasColumnName("serviceModelName")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceOption)
                    .HasColumnName("serviceOption")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceType)
                    .HasColumnName("serviceType")
                    .HasMaxLength(50);

                entity.Property(e => e.YcYxSetNo)
                    .HasColumnName("ycYxSetNo")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<IotDeviceservicemodel>(entity =>
            {
                entity.HasKey(e => e.ServiceModelId)
                    .HasName("PRIMARY");

                entity.ToTable("iot_deviceservicemodel");

                entity.Property(e => e.ServiceModelId)
                    .HasColumnName("serviceModelId")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceModelName)
                    .HasColumnName("serviceModelName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IotDevicetype>(entity =>
            {
                entity.HasKey(e => e.DeviceTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("iot_devicetype");

                entity.Property(e => e.DeviceTypeId)
                    .HasColumnName("deviceTypeId")
                    .HasMaxLength(50);

                entity.Property(e => e.DevuceTypeName)
                    .HasColumnName("devuceTypeName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<KingkangCardatdoor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kingkang_cardatdoor");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<KingkangDept>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kingkang_dept");

                entity.Property(e => e.DeptId)
                    .HasColumnName("dept_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeptNm)
                    .IsRequired()
                    .HasColumnName("dept_nm")
                    .HasMaxLength(24);
            });

            modelBuilder.Entity<KingkangMember>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PRIMARY");

                entity.ToTable("kingkang_member");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasMaxLength(32);

                entity.Property(e => e.CardCode)
                    .HasColumnName("card_code")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CardSection)
                    .HasColumnName("card_section")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DeptId)
                    .HasColumnName("dept_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(8);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<KingkangTmg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kingkang_tmg");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IDXKingKang_TmG_group_id");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupNm)
                    .IsRequired()
                    .HasColumnName("group_nm")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Matafun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("matafun");

                entity.Property(e => e.Mainfunid)
                    .HasColumnName("mainfunid")
                    .HasMaxLength(2);

                entity.Property(e => e.Mainfunnm)
                    .HasColumnName("mainfunnm")
                    .HasMaxLength(10);

                entity.Property(e => e.Matatype)
                    .HasColumnName("matatype")
                    .HasMaxLength(5);

                entity.Property(e => e.Minfunid)
                    .HasColumnName("minfunid")
                    .HasMaxLength(2);

                entity.Property(e => e.Minfunnm)
                    .HasColumnName("minfunnm")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Mataobj>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mataobj");

                entity.Property(e => e.Equiptype)
                    .HasColumnName("equiptype")
                    .HasMaxLength(20);

                entity.Property(e => e.Matatype)
                    .HasColumnName("matatype")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Matasubtype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("matasubtype");

                entity.Property(e => e.Equipsubtype)
                    .HasColumnName("equipsubtype")
                    .HasMaxLength(32);

                entity.Property(e => e.Equiptype)
                    .HasColumnName("equiptype")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Matasymb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("matasymb");

                entity.Property(e => e.Mataarray)
                    .HasColumnName("MATAARRAY")
                    .HasMaxLength(4);

                entity.Property(e => e.Mataname)
                    .HasColumnName("MATANAME")
                    .HasMaxLength(20);

                entity.Property(e => e.Matapic)
                    .HasColumnName("MATAPIC")
                    .HasMaxLength(12);

                entity.Property(e => e.Matatype)
                    .HasColumnName("MATATYPE")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Nsladmission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nsladmission");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasColumnName("Card_No")
                    .HasMaxLength(4);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Reader)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Nslcardno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nslcardno");

                entity.Property(e => e.CardCode)
                    .IsRequired()
                    .HasColumnName("Card_Code")
                    .HasMaxLength(8);

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasColumnName("Card_No")
                    .HasMaxLength(4);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name).HasMaxLength(32);

                entity.Property(e => e.PinCode)
                    .HasColumnName("Pin_code")
                    .HasMaxLength(4);

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WeekGroup)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Nsldateg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nsldateg");

                entity.Property(e => e.AdmitBgn1)
                    .IsRequired()
                    .HasColumnName("Admit_Bgn1")
                    .HasMaxLength(4);

                entity.Property(e => e.AdmitBgn2)
                    .HasColumnName("Admit_Bgn2")
                    .HasMaxLength(4);

                entity.Property(e => e.AdmitEnd1)
                    .HasColumnName("Admit_End1")
                    .HasMaxLength(4);

                entity.Property(e => e.AdmitEnd2)
                    .HasColumnName("Admit_End2")
                    .HasMaxLength(4);

                entity.Property(e => e.TimeGroup)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Nslweekg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nslweekg");

                entity.Property(e => e.Fri)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mon)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sat)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sun)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Thu)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tue)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Wed)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WeekGroup).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Operationequip>(entity =>
            {
                entity.HasKey(e => new { e.StaNm, e.EquipId })
                    .HasName("PRIMARY");

                entity.ToTable("operationequip");

                entity.Property(e => e.StaNm)
                    .HasColumnName("sta_nm")
                    .HasMaxLength(10);

                entity.Property(e => e.EquipId)
                    .HasColumnName("equip_id")
                    .HasMaxLength(16);

                entity.Property(e => e.EquipNm)
                    .HasColumnName("equip_nm")
                    .HasMaxLength(64);

                entity.Property(e => e.Equiptype)
                    .IsRequired()
                    .HasColumnName("equiptype")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Operationlog>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("PRIMARY");

                entity.ToTable("operationlog");

                entity.Property(e => e.OperationId)
                    .HasColumnName("OPERATION_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperationPersion)
                    .HasColumnName("OPERATION_PERSION")
                    .HasMaxLength(16);

                entity.Property(e => e.OperationTitle)
                    .HasColumnName("OPERATION_TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.StaNm)
                    .IsRequired()
                    .HasColumnName("sta_nm")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Operationrec>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("PRIMARY");

                entity.ToTable("operationrec");

                entity.Property(e => e.OperationId)
                    .HasColumnName("OPERATION_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperationComment)
                    .HasColumnName("OPERATION_COMMENT")
                    .HasMaxLength(255);

                entity.Property(e => e.OperationPersion)
                    .HasColumnName("OPERATION_PERSION")
                    .HasMaxLength(16);

                entity.Property(e => e.OperationProcedure)
                    .HasColumnName("OPERATION_PROCEDURE")
                    .HasColumnType("longblob");

                entity.Property(e => e.OperationTitle)
                    .IsRequired()
                    .HasColumnName("OPERATION_TITLE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PersonnelFaceimage>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PRIMARY");

                entity.ToTable("personnel.faceimage");

                entity.Property(e => e.PkId).HasColumnType("int(11)");

                entity.Property(e => e.AlarmId)
                    .HasColumnName("alarmId")
                    .HasMaxLength(100);

                entity.Property(e => e.FlagId)
                    .HasColumnName("flagId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HashId).HasColumnType("bigint(20)");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasMaxLength(100);

                entity.Property(e => e.ImageUri)
                    .HasColumnName("imageUri")
                    .HasMaxLength(200);

                entity.Property(e => e.Race)
                    .HasColumnName("race")
                    .HasMaxLength(100);

                entity.Property(e => e.SourceId)
                    .HasColumnName("sourceId")
                    .HasMaxLength(100);

                entity.Property(e => e.SourceType)
                    .HasColumnName("sourceType")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Rawequip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rawequip");

                entity.Property(e => e.AccCyc)
                    .HasColumnName("acc_cyc")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AlarmScheme)
                    .HasColumnName("alarm_scheme")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attrib)
                    .HasColumnName("attrib")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CommunicationDrv)
                    .HasColumnName("communication_drv")
                    .HasMaxLength(16);

                entity.Property(e => e.CommunicationParam)
                    .HasColumnName("communication_param")
                    .HasMaxLength(64);

                entity.Property(e => e.CommunicationTimeParam)
                    .HasColumnName("communication_time_param")
                    .HasMaxLength(32);

                entity.Property(e => e.CommunicatonType)
                    .HasColumnName("communicaton_type")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Contacted)
                    .HasColumnName("contacted")
                    .HasMaxLength(64);

                entity.Property(e => e.EquipAddr)
                    .HasColumnName("equip_addr")
                    .HasMaxLength(128);

                entity.Property(e => e.EquipDetail)
                    .HasColumnName("equip_detail")
                    .HasMaxLength(255);

                entity.Property(e => e.EventWav)
                    .HasColumnName("event_wav")
                    .HasMaxLength(15);

                entity.Property(e => e.LocalAddr)
                    .HasColumnName("local_addr")
                    .HasMaxLength(64);

                entity.Property(e => e.OutOfContact)
                    .IsRequired()
                    .HasColumnName("out_of_contact")
                    .HasMaxLength(64);

                entity.Property(e => e.ProcAdvice)
                    .HasColumnName("proc_advice")
                    .HasMaxLength(254);

                entity.Property(e => e.RawEquipNm)
                    .HasColumnName("raw_equip_nm")
                    .HasMaxLength(64);

                entity.Property(e => e.RawEquipNo)
                    .HasColumnName("raw_equip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RelatedPic)
                    .HasColumnName("related_pic")
                    .HasMaxLength(16);

                entity.Property(e => e.Tabname)
                    .HasColumnName("tabname")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Rawycp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rawycp");

                entity.Property(e => e.AlarmAcceptableTime)
                    .HasColumnName("alarm_acceptable_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmRepeatTime)
                    .HasColumnName("alarm_repeat_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmScheme)
                    .HasColumnName("alarm_scheme")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CurveRcd)
                    .IsRequired()
                    .HasColumnName("curve_rcd")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LvlLevel)
                    .HasColumnName("lvl_level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MainInstruction)
                    .HasColumnName("main_instruction")
                    .HasMaxLength(128);

                entity.Property(e => e.Mapping)
                    .IsRequired()
                    .HasColumnName("mapping")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.MinorInstruction)
                    .HasColumnName("minor_instruction")
                    .HasMaxLength(128);

                entity.Property(e => e.OutmaxEvt)
                    .HasColumnName("outmax_evt")
                    .HasMaxLength(64);

                entity.Property(e => e.OutminEvt)
                    .HasColumnName("outmin_evt")
                    .HasMaxLength(64);

                entity.Property(e => e.PhysicMax)
                    .HasColumnName("physic_max")
                    .HasDefaultValueSql("'1000'");

                entity.Property(e => e.PhysicMin)
                    .HasColumnName("physic_min")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProcAdvice)
                    .HasColumnName("proc_advice")
                    .HasMaxLength(254);

                entity.Property(e => e.RawEquipNo)
                    .HasColumnName("raw_equip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RawYcNm)
                    .HasColumnName("raw_yc_nm")
                    .HasMaxLength(64);

                entity.Property(e => e.RawYcNo)
                    .HasColumnName("raw_yc_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RelatedPic)
                    .HasColumnName("related_pic")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.RestoreAcceptableTime)
                    .HasColumnName("restore_acceptable_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RestoreMax).HasColumnName("restore_max");

                entity.Property(e => e.RestoreMin).HasColumnName("restore_min");

                entity.Property(e => e.ValMax).HasColumnName("val_max");

                entity.Property(e => e.ValMin).HasColumnName("val_min");

                entity.Property(e => e.ValTrait)
                    .HasColumnName("val_trait")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WaveFile)
                    .HasColumnName("wave_file")
                    .HasMaxLength(24);

                entity.Property(e => e.YcMax)
                    .HasColumnName("yc_max")
                    .HasDefaultValueSql("'1000'");

                entity.Property(e => e.YcMin)
                    .HasColumnName("yc_min")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Rawyxp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rawyxp");

                entity.Property(e => e.AlarmAcceptableTime)
                    .HasColumnName("alarm_acceptable_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmRepeatTime)
                    .HasColumnName("alarm_repeat_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmScheme)
                    .HasColumnName("alarm_scheme")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Evt01)
                    .HasColumnName("evt_01")
                    .HasMaxLength(64);

                entity.Property(e => e.Evt10)
                    .HasColumnName("evt_10")
                    .HasMaxLength(64);

                entity.Property(e => e.Initval)
                    .HasColumnName("initval")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Inversion)
                    .IsRequired()
                    .HasColumnName("inversion")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LevelD)
                    .HasColumnName("level_d")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LevelR)
                    .HasColumnName("level_r")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MainInstruction)
                    .HasColumnName("main_instruction")
                    .HasMaxLength(128);

                entity.Property(e => e.MinorInstruction)
                    .HasColumnName("minor_instruction")
                    .HasMaxLength(128);

                entity.Property(e => e.ProcAdviceD)
                    .HasColumnName("proc_advice_d")
                    .HasMaxLength(254);

                entity.Property(e => e.ProcAdviceR)
                    .HasColumnName("proc_advice_r")
                    .HasMaxLength(254);

                entity.Property(e => e.RawEquipNo)
                    .HasColumnName("raw_equip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RawYxNm)
                    .HasColumnName("raw_yx_nm")
                    .HasMaxLength(64);

                entity.Property(e => e.RawYxNo)
                    .HasColumnName("raw_yx_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RelatedPic)
                    .HasColumnName("related_pic")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.RestoreAcceptableTime)
                    .HasColumnName("restore_acceptable_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ValTrait)
                    .HasColumnName("val_trait")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WaveFile)
                    .HasColumnName("wave_file")
                    .HasMaxLength(24);
            });

            modelBuilder.Entity<Resdscp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("resdscp");

                entity.Property(e => e.ResIdenti).HasMaxLength(240);

                entity.Property(e => e.ResName).HasMaxLength(48);

                entity.Property(e => e.ResType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Rtuyxtab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rtuyxtab");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasMaxLength(3);

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasColumnName("flag")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasMaxLength(2);

                entity.Property(e => e.YxNo)
                    .HasColumnName("yx_no")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<Sc302encode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sc302encode");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Door)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EquipNo)
                    .IsRequired()
                    .HasColumnName("equip_no")
                    .HasMaxLength(2);

                entity.Property(e => e.Name).HasMaxLength(32);

                entity.Property(e => e.Pin).HasMaxLength(8);

                entity.Property(e => e.StaN)
                    .IsRequired()
                    .HasColumnName("sta_n")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("'01'");

                entity.Property(e => e.TimeGroup)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Sc302timeg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sc302timeg");

                entity.Property(e => e.EquipNo)
                    .IsRequired()
                    .HasColumnName("equip_no")
                    .HasMaxLength(2);

                entity.Property(e => e.Fri).HasMaxLength(8);

                entity.Property(e => e.Mon).HasMaxLength(8);

                entity.Property(e => e.Sat).HasMaxLength(8);

                entity.Property(e => e.StaN)
                    .IsRequired()
                    .HasColumnName("sta_n")
                    .HasMaxLength(2);

                entity.Property(e => e.Sun).HasMaxLength(8);

                entity.Property(e => e.Thu).HasMaxLength(8);

                entity.Property(e => e.TimeGroup)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Tue).HasMaxLength(8);

                entity.Property(e => e.Wed).HasMaxLength(8);
            });

            modelBuilder.Entity<Setevt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("setevt");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasMaxLength(128);

                entity.Property(e => e.Gwsource)
                    .HasColumnName("gwsource")
                    .HasColumnType("longtext");

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasColumnName("operator")
                    .HasColumnType("longtext");

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Setparm>(entity =>
            {
                entity.HasKey(e => new { e.EquipNo, e.SetNo })
                    .HasName("PRIMARY");

                entity.ToTable("setparm");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SetNo)
                    .HasColumnName("set_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasMaxLength(16)
                    .HasDefaultValueSql("'设置'");

                entity.Property(e => e.Canexecution)
                    .IsRequired()
                    .HasColumnName("canexecution")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.EnableVoice)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.MainInstruction)
                    .HasColumnName("main_instruction")
                    .HasMaxLength(64);

                entity.Property(e => e.MinorInstruction)
                    .HasColumnName("minor_instruction")
                    .HasColumnType("longtext");

                entity.Property(e => e.QrEquipNo)
                    .HasColumnName("qr_equip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Record)
                    .IsRequired()
                    .HasColumnName("record")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.SetNm)
                    .HasColumnName("set_nm")
                    .HasColumnType("longtext");

                entity.Property(e => e.SetType)
                    .HasColumnName("set_type")
                    .HasMaxLength(1);

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("longtext");

                entity.Property(e => e.VoiceKeys).HasColumnType("longtext");
            });

            modelBuilder.Entity<Smsreqcont>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("smsreqcont");

                entity.Property(e => e.EquipNo).HasColumnType("int(11)");

                entity.Property(e => e.MainInstruction)
                    .HasColumnName("main_instruction")
                    .HasMaxLength(64);

                entity.Property(e => e.MinorInstruction)
                    .HasColumnName("minor_instruction")
                    .HasMaxLength(64);

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.ReqId)
                    .HasColumnName("ReqID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Task).HasMaxLength(128);

                entity.Property(e => e.Type).HasMaxLength(2);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(32);

                entity.Property(e => e.YcYxNo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Smsreqlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("smsreqlist");

                entity.Property(e => e.Comment).HasMaxLength(128);

                entity.Property(e => e.ReqId)
                    .HasColumnName("ReqID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqName).HasMaxLength(64);
            });

            modelBuilder.Entity<Spealmreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spealmreport");

                entity.Property(e => e.Administrator).HasMaxLength(32);

                entity.Property(e => e.GroupNo)
                    .HasColumnName("group_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("longtext");

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("station");

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StaNm)
                    .IsRequired()
                    .HasColumnName("sta_nm")
                    .HasMaxLength(64);

                entity.Property(e => e.StaType)
                    .HasColumnName("sta_type")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Syappg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("syappg");

                entity.Property(e => e.AppG)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Opendoor1)
                    .IsRequired()
                    .HasColumnName("opendoor1")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Opendoor2)
                    .IsRequired()
                    .HasColumnName("opendoor2")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Opendoor3)
                    .IsRequired()
                    .HasColumnName("opendoor3")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Opendoor4)
                    .IsRequired()
                    .HasColumnName("opendoor4")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Outdoor1)
                    .IsRequired()
                    .HasColumnName("outdoor1")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Outdoor2)
                    .IsRequired()
                    .HasColumnName("outdoor2")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Outdoor3)
                    .IsRequired()
                    .HasColumnName("outdoor3")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Outdoor4)
                    .IsRequired()
                    .HasColumnName("outdoor4")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Perpintz1)
                    .HasColumnName("perpintz1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Perpintz2)
                    .HasColumnName("perpintz2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Perpintz3)
                    .HasColumnName("perpintz3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Perpintz4)
                    .HasColumnName("perpintz4")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Secpintz1)
                    .HasColumnName("secpintz1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Secpintz2)
                    .HasColumnName("secpintz2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Secpintz3)
                    .HasColumnName("secpintz3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Secpintz4)
                    .HasColumnName("secpintz4")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WeekdataG)
                    .HasColumnName("weekdataG")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Sycardno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sycardno");

                entity.Property(e => e.App)
                    .HasColumnName("app")
                    .HasMaxLength(2);

                entity.Property(e => e.CardNo)
                    .HasColumnName("card_no")
                    .HasMaxLength(50);

                entity.Property(e => e.Cardid)
                    .HasColumnName("cardid")
                    .HasMaxLength(50);

                entity.Property(e => e.Cardtype)
                    .HasColumnName("cardtype")
                    .HasMaxLength(2);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(8);

                entity.Property(e => e.Pin)
                    .HasColumnName("pin")
                    .HasMaxLength(50);

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Sydatag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sydatag");

                entity.Property(e => e.DataGroup)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TimeG1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TimeG2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TimeG3)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Sysevt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sysevt");

                entity.Property(e => e.Confirmname)
                    .HasColumnName("confirmname")
                    .HasMaxLength(128);

                entity.Property(e => e.Confirmremark)
                    .HasColumnName("confirmremark")
                    .HasMaxLength(255);

                entity.Property(e => e.Event)
                    .HasColumnName("event")
                    .HasColumnType("longtext");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(255);

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Sytimeg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sytimeg");

                entity.Property(e => e.AdmitBgn)
                    .HasColumnName("Admit_Bgn")
                    .HasMaxLength(4);

                entity.Property(e => e.AdmitEnd)
                    .HasColumnName("Admit_End")
                    .HasMaxLength(4);

                entity.Property(e => e.TimeGroup)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TcInoutls>(entity =>
            {
                entity.ToTable("tc_inoutls");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CarNo)
                    .HasColumnName("Car_No")
                    .HasMaxLength(255);

                entity.Property(e => e.CarType)
                    .HasColumnName("Car_Type")
                    .HasMaxLength(255);

                entity.Property(e => e.CardNo)
                    .HasColumnName("Card_no")
                    .HasMaxLength(255);

                entity.Property(e => e.CardType).HasMaxLength(255);

                entity.Property(e => e.CtrlNoI)
                    .HasColumnName("Ctrl_No_i")
                    .HasMaxLength(255);

                entity.Property(e => e.CtrlNoInVideo)
                    .HasColumnName("Ctrl_No_InVideo")
                    .HasMaxLength(255);

                entity.Property(e => e.CtrlNoO)
                    .HasColumnName("Ctrl_No_o")
                    .HasMaxLength(255);

                entity.Property(e => e.CtrlNoOutVideo)
                    .HasColumnName("Ctrl_No_OutVideo")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Telphone>(entity =>
            {
                entity.HasKey(e => new { e.StaN, e.EquipNo, e.PhoneNum })
                    .HasName("PRIMARY");

                entity.ToTable("telphone");

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasMaxLength(2);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasMaxLength(2);

                entity.Property(e => e.PhoneNum)
                    .HasColumnName("phone_num")
                    .HasMaxLength(30);

                entity.Property(e => e.CallMachineFinalKey)
                    .HasColumnName("call_machine_final_key")
                    .HasMaxLength(50);

                entity.Property(e => e.CallMachineFunctKey)
                    .HasColumnName("call_machine_funct_key")
                    .HasMaxLength(15);

                entity.Property(e => e.DialInterval)
                    .HasColumnName("dial_interval")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DialRepeat)
                    .HasColumnName("dial_repeat")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IfCallMachine)
                    .IsRequired()
                    .HasColumnName("if_call_machine")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30);

                entity.Property(e => e.Permit)
                    .IsRequired()
                    .HasColumnName("permit")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.WaitBeforeSpeak)
                    .HasColumnName("wait_before_speak")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Visitorrecord>(entity =>
            {
                entity.ToTable("visitorrecord");

                entity.HasIndex(e => e.Id)
                    .HasName("IDXVisitorRecord_ID");

                entity.HasIndex(e => e.LicenseCode)
                    .HasName("IDXVisitorRecord_LicenseCode");

                entity.HasIndex(e => e.PeerNum)
                    .HasName("IDXVisitorRecord_PeerNum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasColumnType("longtext");

                entity.Property(e => e.Company).HasColumnType("longtext");

                entity.Property(e => e.Event).HasMaxLength(255);

                entity.Property(e => e.IssuingAgency).HasColumnType("longtext");

                entity.Property(e => e.LicenseCode).HasMaxLength(255);

                entity.Property(e => e.LicenseType).HasMaxLength(255);

                entity.Property(e => e.Nation).HasMaxLength(255);

                entity.Property(e => e.Photo).HasColumnType("longtext");

                entity.Property(e => e.Qrcode)
                    .HasColumnName("QRCode")
                    .HasColumnType("longtext");

                entity.Property(e => e.Remark).HasColumnType("longtext");

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(255);

                entity.Property(e => e.Visitor).HasMaxLength(255);
            });

            modelBuilder.Entity<Weekalmreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("weekalmreport");

                entity.Property(e => e.Administrator).HasMaxLength(32);

                entity.Property(e => e.GroupNo)
                    .HasColumnName("group_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("longtext");

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WeekDay)
                    .HasColumnName("week_day")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Weekdatag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("weekdatag");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mon)
                    .HasColumnName("mon")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sat)
                    .HasColumnName("sat")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sun)
                    .HasColumnName("sun")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Thi)
                    .HasColumnName("thi")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tue)
                    .HasColumnName("tue")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tur)
                    .HasColumnName("tur")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Wes)
                    .HasColumnName("wes")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Welcomingspeech>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("welcomingspeech");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jsoncontent).HasColumnName("JSONContent");

                entity.Property(e => e.SiginalVal).HasColumnName("siginalVal");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Woacceptorder>(entity =>
            {
                entity.ToTable("woacceptorder");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Claim)
                    .HasColumnName("claim")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedTime)
                    .IsRequired()
                    .HasColumnName("created_time")
                    .HasMaxLength(30);

                entity.Property(e => e.CurrentProcessor)
                    .HasColumnName("current_processor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Personnel)
                    .IsRequired()
                    .HasColumnName("personnel")
                    .HasMaxLength(30);

                entity.Property(e => e.TransferPersonnel)
                    .IsRequired()
                    .HasColumnName("transfer_personnel")
                    .HasMaxLength(30);

                entity.Property(e => e.WorkOrderId)
                    .IsRequired()
                    .HasColumnName("work_order_id")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Woattachment>(entity =>
            {
                entity.ToTable("woattachment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(32);

                entity.Property(e => e.CreatedTime)
                    .IsRequired()
                    .HasColumnName("created_time")
                    .HasMaxLength(30);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(30);

                entity.Property(e => e.SaveDate)
                    .IsRequired()
                    .HasColumnName("save_date")
                    .HasMaxLength(20);

                entity.Property(e => e.WorkOrderId)
                    .IsRequired()
                    .HasColumnName("work_order_id")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Womainfeedbackattachment>(entity =>
            {
                entity.ToTable("womainfeedbackattachment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(32);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(10);

                entity.Property(e => e.FeedbackId)
                    .IsRequired()
                    .HasColumnName("feedback_id")
                    .HasMaxLength(32);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(30);

                entity.Property(e => e.SaveDate)
                    .IsRequired()
                    .HasColumnName("save_date")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Womainfeedbackconfirm>(entity =>
            {
                entity.ToTable("womainfeedbackconfirm");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasMaxLength(30);

                entity.Property(e => e.FeedbackId)
                    .IsRequired()
                    .HasColumnName("feedback_id")
                    .HasMaxLength(32);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("longtext");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderId)
                    .IsRequired()
                    .HasColumnName("work_order_id")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Womaintenancefeedback>(entity =>
            {
                entity.ToTable("womaintenancefeedback");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(32);

                entity.Property(e => e.AcceptOrderId)
                    .HasColumnName("accept_order_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CauseIssue)
                    .HasColumnName("cause_issue")
                    .HasColumnType("longtext");

                entity.Property(e => e.CreatedTime)
                    .IsRequired()
                    .HasColumnName("created_time")
                    .HasMaxLength(30);

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaintenanceTime)
                    .IsRequired()
                    .HasColumnName("maintenance_time")
                    .HasMaxLength(30);

                entity.Property(e => e.ProcessContent)
                    .HasColumnName("process_content")
                    .HasColumnType("longtext");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Worecord>(entity =>
            {
                entity.ToTable("worecord");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedTime)
                    .IsRequired()
                    .HasColumnName("created_time")
                    .HasMaxLength(30);

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasMaxLength(30);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("longtext");

                entity.Property(e => e.WorkOrderId)
                    .IsRequired()
                    .HasColumnName("work_order_id")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Workorder>(entity =>
            {
                entity.ToTable("workorder");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(32);

                entity.Property(e => e.CompletedTime)
                    .HasColumnName("completed_time")
                    .HasMaxLength(30);

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("longtext");

                entity.Property(e => e.CreatedTime)
                    .IsRequired()
                    .HasColumnName("created_time")
                    .HasMaxLength(30);

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasMaxLength(30);

                entity.Property(e => e.EquipType)
                    .IsRequired()
                    .HasColumnName("equip_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaintenanceSite)
                    .IsRequired()
                    .HasColumnName("maintenance_site")
                    .HasMaxLength(100);

                entity.Property(e => e.MaintenanceTime)
                    .IsRequired()
                    .HasColumnName("maintenance_time")
                    .HasMaxLength(30);

                entity.Property(e => e.ModifiedTime)
                    .IsRequired()
                    .HasColumnName("modified_time")
                    .HasMaxLength(30);

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasColumnType("longtext");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Topic)
                    .IsRequired()
                    .HasColumnName("topic")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Workstation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("workstation");

                entity.Property(e => e.NetAddr)
                    .HasColumnName("net_addr")
                    .HasMaxLength(32);

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StaNm)
                    .HasColumnName("sta_nm")
                    .HasMaxLength(64);

                entity.Property(e => e.StaType)
                    .HasColumnName("sta_type")
                    .HasMaxLength(2);

                entity.Property(e => e.SubPath)
                    .HasColumnName("sub_path")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Ycp>(entity =>
            {
                entity.HasKey(e => new { e.EquipNo, e.YcNo })
                    .HasName("PRIMARY");

                entity.ToTable("ycp");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.YcNo)
                    .HasColumnName("yc_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlarmAcceptableTime)
                    .HasColumnName("alarm_acceptable_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmRepeatTime)
                    .HasColumnName("alarm_repeat_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmRiseCycle)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmScheme)
                    .HasColumnName("alarm_scheme")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmShield)
                    .HasColumnName("alarm_shield")
                    .HasColumnType("longtext");

                entity.Property(e => e.CurveLimit)
                    .HasColumnName("curve_limit")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CurveRcd)
                    .IsRequired()
                    .HasColumnName("curve_rcd")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LvlLevel)
                    .HasColumnName("lvl_level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MainInstruction)
                    .HasColumnName("main_instruction")
                    .HasMaxLength(254);

                entity.Property(e => e.Mapping)
                    .IsRequired()
                    .HasColumnName("mapping")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.MinorInstruction)
                    .HasColumnName("minor_instruction")
                    .HasMaxLength(254);

                entity.Property(e => e.OutmaxEvt)
                    .HasColumnName("outmax_evt")
                    .HasMaxLength(64);

                entity.Property(e => e.OutminEvt)
                    .HasColumnName("outmin_evt")
                    .HasMaxLength(64);

                entity.Property(e => e.PhysicMax)
                    .HasColumnName("physic_max")
                    .HasDefaultValueSql("'1000'");

                entity.Property(e => e.PhysicMin)
                    .HasColumnName("physic_min")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlanNo).HasMaxLength(255);

                entity.Property(e => e.ProcAdvice)
                    .HasColumnName("proc_advice")
                    .HasMaxLength(254);

                entity.Property(e => e.RelatedPic)
                    .HasColumnName("related_pic")
                    .HasMaxLength(255);

                entity.Property(e => e.RelatedVideo)
                    .HasColumnName("related_video")
                    .HasMaxLength(255);

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.RestoreAcceptableTime)
                    .HasColumnName("restore_acceptable_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RestoreMax).HasColumnName("restore_max");

                entity.Property(e => e.RestoreMin).HasColumnName("restore_min");

                entity.Property(e => e.SafeTime).HasColumnType("longtext");

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(50);

                entity.Property(e => e.ValMax).HasColumnName("val_max");

                entity.Property(e => e.ValMin).HasColumnName("val_min");

                entity.Property(e => e.ValTrait)
                    .HasColumnName("val_trait")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WaveFile)
                    .HasColumnName("wave_file")
                    .HasMaxLength(64);

                entity.Property(e => e.YcMax)
                    .HasColumnName("yc_max")
                    .HasDefaultValueSql("'1000'");

                entity.Property(e => e.YcMin)
                    .HasColumnName("yc_min")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.YcNm)
                    .HasColumnName("yc_nm")
                    .HasMaxLength(80);

                entity.Property(e => e.ZiChanId)
                    .HasColumnName("ZiChanID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ycyxevt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ycyxevt");

                entity.Property(e => e.AlarmState).HasColumnType("int(11)");

                entity.Property(e => e.Alarmlevel)
                    .HasColumnName("alarmlevel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Confirmname)
                    .HasColumnName("confirmname")
                    .HasMaxLength(128);

                entity.Property(e => e.Confirmremark)
                    .HasColumnName("confirmremark")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasMaxLength(255);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(255);

                entity.Property(e => e.ProcRec)
                    .HasColumnName("proc_rec")
                    .HasMaxLength(255);

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WuBao)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.YcyxNo)
                    .HasColumnName("ycyx_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.YcyxType)
                    .IsRequired()
                    .HasColumnName("ycyx_type")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Ycyxevtreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ycyxevtreport");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IndexNum)
                    .HasColumnName("index_num")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64);

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)");

                entity.Property(e => e.YcyxNo)
                    .HasColumnName("ycyx_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.YcyxType)
                    .IsRequired()
                    .HasColumnName("ycyx_type")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Yxp>(entity =>
            {
                entity.HasKey(e => new { e.EquipNo, e.YxNo })
                    .HasName("PRIMARY");

                entity.ToTable("yxp");

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.YxNo)
                    .HasColumnName("yx_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlarmAcceptableTime)
                    .HasColumnName("alarm_acceptable_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmRepeatTime)
                    .HasColumnName("alarm_repeat_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmRiseCycle)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmScheme)
                    .HasColumnName("alarm_scheme")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmShield)
                    .HasColumnName("alarm_shield")
                    .HasColumnType("longtext");

                entity.Property(e => e.CurveRcd)
                    .IsRequired()
                    .HasColumnName("curve_rcd")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Evt01)
                    .HasColumnName("evt_01")
                    .HasMaxLength(64);

                entity.Property(e => e.Evt10)
                    .HasColumnName("evt_10")
                    .HasMaxLength(64);

                entity.Property(e => e.Initval)
                    .HasColumnName("initval")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Inversion)
                    .IsRequired()
                    .HasColumnName("inversion")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LevelD)
                    .HasColumnName("level_d")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LevelR)
                    .HasColumnName("level_r")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MainInstruction)
                    .HasColumnName("main_instruction")
                    .HasMaxLength(254);

                entity.Property(e => e.MinorInstruction)
                    .HasColumnName("minor_instruction")
                    .HasMaxLength(254);

                entity.Property(e => e.PlanNo).HasMaxLength(255);

                entity.Property(e => e.ProcAdviceD)
                    .HasColumnName("proc_advice_d")
                    .HasMaxLength(254);

                entity.Property(e => e.ProcAdviceR)
                    .HasColumnName("proc_advice_r")
                    .HasMaxLength(254);

                entity.Property(e => e.RelatedPic)
                    .HasColumnName("related_pic")
                    .HasMaxLength(255);

                entity.Property(e => e.RelatedVideo)
                    .HasColumnName("related_video")
                    .HasMaxLength(255);

                entity.Property(e => e.Reserve1).HasColumnType("longtext");

                entity.Property(e => e.Reserve2).HasColumnType("longtext");

                entity.Property(e => e.Reserve3).HasColumnType("longtext");

                entity.Property(e => e.RestoreAcceptableTime)
                    .HasColumnName("restore_acceptable_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SafeTime).HasColumnType("longtext");

                entity.Property(e => e.StaN)
                    .HasColumnName("sta_n")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ValTrait)
                    .HasColumnName("val_trait")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WaveFile)
                    .HasColumnName("wave_file")
                    .HasMaxLength(64);

                entity.Property(e => e.YxNm)
                    .HasColumnName("yx_nm")
                    .HasMaxLength(80);

                entity.Property(e => e.ZiChanId)
                    .HasColumnName("ZiChanID")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
