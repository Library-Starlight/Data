using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Dapper.Data.MySql.Model;

#nullable disable

namespace Dapper.Data.MySql.Context
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

        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Alarmproc> Alarmprocs { get; set; }
        public virtual DbSet<Alarmrec> Alarmrecs { get; set; }
        public virtual DbSet<Almreport> Almreports { get; set; }
        public virtual DbSet<Autoproc> Autoprocs { get; set; }
        public virtual DbSet<CurDatum> CurData { get; set; }
        public virtual DbSet<CurIdx> CurIdxes { get; set; }
        public virtual DbSet<CurRec> CurRecs { get; set; }
        public virtual DbSet<Drgrdrcd> Drgrdrcds { get; set; }
        public virtual DbSet<Dutysat> Dutysats { get; set; }
        public virtual DbSet<Dutyset> Dutysets { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Equip> Equips { get; set; }
        public virtual DbSet<Equipgroup> Equipgroups { get; set; }
        public virtual DbSet<Equipoperation> Equipoperations { get; set; }
        public virtual DbSet<ExprocAll> ExprocAlls { get; set; }
        public virtual DbSet<Gisconfig> Gisconfigs { get; set; }
        public virtual DbSet<Gisrouteconfig> Gisrouteconfigs { get; set; }
        public virtual DbSet<GwAlarminfo> GwAlarminfos { get; set; }
        public virtual DbSet<GwHomeMenu> GwHomeMenus { get; set; }
        public virtual DbSet<GwHomeMenuStatus> GwHomeMenuStatuses { get; set; }
        public virtual DbSet<GwLanguage> GwLanguages { get; set; }
        public virtual DbSet<GwMjCard> GwMjCards { get; set; }
        public virtual DbSet<GwMjCardatdoor> GwMjCardatdoors { get; set; }
        public virtual DbSet<GwMjCardatdoorKingkang> GwMjCardatdoorKingkangs { get; set; }
        public virtual DbSet<GwMjControllerParamKingkang> GwMjControllerParamKingkangs { get; set; }
        public virtual DbSet<GwMjDeptment> GwMjDeptments { get; set; }
        public virtual DbSet<GwMjDoorinfo> GwMjDoorinfos { get; set; }
        public virtual DbSet<GwMjDoorparam> GwMjDoorparams { get; set; }
        public virtual DbSet<GwMjDrgrdrcd> GwMjDrgrdrcds { get; set; }
        public virtual DbSet<GwMjHoliday> GwMjHolidays { get; set; }
        public virtual DbSet<GwMjHolidayatdoor> GwMjHolidayatdoors { get; set; }
        public virtual DbSet<GwMjMember> GwMjMembers { get; set; }
        public virtual DbSet<GwMjMulticardgroup> GwMjMulticardgroups { get; set; }
        public virtual DbSet<GwMjPreTimezoneKingkang> GwMjPreTimezoneKingkangs { get; set; }
        public virtual DbSet<GwMjRealtimeinout> GwMjRealtimeinouts { get; set; }
        public virtual DbSet<GwMjTimegroup> GwMjTimegroups { get; set; }
        public virtual DbSet<GwMjTimezoneKingkang> GwMjTimezoneKingkangs { get; set; }
        public virtual DbSet<GwMjTrafficGroup> GwMjTrafficGroups { get; set; }
        public virtual DbSet<GwMjTrafficGroupatdoorKingkang> GwMjTrafficGroupatdoorKingkangs { get; set; }
        public virtual DbSet<GwPatrolCard> GwPatrolCards { get; set; }
        public virtual DbSet<GwPatrolCardtype> GwPatrolCardtypes { get; set; }
        public virtual DbSet<GwPatrolComport> GwPatrolComports { get; set; }
        public virtual DbSet<GwPatrolException> GwPatrolExceptions { get; set; }
        public virtual DbSet<GwPatrolMeter> GwPatrolMeters { get; set; }
        public virtual DbSet<GwPatrolPatrolgroup> GwPatrolPatrolgroups { get; set; }
        public virtual DbSet<GwPatrolPlandetail> GwPatrolPlandetails { get; set; }
        public virtual DbSet<GwPatrolPlantable> GwPatrolPlantables { get; set; }
        public virtual DbSet<GwPatrolPlantabledaylist> GwPatrolPlantabledaylists { get; set; }
        public virtual DbSet<GwPatrolPlantableinspectorlist> GwPatrolPlantableinspectorlists { get; set; }
        public virtual DbSet<GwPatrolPlantabletimelist> GwPatrolPlantabletimelists { get; set; }
        public virtual DbSet<GwPatrolRecordOrigin> GwPatrolRecordOrigins { get; set; }
        public virtual DbSet<GwPatrolResult> GwPatrolResults { get; set; }
        public virtual DbSet<GwPatrolRoute> GwPatrolRoutes { get; set; }
        public virtual DbSet<GwPatrolRoutesetting> GwPatrolRoutesettings { get; set; }
        public virtual DbSet<GwPatrolStatus> GwPatrolStatuses { get; set; }
        public virtual DbSet<GwPtzcontrol> GwPtzcontrols { get; set; }
        public virtual DbSet<GwQrCheck> GwQrChecks { get; set; }
        public virtual DbSet<GwQrRecord> GwQrRecords { get; set; }
        public virtual DbSet<GwSpArea> GwSpAreas { get; set; }
        public virtual DbSet<GwSpChannel> GwSpChannels { get; set; }
        public virtual DbSet<GwSpDvrinfo> GwSpDvrinfos { get; set; }
        public virtual DbSet<GwSpDvrtype> GwSpDvrtypes { get; set; }
        public virtual DbSet<GwSpGroup> GwSpGroups { get; set; }
        public virtual DbSet<GwSpMethod> GwSpMethods { get; set; }
        public virtual DbSet<GwSpModul> GwSpModuls { get; set; }
        public virtual DbSet<GwUnityMarkview> GwUnityMarkviews { get; set; }
        public virtual DbSet<GwUnityModel> GwUnityModels { get; set; }
        public virtual DbSet<GwUnityParade> GwUnityParades { get; set; }
        public virtual DbSet<GwUnityResource> GwUnityResources { get; set; }
        public virtual DbSet<GwUnityScene> GwUnityScenes { get; set; }
        public virtual DbSet<GwVideoCyclechannel> GwVideoCyclechannels { get; set; }
        public virtual DbSet<GwVideoPreset> GwVideoPresets { get; set; }
        public virtual DbSet<GwVideoinfo> GwVideoinfos { get; set; }
        public virtual DbSet<Gwaddinmodule> Gwaddinmodules { get; set; }
        public virtual DbSet<Gwassetinfo> Gwassetinfos { get; set; }
        public virtual DbSet<Gwbuttonproperty> Gwbuttonproperties { get; set; }
        public virtual DbSet<Gwdatarecorditem> Gwdatarecorditems { get; set; }
        public virtual DbSet<Gwdatarecordresult> Gwdatarecordresults { get; set; }
        public virtual DbSet<Gwdelayaction> Gwdelayactions { get; set; }
        public virtual DbSet<Gwelevatormaintain> Gwelevatormaintains { get; set; }
        public virtual DbSet<Gwelevatormarker> Gwelevatormarkers { get; set; }
        public virtual DbSet<Gwequippage> Gwequippages { get; set; }
        public virtual DbSet<Gwequiptreegroup> Gwequiptreegroups { get; set; }
        public virtual DbSet<Gwequiptreeitem> Gwequiptreeitems { get; set; }
        public virtual DbSet<Gwexproc> Gwexprocs { get; set; }
        public virtual DbSet<Gwexproccmd> Gwexproccmds { get; set; }
        public virtual DbSet<Gwmaintainer> Gwmaintainers { get; set; }
        public virtual DbSet<Gwmapmarker> Gwmapmarkers { get; set; }
        public virtual DbSet<Gwnavigationproperty> Gwnavigationproperties { get; set; }
        public virtual DbSet<Gwplan> Gwplans { get; set; }
        public virtual DbSet<Gwplanrecord> Gwplanrecords { get; set; }
        public virtual DbSet<Gwproccycletable> Gwproccycletables { get; set; }
        public virtual DbSet<Gwproccycletlist> Gwproccycletlists { get; set; }
        public virtual DbSet<Gwprocspectable> Gwprocspectables { get; set; }
        public virtual DbSet<Gwproctimeeqptable> Gwproctimeeqptables { get; set; }
        public virtual DbSet<Gwproctimesystable> Gwproctimesystables { get; set; }
        public virtual DbSet<Gwproctimetlist> Gwproctimetlists { get; set; }
        public virtual DbSet<Gwprocweektable> Gwprocweektables { get; set; }
        public virtual DbSet<Gwreportinfo> Gwreportinfos { get; set; }
        public virtual DbSet<Gwrole> Gwroles { get; set; }
        public virtual DbSet<Gwsnapshotconfig> Gwsnapshotconfigs { get; set; }
        public virtual DbSet<Gwuser> Gwusers { get; set; }
        public virtual DbSet<Gwwebmapmarker> Gwwebmapmarkers { get; set; }
        public virtual DbSet<Gwzichanrecord> Gwzichanrecords { get; set; }
        public virtual DbSet<Gwzichantable> Gwzichantables { get; set; }
        public virtual DbSet<Gwzichantableexcolumn> Gwzichantableexcolumns { get; set; }
        public virtual DbSet<Hsncardno> Hsncardnos { get; set; }
        public virtual DbSet<IotDevice> IotDevices { get; set; }
        public virtual DbSet<IotDeviceservice> IotDeviceservices { get; set; }
        public virtual DbSet<IotDeviceservicemodel> IotDeviceservicemodels { get; set; }
        public virtual DbSet<IotDevicetype> IotDevicetypes { get; set; }
        public virtual DbSet<KingkangCardatdoor> KingkangCardatdoors { get; set; }
        public virtual DbSet<KingkangDept> KingkangDepts { get; set; }
        public virtual DbSet<KingkangMember> KingkangMembers { get; set; }
        public virtual DbSet<KingkangTmg> KingkangTmgs { get; set; }
        public virtual DbSet<Matafun> Matafuns { get; set; }
        public virtual DbSet<Mataobj> Mataobjs { get; set; }
        public virtual DbSet<Matasubtype> Matasubtypes { get; set; }
        public virtual DbSet<Matasymb> Matasymbs { get; set; }
        public virtual DbSet<Nsladmission> Nsladmissions { get; set; }
        public virtual DbSet<Nslcardno> Nslcardnos { get; set; }
        public virtual DbSet<Nsldateg> Nsldategs { get; set; }
        public virtual DbSet<Nslweekg> Nslweekgs { get; set; }
        public virtual DbSet<Operationequip> Operationequips { get; set; }
        public virtual DbSet<Operationlog> Operationlogs { get; set; }
        public virtual DbSet<Operationrec> Operationrecs { get; set; }
        public virtual DbSet<PersonnelFaceimage> PersonnelFaceimages { get; set; }
        public virtual DbSet<Rawequip> Rawequips { get; set; }
        public virtual DbSet<Rawycp> Rawycps { get; set; }
        public virtual DbSet<Rawyxp> Rawyxps { get; set; }
        public virtual DbSet<Resdscp> Resdscps { get; set; }
        public virtual DbSet<Rtuyxtab> Rtuyxtabs { get; set; }
        public virtual DbSet<Sc302encode> Sc302encodes { get; set; }
        public virtual DbSet<Sc302timeg> Sc302timegs { get; set; }
        public virtual DbSet<Setevt> Setevts { get; set; }
        public virtual DbSet<Setparm> Setparms { get; set; }
        public virtual DbSet<Smsreqcont> Smsreqconts { get; set; }
        public virtual DbSet<Smsreqlist> Smsreqlists { get; set; }
        public virtual DbSet<Spealmreport> Spealmreports { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<Syappg> Syappgs { get; set; }
        public virtual DbSet<Sycardno> Sycardnos { get; set; }
        public virtual DbSet<Sydatag> Sydatags { get; set; }
        public virtual DbSet<Sysevt> Sysevts { get; set; }
        public virtual DbSet<Sytimeg> Sytimegs { get; set; }
        public virtual DbSet<TcInoutl> TcInoutls { get; set; }
        public virtual DbSet<Telphone> Telphones { get; set; }
        public virtual DbSet<Visitorrecord> Visitorrecords { get; set; }
        public virtual DbSet<Weekalmreport> Weekalmreports { get; set; }
        public virtual DbSet<Weekdatag> Weekdatags { get; set; }
        public virtual DbSet<Welcomingspeech> Welcomingspeeches { get; set; }
        public virtual DbSet<Woacceptorder> Woacceptorders { get; set; }
        public virtual DbSet<Woattachment> Woattachments { get; set; }
        public virtual DbSet<Womainfeedbackattachment> Womainfeedbackattachments { get; set; }
        public virtual DbSet<Womainfeedbackconfirm> Womainfeedbackconfirms { get; set; }
        public virtual DbSet<Womaintenancefeedback> Womaintenancefeedbacks { get; set; }
        public virtual DbSet<Worecord> Worecords { get; set; }
        public virtual DbSet<Workorder> Workorders { get; set; }
        public virtual DbSet<Workstation> Workstations { get; set; }
        public virtual DbSet<Ycp> Ycps { get; set; }
        public virtual DbSet<Ycyxevt> Ycyxevts { get; set; }
        public virtual DbSet<Ycyxevtreport> Ycyxevtreports { get; set; }
        public virtual DbSet<Yxp> Yxps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=databasesql;user=root;password=357592895;treattinyasboolean=true", Microsoft.EntityFrameworkCore.ServerVersion.FromString("5.7.26-mysql"));
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
                    .HasColumnType("varchar(32)")
                    .HasColumnName("Administrator")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AckLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("EMail")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MobileTel)
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telphone)
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Alarmproc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("alarmproc");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(240)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcCode)
                    .HasColumnType("int(11)")
                    .HasColumnName("Proc_Code")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProcModule)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("Proc_Module")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcName)
                    .HasColumnType("varchar(48)")
                    .HasColumnName("Proc_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcParm)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("Proc_parm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Alarmrec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("alarmrec");

                entity.Property(e => e.Administrator)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("comment")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("event")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcName)
                    .HasColumnType("varchar(48)")
                    .HasColumnName("proc_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<Almreport>(entity =>
            {
                entity.ToTable("almreport");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Administrator)
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Autoproc>(entity =>
            {
                entity.ToTable("autoproc");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(11)")
                    .HasColumnName("delay")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Enable)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IequipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("iequip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IycyxNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("iycyx_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IycyxType)
                    .HasColumnType("varchar(16)")
                    .HasColumnName("iycyx_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OequipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("oequip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OsetNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("oset_no");

                entity.Property(e => e.ProcDesc)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CurDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_data");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("EQUIP_NO")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("STA_N")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("tmdate");

                entity.Property(e => e.YcNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("YC_NO")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CurIdx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_idx");

                entity.Property(e => e.CurvNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("curv_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.YcNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("yc_no")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CurRec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_rec");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("EQUIP_NO")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("STA_N")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("tmdate");

                entity.Property(e => e.YcNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("YC_NO")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Drgrdrcd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("drgrdrcd");

                entity.Property(e => e.Action)
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");

                entity.Property(e => e.DoorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_id");

                entity.Property(e => e.GuardNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("guard_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Yymmdd)
                    .HasColumnType("datetime")
                    .HasColumnName("yymmdd");
            });

            modelBuilder.Entity<Dutysat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dutysat");

                entity.Property(e => e.ALateCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("A_Late_Count")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ALeaveEarlyCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("A_LeaveEarly_Count")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AOnTmCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("A_OnTm_Count")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.D1)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D10)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D11)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D12)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D13)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D14)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D15)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D16)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D17)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D18)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D19)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D2)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D20)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D21)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D22)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D23)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D24)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D25)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D26)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D27)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D28)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D29)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D3)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D30)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D31)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D4)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D5)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D6)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D7)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D8)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.D9)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnType("varchar(8)")
                    .HasColumnName("ID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MLateCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("M_Late_Count")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MLeaveEarlyCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("M_LeaveEarly_Count")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MOnTmCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("M_OnTm_Count")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Yymm)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("YYMM")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Dutyset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dutyset");

                entity.Property(e => e.AInTmBgn)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("A_InTm_Bgn")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AInTmEnd)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("A_InTm_End")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ALateBgn)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("A_Late_Bgn")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ALateEnd)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("A_Late_End")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ALeaveEarlyBgn)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("A_Leave_Early_Bgn")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ALeaveEarlyEnd)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("A_Leave_Early_End")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ALeaveOnTmBgn)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("A_Leave_OnTm_Bgn")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ALeaveOnTmEnd)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("A_Leave_OnTm_End")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MInTmBgn)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("M_InTm_Bgn")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MInTmEnd)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("M_InTm_End")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MLateBgn)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("M_Late_Bgn")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MLateEnd)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("M_Late_End")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MLeaveEarlyBgn)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("M_Leave_Early_Bgn")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MLeaveEarlyEnd)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("M_Leave_Early_End")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MLeaveOnTmBgn)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("M_Leave_OnTm_Bgn")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MLeaveOnTmEnd)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("M_Leave_OnTm_End")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee");

                entity.Property(e => e.CardNo)
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnType("varchar(8)")
                    .HasColumnName("ID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Equip>(entity =>
            {
                entity.HasKey(e => e.EquipNo)
                    .HasName("PRIMARY");

                entity.ToTable("equip");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("equip_no");

                entity.Property(e => e.AccCyc)
                    .HasColumnType("int(11)")
                    .HasColumnName("acc_cyc");

                entity.Property(e => e.AlarmRiseCycle)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmScheme)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_scheme")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attrib)
                    .HasColumnType("int(11)")
                    .HasColumnName("attrib")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CommunicationDrv)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("communication_drv")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommunicationParam)
                    .HasColumnType("longtext")
                    .HasColumnName("communication_param")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommunicationTimeParam)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("communication_time_param")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Contacted)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("contacted")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipAddr)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equip_addr")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipDetail)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equip_detail")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNm)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("equip_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventWav)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("event_wav")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LocalAddr)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("local_addr")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutOfContact)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("out_of_contact")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanNo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcAdvice)
                    .HasColumnType("varchar(254)")
                    .HasColumnName("proc_advice")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RawEquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("raw_equip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RelatedPic)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("related_pic")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RelatedVideo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("related_video")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SafeTime)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaIp)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sta_IP")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tabname)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("tabname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZiChanId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ZiChanID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Equipgroup>(entity =>
            {
                entity.HasKey(e => e.GroupNo)
                    .HasName("PRIMARY");

                entity.ToTable("equipgroup");

                entity.Property(e => e.GroupNo)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("group_no");

                entity.Property(e => e.Equipcomb)
                    .HasColumnType("longtext")
                    .HasColumnName("equipcomb")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("group_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Equipoperation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("equipoperation");

                entity.Property(e => e.EquipId)
                    .IsRequired()
                    .HasColumnType("varchar(16)")
                    .HasColumnName("equip_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OPERATION_ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OperationTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OPERATION_TITLE")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaNm)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("sta_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ExprocAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("exproc_all");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(240)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcCode)
                    .HasColumnType("int(11)")
                    .HasColumnName("Proc_Code")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProcModule)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("Proc_Module")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcName)
                    .HasColumnType("varchar(48)")
                    .HasColumnName("Proc_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcParm)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("Proc_parm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gisconfig>(entity =>
            {
                entity.ToTable("gisconfig");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AlarmExpression)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AlarmImage)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CheckImage)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClickCmd)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ControlType)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Image)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImageHight)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ImageWith)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Location)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaxZoomNum)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MinZoomNum)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OffsetPoint)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tooltip)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zoom)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Gisrouteconfig>(entity =>
            {
                entity.ToTable("gisrouteconfig");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.EndPoint)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RouteName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StartPoint)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwAlarminfo>(entity =>
            {
                entity.ToTable("gw_alarminfo");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Action)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("action")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Path)
                    .HasColumnType("longtext")
                    .HasColumnName("path")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanNo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("plan_no")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RelatedPic)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("related_pic")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RelatedVideo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("related_video")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.YcyxNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("ycyx_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.YcyxType)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ycyx_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZichanNo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("zichan_no")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwHomeMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_home_menu");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("groupID");

                entity.Property(e => e.IconName)
                    .HasColumnType("text")
                    .HasColumnName("iconName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.MenuName)
                    .HasColumnType("text")
                    .HasColumnName("menuName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModulName)
                    .HasColumnType("text")
                    .HasColumnName("modulName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwHomeMenuStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_home_menu_status");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.ModulName)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("modulName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("status")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("userName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwLanguage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_language");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.LanguageType)
                    .HasColumnType("int(11)")
                    .HasColumnName("languageType");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("userName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VoiceType)
                    .HasColumnType("int(11)")
                    .HasColumnName("voiceType");
            });

            modelBuilder.Entity<GwMjCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_card");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");

                entity.Property(e => e.CardNo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("card_no")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MemberId)
                    .HasColumnType("int(11)")
                    .HasColumnName("member_id");

                entity.Property(e => e.Pwd)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("pwd")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve4)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("valid_begin");

                entity.Property(e => e.ValidEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("valid_end");

                entity.Property(e => e.Valided)
                    .HasColumnType("bit(1)")
                    .HasColumnName("valided");
            });

            modelBuilder.Entity<GwMjCardatdoor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_cardatdoor");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");

                entity.Property(e => e.DoorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_id");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.PermitGroup).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwMjCardatdoorKingkang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_cardatdoor_kingkang");

                entity.Property(e => e.AntiSubmarineBackFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("anti_submarine_back_flag");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");

                entity.Property(e => e.DoorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_id");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.HolidayFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("holiday_flag");

                entity.Property(e => e.MasterCardFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("master_card_flag");

                entity.Property(e => e.TimeZoneId)
                    .HasColumnType("int(11)")
                    .HasColumnName("time_zone_id");

                entity.Property(e => e.WrittenFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("written_flag");
            });

            modelBuilder.Entity<GwMjControllerParamKingkang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_controller_param_kingkang");

                entity.Property(e => e.ButtonTimeZoneLimitFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("button_time_zone_limit_flag");

                entity.Property(e => e.CardTypeFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("card_type_flag");

                entity.Property(e => e.DoorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_id");

                entity.Property(e => e.DoorInterlockFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("door_interlock_flag");

                entity.Property(e => e.DoorOpenAlarmTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_open_alarm_time");

                entity.Property(e => e.DoorOpenCloseStatueFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("door_open_close_statue_flag");

                entity.Property(e => e.DoorOpenTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_open_time");

                entity.Property(e => e.DoorOpenTimeOutAlarmFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("door_open_time_out_alarm_flag");

                entity.Property(e => e.DoorWithoutOpeningAlarmFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("door_without_opening_alarm_flag");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.MultiCardFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("multi_card_flag");

                entity.Property(e => e.MultiCardNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("multi_card_num");

                entity.Property(e => e.OpenDoorModel)
                    .HasColumnType("int(11)")
                    .HasColumnName("open_door_model");

                entity.Property(e => e.PasswordTimeZoneLimitFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("password_time_zone_limit_flag");

                entity.Property(e => e.WrittenFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("written_flag");
            });

            modelBuilder.Entity<GwMjDeptment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_deptment");

                entity.Property(e => e.DeptId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dept_id");

                entity.Property(e => e.DeptNm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("dept_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("valid_begin");

                entity.Property(e => e.ValidEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("valid_end");
            });

            modelBuilder.Entity<GwMjDoorinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_doorinfo");

                entity.Property(e => e.AttendanceLocusFlag).HasColumnType("bit(1)");

                entity.Property(e => e.DoorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_id");

                entity.Property(e => e.DoorName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("door_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.Path)
                    .HasColumnType("longtext")
                    .HasColumnName("path")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanNo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RelatedVideo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("related_video")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve4)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Statue)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZiChanId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ZiChanID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwMjDoorparam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_doorparam");

                entity.Property(e => e.DisName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("disName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DoorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_id");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.IsUse)
                    .HasColumnType("bit(1)")
                    .HasColumnName("isUse");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Paramtype)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("paramtype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("remark")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwMjDrgrdrcd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_drgrdrcd");

                entity.Property(e => e.Action)
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardId)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("card_id");

                entity.Property(e => e.DoorId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("door_id");

                entity.Property(e => e.GuardNo)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("guard_no");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Yymmdd)
                    .HasColumnType("datetime")
                    .HasColumnName("yymmdd");
            });

            modelBuilder.Entity<GwMjHoliday>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_holiday");

                entity.Property(e => e.HolidayEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("holiday_end");

                entity.Property(e => e.HolidayId)
                    .HasColumnType("int(11)")
                    .HasColumnName("holiday_id");

                entity.Property(e => e.HolidayName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("holiday_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HolidayStart)
                    .HasColumnType("datetime")
                    .HasColumnName("holiday_start");
            });

            modelBuilder.Entity<GwMjHolidayatdoor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_holidayatdoor");

                entity.Property(e => e.DoorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_id");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.HolidayId)
                    .HasColumnType("int(11)")
                    .HasColumnName("holiday_id");
            });

            modelBuilder.Entity<GwMjMember>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_mj_member");

                entity.Property(e => e.MemberId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("member_id");

                entity.Property(e => e.Addr)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("addr")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeptId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dept_id");

                entity.Property(e => e.HeadFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("head_flag")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.MemberName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("member_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MemberStatue)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("member_statue")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve4)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tel)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tel")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TrafficGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("traffic_group_id");
            });

            modelBuilder.Entity<GwMjMulticardgroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_multicardgroup");

                entity.Property(e => e.MultiCardsGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("multi_cards_group_id");

                entity.Property(e => e.MultiCardsGroupNm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("multi_cards_group_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwMjPreTimezoneKingkang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_pre_timezone_kingkang");

                entity.Property(e => e.DoorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_id");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.Time1Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("time1_begin");

                entity.Property(e => e.Time1End)
                    .HasColumnType("datetime")
                    .HasColumnName("time1_end");

                entity.Property(e => e.Time2Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("time2_begin");

                entity.Property(e => e.Time2End)
                    .HasColumnType("datetime")
                    .HasColumnName("time2_end");

                entity.Property(e => e.Time3Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("time3_begin");

                entity.Property(e => e.Time3End)
                    .HasColumnType("datetime")
                    .HasColumnName("time3_end");

                entity.Property(e => e.Time4Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("time4_begin");

                entity.Property(e => e.Time4End)
                    .HasColumnType("datetime")
                    .HasColumnName("time4_end");
            });

            modelBuilder.Entity<GwMjRealtimeinout>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_realtimeinout");

                entity.Property(e => e.Action)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");

                entity.Property(e => e.DoorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_id");

                entity.Property(e => e.GuardNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("guard_no");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Yymmdd)
                    .HasColumnType("datetime")
                    .HasColumnName("yymmdd");
            });

            modelBuilder.Entity<GwMjTimegroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_timegroup");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve4)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time1Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("time1_begin");

                entity.Property(e => e.Time1End)
                    .HasColumnType("datetime")
                    .HasColumnName("time1_end");

                entity.Property(e => e.Time2Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("time2_begin");

                entity.Property(e => e.Time2End)
                    .HasColumnType("datetime")
                    .HasColumnName("time2_end");

                entity.Property(e => e.Time3Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("time3_begin");

                entity.Property(e => e.Time3End)
                    .HasColumnType("datetime")
                    .HasColumnName("time3_end");

                entity.Property(e => e.TimeGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("time_group_id");

                entity.Property(e => e.TimeGroupName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("time_group_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WkPermission)
                    .HasColumnType("int(11)")
                    .HasColumnName("wk_permission");
            });

            modelBuilder.Entity<GwMjTimezoneKingkang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_timezone_kingkang");

                entity.Property(e => e.DoorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_id");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve4)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TimeZoneId)
                    .HasColumnType("int(11)")
                    .HasColumnName("time_zone_id");

                entity.Property(e => e.TimeZoneName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("time_zone_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.W1Time1Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_time1_begin");

                entity.Property(e => e.W1Time1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_time1_end");

                entity.Property(e => e.W1Time2Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_time2_begin");

                entity.Property(e => e.W1Time2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_time2_end");

                entity.Property(e => e.W1Time3Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_time3_begin");

                entity.Property(e => e.W1Time3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_time3_end");

                entity.Property(e => e.W1Time4Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_time4_begin");

                entity.Property(e => e.W1Time4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_time4_end");

                entity.Property(e => e.W2Time1Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_time1_begin");

                entity.Property(e => e.W2Time1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_time1_end");

                entity.Property(e => e.W2Time2Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_time2_begin");

                entity.Property(e => e.W2Time2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_time2_end");

                entity.Property(e => e.W2Time3Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_time3_begin");

                entity.Property(e => e.W2Time3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_time3_end");

                entity.Property(e => e.W2Time4Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_time4_begin");

                entity.Property(e => e.W2Time4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_time4_end");

                entity.Property(e => e.W3Time1Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_time1_begin");

                entity.Property(e => e.W3Time1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_time1_end");

                entity.Property(e => e.W3Time2Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_time2_begin");

                entity.Property(e => e.W3Time2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_time2_end");

                entity.Property(e => e.W3Time3Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_time3_begin");

                entity.Property(e => e.W3Time3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_time3_end");

                entity.Property(e => e.W3Time4Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_time4_begin");

                entity.Property(e => e.W3Time4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_time4_end");

                entity.Property(e => e.W4Time1Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_time1_begin");

                entity.Property(e => e.W4Time1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_time1_end");

                entity.Property(e => e.W4Time2Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_time2_begin");

                entity.Property(e => e.W4Time2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_time2_end");

                entity.Property(e => e.W4Time3Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_time3_begin");

                entity.Property(e => e.W4Time3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_time3_end");

                entity.Property(e => e.W4Time4Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_time4_begin");

                entity.Property(e => e.W4Time4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_time4_end");

                entity.Property(e => e.W5Time1Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_time1_begin");

                entity.Property(e => e.W5Time1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_time1_end");

                entity.Property(e => e.W5Time2Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_time2_begin");

                entity.Property(e => e.W5Time2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_time2_end");

                entity.Property(e => e.W5Time3Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_time3_begin");

                entity.Property(e => e.W5Time3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_time3_end");

                entity.Property(e => e.W5Time4Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_time4_begin");

                entity.Property(e => e.W5Time4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_time4_end");

                entity.Property(e => e.W6Time1Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_time1_begin");

                entity.Property(e => e.W6Time1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_time1_end");

                entity.Property(e => e.W6Time2Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_time2_begin");

                entity.Property(e => e.W6Time2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_time2_end");

                entity.Property(e => e.W6Time3Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_time3_begin");

                entity.Property(e => e.W6Time3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_time3_end");

                entity.Property(e => e.W6Time4Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_time4_begin");

                entity.Property(e => e.W6Time4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_time4_end");

                entity.Property(e => e.W7Time1Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_time1_begin");

                entity.Property(e => e.W7Time1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_time1_end");

                entity.Property(e => e.W7Time2Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_time2_begin");

                entity.Property(e => e.W7Time2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_time2_end");

                entity.Property(e => e.W7Time3Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_time3_begin");

                entity.Property(e => e.W7Time3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_time3_end");

                entity.Property(e => e.W7Time4Begin)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_time4_begin");

                entity.Property(e => e.W7Time4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_time4_end");
            });

            modelBuilder.Entity<GwMjTrafficGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_traffic_group");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Group_Id");

                entity.Property(e => e.GroupName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Group_Name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwMjTrafficGroupatdoorKingkang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_mj_traffic_groupatdoor_kingkang");

                entity.Property(e => e.AntiSubmarineBackFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("anti_submarine_back_flag");

                entity.Property(e => e.DoorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("door_id");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");

                entity.Property(e => e.HolidayFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("holiday_flag");

                entity.Property(e => e.MasterCardFlag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("master_card_flag");

                entity.Property(e => e.TimeZoneId)
                    .HasColumnType("int(11)")
                    .HasColumnName("time_zone_id");
            });

            modelBuilder.Entity<GwPatrolCard>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_card");

                entity.Property(e => e.CardId).HasColumnType("int(11)");

                entity.Property(e => e.CardNo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Orders).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwPatrolCardtype>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_cardtype");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TypeName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwPatrolComport>(entity =>
            {
                entity.HasKey(e => e.MeterType)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_comport");

                entity.Property(e => e.MeterType)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommunicationParam)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Port)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwPatrolException>(entity =>
            {
                entity.HasKey(e => e.ExpId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_exception");

                entity.Property(e => e.ExpId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExpName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwPatrolMeter>(entity =>
            {
                entity.HasKey(e => e.MeterId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_meter");

                entity.Property(e => e.MeterId).HasColumnType("int(11)");

                entity.Property(e => e.MeterNo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RouteId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GwPatrolPatrolgroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_patrolgroup");

                entity.Property(e => e.GroupId).HasColumnType("int(11)");

                entity.Property(e => e.GroupName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GwPatrolPlandetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_patrol_plandetails");

                entity.Property(e => e.ArrivedTime).HasColumnType("datetime");

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExceptionId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InspectorId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LocusId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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

                entity.Property(e => e.ExecuteDate).HasColumnType("datetime");

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
                    .HasColumnType("int(11)")
                    .HasColumnName("InspectorID");

                entity.Property(e => e.Orders).HasColumnType("int(11)");

                entity.Property(e => e.PlanTableId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PlanTableID");

                entity.Property(e => e.PlanTableInspectorListId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PlanTableInspectorListID");
            });

            modelBuilder.Entity<GwPatrolPlantabletimelist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_patrol_plantabletimelist");

                entity.Property(e => e.FromTime).HasColumnType("datetime");

                entity.Property(e => e.Orders).HasColumnType("int(11)");

                entity.Property(e => e.PlanTableId).HasColumnType("int(11)");

                entity.Property(e => e.PlanTableTimeListId).HasColumnType("int(11)");

                entity.Property(e => e.ToTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GwPatrolRecordOrigin>(entity =>
            {
                entity.ToTable("gw_patrol_record_origin");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ExceptionId)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Locus)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MeterId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatrolMan)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<GwPatrolResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_patrol_result");

                entity.Property(e => e.ArrivedTime).HasColumnType("datetime");

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExceptionName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InspectorName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LocusCardNo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LocusName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RouteName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StateName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
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

                entity.Property(e => e.RouteName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwPatrolRoutesetting>(entity =>
            {
                entity.HasKey(e => e.SetId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_patrol_routesetting");

                entity.Property(e => e.SetId).HasColumnType("int(11)");

                entity.Property(e => e.ArriaveTime).HasColumnType("datetime");

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
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwPtzcontrol>(entity =>
            {
                entity.ToTable("gw_ptzcontrol");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

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
                    .HasColumnType("int(11)")
                    .HasColumnName("PTZBottom")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ptzleft)
                    .HasColumnType("int(11)")
                    .HasColumnName("PTZLeft")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ptzpreset)
                    .HasColumnType("int(11)")
                    .HasColumnName("PTZPreset")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PtzpresetValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("PTZPresetValue")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ptzright)
                    .HasColumnType("int(11)")
                    .HasColumnName("PTZRight")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ptztop)
                    .HasColumnType("int(11)")
                    .HasColumnName("PTZTop")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PtzzoomD)
                    .HasColumnType("int(11)")
                    .HasColumnName("PTZZoomD")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PtzzoomP)
                    .HasColumnType("int(11)")
                    .HasColumnName("PTZZoomP")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GwQrCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_qr_check");

                entity.Property(e => e.Actionid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("actionid")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.Qrcreatname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("qrcreatname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Qrtype)
                    .HasColumnType("int(11)")
                    .HasColumnName("qrtype")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Result)
                    .HasColumnType("int(11)")
                    .HasColumnName("result")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Vistorname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vistorname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwQrRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_qr_record");

                entity.Property(e => e.Actionid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("actionid")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.Qrcreatname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("qrcreatname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Qrtype)
                    .HasColumnType("int(11)")
                    .HasColumnName("qrtype")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Result)
                    .HasColumnType("int(11)")
                    .HasColumnName("result")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Vistorname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vistorname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwSpArea>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_sp_area");

                entity.Property(e => e.AreaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID");

                entity.Property(e => e.AreaDvrChannel)
                    .HasColumnType("longtext")
                    .HasColumnName("AreaDvr_Channel")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AreaName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwSpChannel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_sp_channel");

                entity.Property(e => e.ChannelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ChannelID");

                entity.Property(e => e.ChannelName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommunicationParam)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("communication_param")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CompactName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DvrId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DvrID");

                entity.Property(e => e.EquipAddr)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equip_addr")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.IsCound)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");
            });

            modelBuilder.Entity<GwSpDvrinfo>(entity =>
            {
                entity.HasKey(e => e.DvrId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_sp_dvrinfo");

                entity.Property(e => e.DvrId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DvrID");

                entity.Property(e => e.ChannelNum).HasColumnType("int(11)");

                entity.Property(e => e.CloudMultiple)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CloudSpeed)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Describe)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DvrName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DvrType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ip)
                    .HasColumnType("longtext")
                    .HasColumnName("IP")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PassWord)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Port).HasColumnType("int(11)");

                entity.Property(e => e.UserName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwSpDvrtype>(entity =>
            {
                entity.HasKey(e => e.DvrTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_sp_dvrtype");

                entity.Property(e => e.DvrTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DvrTypeID");

                entity.Property(e => e.ClassName)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DvrTypeName)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwSpGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_sp_group");

                entity.Property(e => e.GroupList)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GwSpMethod>(entity =>
            {
                entity.HasKey(e => e.MethodId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_sp_method");

                entity.Property(e => e.MethodId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MethodID");

                entity.Property(e => e.ClassName)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MethodName)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModulId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ModulID")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GwSpModul>(entity =>
            {
                entity.HasKey(e => e.ModulId)
                    .HasName("PRIMARY");

                entity.ToTable("gw_sp_modul");

                entity.Property(e => e.ModulId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ModulID");

                entity.Property(e => e.ClassName)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DvrTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DvrTypeID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModulName)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwUnityMarkview>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_unity_markview");

                entity.Property(e => e.ResId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ResID");

                entity.Property(e => e.Rotation)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SceneId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SceneID");

                entity.Property(e => e.Vposition)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VPosition")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwUnityModel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_unity_model");

                entity.Property(e => e.BestViewPos)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BestViewRot)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClickCmd)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ClickCMD")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ResId).HasColumnName("ResID");

                entity.Property(e => e.Rotation)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Scale)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SceneId).HasColumnName("SceneID");

                entity.Property(e => e.ToolTip)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValueCmd)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ValueCMD")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Vposition)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VPosition")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WarCmd)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("WarCMD")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwUnityParade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_unity_parade");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.ParadeSpeed).HasDefaultValueSql("'0'");

                entity.Property(e => e.Rotation)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SceneId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SceneID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Vindex)
                    .HasColumnType("int(11)")
                    .HasColumnName("VIndex")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Vposition)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VPosition")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwUnityResource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_unity_resource");

                entity.Property(e => e.BestViewPos)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BestViewRot)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DevIconColor)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DevIconName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DevName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TexName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwUnityScene>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_unity_scene");

                entity.Property(e => e.BundleName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.InitPos)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InitRot)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MinMapSize)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoveSpeed).HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OverLookPos)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OverLookRot)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OverLookSize).HasDefaultValueSql("'0'");

                entity.Property(e => e.ParadeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ParadeID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ParadeSpeed).HasDefaultValueSql("'0'");

                entity.Property(e => e.PymoveSpeed)
                    .HasColumnName("PYMoveSpeed")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PyscaleSpeed)
                    .HasColumnName("PYScaleSpeed")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShowName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SkyBox)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Version)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WalkInitPos)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WalkInitRot)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Channels)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Interval)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GwVideoinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gw_videoinfo");

                entity.Property(e => e.Action)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChannelName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChannelNum)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Path)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rtsp)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("RTSP")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StreamType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwaddinmodule>(entity =>
            {
                entity.ToTable("gwaddinmodule");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClassName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HelpPath)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MultiScreens)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WebPage)
                    .HasColumnType("char(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwassetinfo>(entity =>
            {
                entity.HasKey(e => e.AssetId)
                    .HasName("PRIMARY");

                entity.ToTable("gwassetinfo");

                entity.Property(e => e.AssetId)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("asset_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipDetail)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equip_detail")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipImage)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equip_image")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipLocation)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equip_location")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipName)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("equip_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipType)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("equip_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwbuttonproperty>(entity =>
            {
                entity.HasKey(e => e.Gwkey)
                    .HasName("PRIMARY");

                entity.ToTable("gwbuttonproperty");

                entity.Property(e => e.Gwkey)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("gwkey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gwcommand)
                    .HasColumnType("longtext")
                    .HasColumnName("gwcommand")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gwdatasouce)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("gwdatasouce")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gwremark)
                    .HasColumnType("longtext")
                    .HasColumnName("gwremark")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gwtooltip)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("gwtooltip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gwtype)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("gwtype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwdatarecorditem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwdatarecorditems");

                entity.Property(e => e.DataName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("data_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataType)
                    .HasColumnType("varchar(1)")
                    .HasColumnName("data_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("userName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.YcyxNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("ycyx_no");
            });

            modelBuilder.Entity<Gwdatarecordresult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwdatarecordresult");

                entity.Property(e => e.DataName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("data_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasColumnType("varchar(1)")
                    .HasColumnName("data_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataValue)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("data_value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasColumnName("record_time");

                entity.Property(e => e.YcyxNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("ycyx_no");
            });

            modelBuilder.Entity<Gwdelayaction>(entity =>
            {
                entity.ToTable("gwdelayaction");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.GwAddDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("GW_AddDateTime");

                entity.Property(e => e.GwDelayNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("GW_DelayNum");

                entity.Property(e => e.GwEquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("GW_Equip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GwSetNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("GW_Set_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GwSource)
                    .HasColumnType("int(11)")
                    .HasColumnName("GW_Source");

                entity.Property(e => e.GwStaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("GW_Sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GwState)
                    .HasColumnType("int(11)")
                    .HasColumnName("GW_State");

                entity.Property(e => e.GwUserNm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("GW_UserNm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GwValue)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("GW_Value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwelevatormaintain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwelevatormaintain");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Certificate)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CertificateLevel)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EligibilityScope)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaintainCode)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaintainName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaintainPosition)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerificationTime)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwelevatormarker>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ElevatorNum })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gwelevatormarker");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ElevatorNum)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ElevatorInfo)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ElevatorPlace)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ElevatorPosition)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ElevatorState).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Gwequippage>(entity =>
            {
                entity.ToTable("gwequippages");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.HelpPath)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MultiScreens)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pages)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WebPage)
                    .HasColumnType("char(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwequiptreegroup>(entity =>
            {
                entity.ToTable("gwequiptreegroup");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ParentID")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Gwequiptreeitem>(entity =>
            {
                entity.HasKey(e => new { e.EquipId, e.GroupId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gwequiptreeitem");

                entity.Property(e => e.EquipId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EquipID");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("GroupID");
            });

            modelBuilder.Entity<Gwexproc>(entity =>
            {
                entity.HasKey(e => e.ProcCode)
                    .HasName("PRIMARY");

                entity.ToTable("gwexproc");

                entity.Property(e => e.ProcCode)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("Proc_Code");

                entity.Property(e => e.ProcModule)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Proc_Module")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Proc_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcParm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Proc_parm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwexproccmd>(entity =>
            {
                entity.HasKey(e => new { e.ProcCode, e.CmdNm })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gwexproccmd");

                entity.Property(e => e.ProcCode)
                    .HasColumnType("int(11)")
                    .HasColumnName("proc_code");

                entity.Property(e => e.CmdNm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("cmd_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainInstruction)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("main_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MinorInstruction)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("minor_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Record)
                    .HasColumnType("bit(1)")
                    .HasColumnName("record")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.Value)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwmaintainer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwmaintainer");

                entity.Property(e => e.Company)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.MaintainerInfo)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaintainerName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaintainerPosition)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwmapmarker>(entity =>
            {
                entity.HasKey(e => e.MarkerId)
                    .HasName("PRIMARY");

                entity.ToTable("gwmapmarker");

                entity.Property(e => e.MarkerId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssemblyName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClassFullName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Data)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("GroupID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MarkerName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaxZoom)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MinZoom)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Offset)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Path)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Position)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Xmlns)
                    .HasColumnType("longtext")
                    .HasColumnName("xmlns")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("zIndex")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Gwnavigationproperty>(entity =>
            {
                entity.ToTable("gwnavigationproperty");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AlarmImage)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("alarm_image")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Enable)
                    .HasColumnType("int(11)")
                    .HasColumnName("enable");

                entity.Property(e => e.GuanlianComb)
                    .HasColumnType("longtext")
                    .HasColumnName("guanlian_comb")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NavigateType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("navigate_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NormalImage)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("normal_image")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageComb)
                    .HasColumnType("longtext")
                    .HasColumnName("page_comb")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwplan>(entity =>
            {
                entity.HasKey(e => e.PlanNo)
                    .HasName("PRIMARY");

                entity.ToTable("gwplan");

                entity.Property(e => e.PlanNo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.IsModel).HasColumnType("int(11)");

                entity.Property(e => e.LastEditor)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwplanrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwplanrecord");

                entity.Property(e => e.Content)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.Editor)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanNo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwproccycletable>(entity =>
            {
                entity.HasKey(e => new { e.TableId, e.DoOrder })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gwproccycletable");

                entity.Property(e => e.TableId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TableID");

                entity.Property(e => e.DoOrder).HasColumnType("int(11)");

                entity.Property(e => e.CmdNm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("cmd_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.ProcCode)
                    .HasColumnType("int(11)")
                    .HasColumnName("proc_code")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SetNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("set_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SleepTime).HasColumnType("int(11)");

                entity.Property(e => e.SleepUnit)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwproccycletlist>(entity =>
            {
                entity.HasKey(e => e.TableId)
                    .HasName("PRIMARY");

                entity.ToTable("gwproccycletlist");

                entity.Property(e => e.TableId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("TableID");

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.CycleMustFinish).HasColumnType("int(11)");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MaxCycleNum)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reference)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'new task'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZhenDianDo).HasColumnType("int(11)");

                entity.Property(e => e.ZhidingDo).HasColumnType("int(11)");

                entity.Property(e => e.ZhidingTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Gwprocspectable>(entity =>
            {
                entity.ToTable("gwprocspectable");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.DateName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.TableId)
                    .HasColumnType("longtext")
                    .HasColumnName("TableID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwproctimeeqptable>(entity =>
            {
                entity.ToTable("gwproctimeeqptable");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.SetNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("set_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TableId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TableID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TimeDur).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwproctimesystable>(entity =>
            {
                entity.ToTable("gwproctimesystable");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.CmdNm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("cmd_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcCode)
                    .HasColumnType("int(11)")
                    .HasColumnName("proc_code")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TableId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TableID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TimeDur).HasColumnType("datetime");
            });

            modelBuilder.Entity<Gwproctimetlist>(entity =>
            {
                entity.HasKey(e => e.TableId)
                    .HasName("PRIMARY");

                entity.ToTable("gwproctimetlist");

                entity.Property(e => e.TableId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("TableID");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reference)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'new schedule'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwprocweektable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwprocweektable");

                entity.Property(e => e.Fri)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mon)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sat)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sun)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Thurs)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tues)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Wed)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwreportinfo>(entity =>
            {
                entity.ToTable("gwreportinfo");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Describe)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DllName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReportName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwrole>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("gwrole");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BrowseEquips)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BrowsePages)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ControlEquips)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ControlEquipsUnit)
                    .HasColumnType("longtext")
                    .HasColumnName("ControlEquips_Unit")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("longtext")
                    .HasColumnName("remark")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecialBrowseEquip)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SystemModule)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwsnapshotconfig>(entity =>
            {
                entity.ToTable("gwsnapshotconfig");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IconRes)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsShow).HasColumnType("int(11)");

                entity.Property(e => e.MaxCount).HasColumnType("int(11)");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SnapshotLevelMax).HasColumnType("int(11)");

                entity.Property(e => e.SnapshotLevelMin).HasColumnType("int(11)");

                entity.Property(e => e.SnapshotName)
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwuser>(entity =>
            {
                entity.ToTable("gwuser");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.AutoInspectionPages)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ControlLevel)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HomePages)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OppoUser)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("oppoUser")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Roles)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwwebmapmarker>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gwwebmapmarker");

                entity.Property(e => e.BindCmd)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Data)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Destination)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EnableRotation).HasColumnType("int(11)");

                entity.Property(e => e.MarkerId).HasColumnType("int(11)");

                entity.Property(e => e.MarkerName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MarkerType).HasPrecision(18);

                entity.Property(e => e.OffSet)
                    .HasColumnType("char(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Position)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectName)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Size)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Template)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwzichanrecord>(entity =>
            {
                entity.ToTable("gwzichanrecord");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.ItemAddDate).HasColumnType("datetime");

                entity.Property(e => e.ItemAddMan)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pictures)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WeiHuDate).HasColumnType("datetime");

                entity.Property(e => e.WeiHuName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WeiHuRecord)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZiChanId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ZiChanID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwzichantable>(entity =>
            {
                entity.HasKey(e => e.ZiChanId)
                    .HasName("PRIMARY");

                entity.ToTable("gwzichantable");

                entity.Property(e => e.ZiChanId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ZiChanID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BaoXiuQiXian).HasColumnType("datetime");

                entity.Property(e => e.ChangJia)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GouMaiDate).HasColumnType("datetime");

                entity.Property(e => e.LastEditDate).HasColumnType("datetime");

                entity.Property(e => e.LastEditMan)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LianxiMail)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LianxiRen)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LianxiTel)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RelatedPic)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("related_pic")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WeiHuCycle).HasColumnType("int(11)");

                entity.Property(e => e.WeiHuDate).HasColumnType("datetime");

                entity.Property(e => e.ZiChanImage)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZiChanName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZiChanSite)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZiChanType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gwzichantableexcolumn>(entity =>
            {
                entity.HasKey(e => e.ColumnNo)
                    .HasName("PRIMARY");

                entity.ToTable("gwzichantableexcolumn");

                entity.Property(e => e.ColumnNo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ColumnName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Hsncardno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hsncardno");

                entity.Property(e => e.CardCode)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("Card_Code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("Card_No")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n");
            });

            modelBuilder.Entity<IotDevice>(entity =>
            {
                entity.HasKey(e => e.DeviceId)
                    .HasName("PRIMARY");

                entity.ToTable("iot_device");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("deviceId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AreaName)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("areaName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BridgeId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("bridgeId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BuildName)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("buildName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeviceType)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("deviceType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeviceTypeId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("deviceTypeId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeviceTypeName)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("deviceTypeName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equipNo");

                entity.Property(e => e.FwVersion)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("fwVersion")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GatewayId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("gatewayId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Height)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("height")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HwVersion)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("hwVersion")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Imsi)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("imsi")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("lastModifiedTime");

                entity.Property(e => e.Lnglat)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("lnglat")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Location)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("location")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mac)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("mac")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ManufactureId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("manufactureId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ManufactureName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("manufactureName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("model")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NodeId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("nodeId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NodeType)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("nodeType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProtocolType)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("protocolType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RadiusIp)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("radiusIp")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReportData)
                    .HasColumnType("longtext")
                    .HasColumnName("reportData")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SerialNumber)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("serialNumber")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SigVersion)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("sigVersion")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SwVersion)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("swVersion")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SystemType)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("systemType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SystemTypeName)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("systemTypeName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitName)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("unitName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<IotDeviceservice>(entity =>
            {
                entity.HasKey(e => new { e.ServiceId, e.DeviceId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("iot_deviceservice");

                entity.Property(e => e.ServiceId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("serviceId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("deviceId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrentDate)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("currentDate")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("longtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReportLimit).HasColumnName("reportLimit");

                entity.Property(e => e.ReportMode)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("reportMode")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReportTimespan)
                    .HasColumnType("int(11)")
                    .HasColumnName("reportTimespan");

                entity.Property(e => e.ServiceModel)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("serviceModel")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceModelId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("serviceModelId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceModelName)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("serviceModelName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceOption)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("serviceOption")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceType)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("serviceType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.YcYxSetNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("ycYxSetNo");
            });

            modelBuilder.Entity<IotDeviceservicemodel>(entity =>
            {
                entity.HasKey(e => e.ServiceModelId)
                    .HasName("PRIMARY");

                entity.ToTable("iot_deviceservicemodel");

                entity.Property(e => e.ServiceModelId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("serviceModelId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceModelName)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("serviceModelName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<IotDevicetype>(entity =>
            {
                entity.HasKey(e => e.DeviceTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("iot_devicetype");

                entity.Property(e => e.DeviceTypeId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("deviceTypeId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DevuceTypeName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("devuceTypeName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<KingkangCardatdoor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kingkang_cardatdoor");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<KingkangDept>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kingkang_dept");

                entity.Property(e => e.DeptId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dept_id");

                entity.Property(e => e.DeptNm)
                    .IsRequired()
                    .HasColumnType("varchar(24)")
                    .HasColumnName("dept_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<KingkangMember>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PRIMARY");

                entity.ToTable("kingkang_member");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("card_id");

                entity.Property(e => e.Addr)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("addr")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardCode)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_code")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CardSection)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_section")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DeptId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dept_id");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pwd)
                    .HasColumnType("int(11)")
                    .HasColumnName("pwd")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tel)
                    .HasColumnType("varchar(16)")
                    .HasColumnName("tel")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<KingkangTmg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kingkang_tmg");

                entity.HasIndex(e => e.GroupId, "IDXKingKang_TmG_group_id");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupNm)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("group_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.W1Tm1Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_tm1_bgn");

                entity.Property(e => e.W1Tm1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_tm1_end");

                entity.Property(e => e.W1Tm2Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_tm2_bgn");

                entity.Property(e => e.W1Tm2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_tm2_end");

                entity.Property(e => e.W1Tm3Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_tm3_bgn");

                entity.Property(e => e.W1Tm3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_tm3_end");

                entity.Property(e => e.W1Tm4Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_tm4_bgn");

                entity.Property(e => e.W1Tm4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w1_tm4_end");

                entity.Property(e => e.W2Tm1Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_tm1_bgn");

                entity.Property(e => e.W2Tm1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_tm1_end");

                entity.Property(e => e.W2Tm2Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_tm2_bgn");

                entity.Property(e => e.W2Tm2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_tm2_end");

                entity.Property(e => e.W2Tm3Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_tm3_bgn");

                entity.Property(e => e.W2Tm3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_tm3_end");

                entity.Property(e => e.W2Tm4Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_tm4_bgn");

                entity.Property(e => e.W2Tm4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w2_tm4_end");

                entity.Property(e => e.W3Tm1Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_tm1_bgn");

                entity.Property(e => e.W3Tm1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_tm1_end");

                entity.Property(e => e.W3Tm2Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_tm2_bgn");

                entity.Property(e => e.W3Tm2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_tm2_end");

                entity.Property(e => e.W3Tm3Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_tm3_bgn");

                entity.Property(e => e.W3Tm3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_tm3_end");

                entity.Property(e => e.W3Tm4Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_tm4_bgn");

                entity.Property(e => e.W3Tm4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w3_tm4_end");

                entity.Property(e => e.W4Tm1Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_tm1_bgn");

                entity.Property(e => e.W4Tm1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_tm1_end");

                entity.Property(e => e.W4Tm2Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_tm2_bgn");

                entity.Property(e => e.W4Tm2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_tm2_end");

                entity.Property(e => e.W4Tm3Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_tm3_bgn");

                entity.Property(e => e.W4Tm3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_tm3_end");

                entity.Property(e => e.W4Tm4Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_tm4_bgn");

                entity.Property(e => e.W4Tm4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w4_tm4_end");

                entity.Property(e => e.W5Tm1Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_tm1_bgn");

                entity.Property(e => e.W5Tm1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_tm1_end");

                entity.Property(e => e.W5Tm2Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_tm2_bgn");

                entity.Property(e => e.W5Tm2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_tm2_end");

                entity.Property(e => e.W5Tm3Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_tm3_bgn");

                entity.Property(e => e.W5Tm3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_tm3_end");

                entity.Property(e => e.W5Tm4Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_tm4_bgn");

                entity.Property(e => e.W5Tm4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w5_tm4_end");

                entity.Property(e => e.W6Tm1Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_tm1_bgn");

                entity.Property(e => e.W6Tm1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_tm1_end");

                entity.Property(e => e.W6Tm2Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_tm2_bgn");

                entity.Property(e => e.W6Tm2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_tm2_end");

                entity.Property(e => e.W6Tm3Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_tm3_bgn");

                entity.Property(e => e.W6Tm3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_tm3_end");

                entity.Property(e => e.W6Tm4Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_tm4_bgn");

                entity.Property(e => e.W6Tm4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w6_tm4_end");

                entity.Property(e => e.W7Tm1Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_tm1_bgn");

                entity.Property(e => e.W7Tm1End)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_tm1_end");

                entity.Property(e => e.W7Tm2Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_tm2_bgn");

                entity.Property(e => e.W7Tm2End)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_tm2_end");

                entity.Property(e => e.W7Tm3Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_tm3_bgn");

                entity.Property(e => e.W7Tm3End)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_tm3_end");

                entity.Property(e => e.W7Tm4Bgn)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_tm4_bgn");

                entity.Property(e => e.W7Tm4End)
                    .HasColumnType("datetime")
                    .HasColumnName("w7_tm4_end");
            });

            modelBuilder.Entity<Matafun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("matafun");

                entity.Property(e => e.Mainfunid)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("mainfunid")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mainfunnm)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("mainfunnm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Matatype)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("matatype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Minfunid)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("minfunid")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Minfunnm)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("minfunnm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Mataobj>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mataobj");

                entity.Property(e => e.Equiptype)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("equiptype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Matatype)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("matatype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Matasubtype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("matasubtype");

                entity.Property(e => e.Equipsubtype)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("equipsubtype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Equiptype)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("equiptype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Matasymb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("matasymb");

                entity.Property(e => e.Mataarray)
                    .HasColumnType("varchar(4)")
                    .HasColumnName("MATAARRAY")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mataname)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("MATANAME")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Matapic)
                    .HasColumnType("varchar(12)")
                    .HasColumnName("MATAPIC")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Matatype)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("MATATYPE")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Nsladmission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nsladmission");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasColumnType("varchar(4)")
                    .HasColumnName("Card_No")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.Permission)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Reader)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n");
            });

            modelBuilder.Entity<Nslcardno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nslcardno");

                entity.Property(e => e.CardCode)
                    .IsRequired()
                    .HasColumnType("varchar(8)")
                    .HasColumnName("Card_Code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasColumnType("varchar(4)")
                    .HasColumnName("Card_No")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PinCode)
                    .HasColumnType("varchar(4)")
                    .HasColumnName("Pin_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n");

                entity.Property(e => e.WeekGroup)
                    .IsRequired()
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Nsldateg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nsldateg");

                entity.Property(e => e.AdmitBgn1)
                    .IsRequired()
                    .HasColumnType("varchar(4)")
                    .HasColumnName("Admit_Bgn1")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdmitBgn2)
                    .HasColumnType("varchar(4)")
                    .HasColumnName("Admit_Bgn2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdmitEnd1)
                    .HasColumnType("varchar(4)")
                    .HasColumnName("Admit_End1")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdmitEnd2)
                    .HasColumnType("varchar(4)")
                    .HasColumnName("Admit_End2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("operationequip");

                entity.Property(e => e.StaNm)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("sta_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipId)
                    .HasColumnType("varchar(16)")
                    .HasColumnName("equip_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNm)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("equip_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Equiptype)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasColumnName("equiptype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Operationlog>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("PRIMARY");

                entity.ToTable("operationlog");

                entity.Property(e => e.OperationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OPERATION_ID");

                entity.Property(e => e.OperationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OPERATION_DATE");

                entity.Property(e => e.OperationPersion)
                    .HasColumnType("varchar(16)")
                    .HasColumnName("OPERATION_PERSION")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationTitle)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OPERATION_TITLE")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaNm)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("sta_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Operationrec>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("PRIMARY");

                entity.ToTable("operationrec");

                entity.Property(e => e.OperationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OPERATION_ID");

                entity.Property(e => e.OperationComment)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OPERATION_COMMENT")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OPERATION_DATE");

                entity.Property(e => e.OperationPersion)
                    .HasColumnType("varchar(16)")
                    .HasColumnName("OPERATION_PERSION")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationProcedure).HasColumnName("OPERATION_PROCEDURE");

                entity.Property(e => e.OperationTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OPERATION_TITLE")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PersonnelFaceimage>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PRIMARY");

                entity.ToTable("personnel.faceimage");

                entity.Property(e => e.PkId).HasColumnType("int(11)");

                entity.Property(e => e.AlarmId)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("alarmId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FlagId)
                    .HasColumnType("int(11)")
                    .HasColumnName("flagId");

                entity.Property(e => e.HashId).HasColumnType("bigint(20)");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImageUri)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("imageUri")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Race)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("race")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SourceId)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("sourceId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SourceType)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("sourceType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Rawequip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rawequip");

                entity.Property(e => e.AccCyc)
                    .HasColumnType("int(11)")
                    .HasColumnName("acc_cyc")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AlarmScheme)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_scheme")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attrib)
                    .HasColumnType("int(11)")
                    .HasColumnName("attrib")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CommunicationDrv)
                    .HasColumnType("varchar(16)")
                    .HasColumnName("communication_drv")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommunicationParam)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("communication_param")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommunicationTimeParam)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("communication_time_param")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommunicatonType)
                    .HasColumnType("int(11)")
                    .HasColumnName("communicaton_type")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Contacted)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("contacted")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipAddr)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("equip_addr")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipDetail)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equip_detail")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventWav)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("event_wav")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LocalAddr)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("local_addr")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutOfContact)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("out_of_contact")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcAdvice)
                    .HasColumnType("varchar(254)")
                    .HasColumnName("proc_advice")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RawEquipNm)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("raw_equip_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RawEquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("raw_equip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RelatedPic)
                    .HasColumnType("varchar(16)")
                    .HasColumnName("related_pic")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tabname)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("tabname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Rawycp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rawycp");

                entity.Property(e => e.AlarmAcceptableTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_acceptable_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmRepeatTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_repeat_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmScheme)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_scheme")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CurveRcd)
                    .HasColumnType("bit(1)")
                    .HasColumnName("curve_rcd")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LvlLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("lvl_level");

                entity.Property(e => e.MainInstruction)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("main_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mapping)
                    .HasColumnType("bit(1)")
                    .HasColumnName("mapping")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.MinorInstruction)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("minor_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutmaxEvt)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("outmax_evt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutminEvt)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("outmin_evt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhysicMax)
                    .HasColumnName("physic_max")
                    .HasDefaultValueSql("'1000'");

                entity.Property(e => e.PhysicMin)
                    .HasColumnName("physic_min")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProcAdvice)
                    .HasColumnType("varchar(254)")
                    .HasColumnName("proc_advice")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RawEquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("raw_equip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RawYcNm)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("raw_yc_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RawYcNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("raw_yc_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RelatedPic)
                    .HasColumnType("int(11)")
                    .HasColumnName("related_pic")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.RestoreAcceptableTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("restore_acceptable_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RestoreMax).HasColumnName("restore_max");

                entity.Property(e => e.RestoreMin).HasColumnName("restore_min");

                entity.Property(e => e.SafeBgn)
                    .HasColumnType("datetime")
                    .HasColumnName("safe_bgn");

                entity.Property(e => e.SafeEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("safe_end");

                entity.Property(e => e.ValMax).HasColumnName("val_max");

                entity.Property(e => e.ValMin).HasColumnName("val_min");

                entity.Property(e => e.ValTrait)
                    .HasColumnType("int(11)")
                    .HasColumnName("val_trait")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WaveFile)
                    .HasColumnType("varchar(24)")
                    .HasColumnName("wave_file")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_acceptable_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmRepeatTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_repeat_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmScheme)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_scheme")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Evt01)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("evt_01")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Evt10)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("evt_10")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Initval)
                    .HasColumnType("int(11)")
                    .HasColumnName("initval")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Inversion)
                    .HasColumnType("bit(1)")
                    .HasColumnName("inversion")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LevelD)
                    .HasColumnType("int(11)")
                    .HasColumnName("level_d");

                entity.Property(e => e.LevelR)
                    .HasColumnType("int(11)")
                    .HasColumnName("level_r");

                entity.Property(e => e.MainInstruction)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("main_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MinorInstruction)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("minor_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcAdviceD)
                    .HasColumnType("varchar(254)")
                    .HasColumnName("proc_advice_d")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcAdviceR)
                    .HasColumnType("varchar(254)")
                    .HasColumnName("proc_advice_r")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RawEquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("raw_equip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RawYxNm)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("raw_yx_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RawYxNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("raw_yx_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RelatedPic)
                    .HasColumnType("int(11)")
                    .HasColumnName("related_pic")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.RestoreAcceptableTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("restore_acceptable_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SafeBgn)
                    .HasColumnType("datetime")
                    .HasColumnName("safe_bgn");

                entity.Property(e => e.SafeEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("safe_end");

                entity.Property(e => e.ValTrait)
                    .HasColumnType("int(11)")
                    .HasColumnName("val_trait")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WaveFile)
                    .HasColumnType("varchar(24)")
                    .HasColumnName("wave_file")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Resdscp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("resdscp");

                entity.Property(e => e.ResIdenti)
                    .HasColumnType("varchar(240)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResName)
                    .HasColumnType("varchar(48)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Rtuyxtab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rtuyxtab");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("varchar(3)")
                    .HasColumnName("equip_no")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Flag)
                    .HasColumnType("bit(1)")
                    .HasColumnName("flag")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.StaN)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("sta_n")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.YxNo)
                    .HasColumnType("varchar(3)")
                    .HasColumnName("yx_no")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Sc302encode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sc302encode");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Door)
                    .IsRequired()
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNo)
                    .IsRequired()
                    .HasColumnType("varchar(2)")
                    .HasColumnName("equip_no")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pin)
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .IsRequired()
                    .HasColumnType("varchar(2)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'01'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TimeGroup)
                    .IsRequired()
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Sc302timeg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sc302timeg");

                entity.Property(e => e.EquipNo)
                    .IsRequired()
                    .HasColumnType("varchar(2)")
                    .HasColumnName("equip_no")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fri)
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mon)
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sat)
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .IsRequired()
                    .HasColumnType("varchar(2)")
                    .HasColumnName("sta_n")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sun)
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Thu)
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TimeGroup)
                    .IsRequired()
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tue)
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Wed)
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Setevt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("setevt");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("event")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gwsource)
                    .HasColumnType("longtext")
                    .HasColumnName("gwsource")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("operator")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<Setparm>(entity =>
            {
                entity.HasKey(e => new { e.EquipNo, e.SetNo })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("setparm");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.SetNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("set_no");

                entity.Property(e => e.Action)
                    .HasColumnType("varchar(16)")
                    .HasColumnName("action")
                    .HasDefaultValueSql("'设置'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Canexecution)
                    .HasColumnType("bit(1)")
                    .HasColumnName("canexecution")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.EnableVoice)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.MainInstruction)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("main_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MinorInstruction)
                    .HasColumnType("longtext")
                    .HasColumnName("minor_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QrEquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("qr_equip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Record)
                    .HasColumnType("bit(1)")
                    .HasColumnName("record")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SetNm)
                    .HasColumnType("longtext")
                    .HasColumnName("set_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SetType)
                    .HasColumnType("varchar(1)")
                    .HasColumnName("set_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value)
                    .HasColumnType("longtext")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VoiceKeys)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Smsreqcont>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("smsreqcont");

                entity.Property(e => e.EquipNo).HasColumnType("int(11)");

                entity.Property(e => e.MainInstruction)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("main_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MinorInstruction)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("minor_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReqId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReqID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Task)
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.YcYxNo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Smsreqlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("smsreqlist");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReqId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReqID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqName)
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Spealmreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spealmreport");

                entity.Property(e => e.Administrator)
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BeginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("begin_time");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time");

                entity.Property(e => e.GroupNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Remark)
                    .HasColumnType("longtext")
                    .HasColumnName("remark")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("station");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StaNm)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("sta_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaType)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_type")
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
                    .HasColumnType("bit(1)")
                    .HasColumnName("opendoor1")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Opendoor2)
                    .HasColumnType("bit(1)")
                    .HasColumnName("opendoor2")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Opendoor3)
                    .HasColumnType("bit(1)")
                    .HasColumnName("opendoor3")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Opendoor4)
                    .HasColumnType("bit(1)")
                    .HasColumnName("opendoor4")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Outdoor1)
                    .HasColumnType("bit(1)")
                    .HasColumnName("outdoor1")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Outdoor2)
                    .HasColumnType("bit(1)")
                    .HasColumnName("outdoor2")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Outdoor3)
                    .HasColumnType("bit(1)")
                    .HasColumnName("outdoor3")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Outdoor4)
                    .HasColumnType("bit(1)")
                    .HasColumnName("outdoor4")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Perpintz1)
                    .HasColumnType("int(11)")
                    .HasColumnName("perpintz1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Perpintz2)
                    .HasColumnType("int(11)")
                    .HasColumnName("perpintz2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Perpintz3)
                    .HasColumnType("int(11)")
                    .HasColumnName("perpintz3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Perpintz4)
                    .HasColumnType("int(11)")
                    .HasColumnName("perpintz4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Secpintz1)
                    .HasColumnType("int(11)")
                    .HasColumnName("secpintz1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Secpintz2)
                    .HasColumnType("int(11)")
                    .HasColumnName("secpintz2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Secpintz3)
                    .HasColumnType("int(11)")
                    .HasColumnName("secpintz3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Secpintz4)
                    .HasColumnType("int(11)")
                    .HasColumnName("secpintz4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WeekdataG)
                    .HasColumnType("int(11)")
                    .HasColumnName("weekdataG")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Sycardno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sycardno");

                entity.Property(e => e.App)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("app")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardNo)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("card_no")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cardid)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("cardid")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cardtype)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("cardtype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pin)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("pin")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
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
                    .HasColumnType("varchar(128)")
                    .HasColumnName("confirmname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Confirmremark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("confirmremark")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Confirmtime)
                    .HasColumnType("datetime")
                    .HasColumnName("confirmtime");

                entity.Property(e => e.Event)
                    .HasColumnType("longtext")
                    .HasColumnName("event")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("GUID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<Sytimeg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sytimeg");

                entity.Property(e => e.AdmitBgn)
                    .HasColumnType("varchar(4)")
                    .HasColumnName("Admit_Bgn")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdmitEnd)
                    .HasColumnType("varchar(4)")
                    .HasColumnName("Admit_End")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TimeGroup)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TcInoutl>(entity =>
            {
                entity.ToTable("tc_inoutls");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.CarNo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Car_No")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarType)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Car_Type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardNo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Card_no")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CtrlNoI)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Ctrl_No_i")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CtrlNoInVideo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Ctrl_No_InVideo")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CtrlNoO)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Ctrl_No_o")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CtrlNoOutVideo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Ctrl_No_OutVideo")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("In_time");

                entity.Property(e => e.OutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Out_time");
            });

            modelBuilder.Entity<Telphone>(entity =>
            {
                entity.HasKey(e => new { e.StaN, e.EquipNo, e.PhoneNum })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("telphone");

                entity.Property(e => e.StaN)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("sta_n")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("equip_no")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneNum)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("phone_num")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallMachineFinalKey)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("call_machine_final_key")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallMachineFunctKey)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("call_machine_funct_key")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DialInterval)
                    .HasColumnType("int(11)")
                    .HasColumnName("dial_interval")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DialRepeat)
                    .HasColumnType("int(11)")
                    .HasColumnName("dial_repeat")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IfCallMachine)
                    .HasColumnType("bit(1)")
                    .HasColumnName("if_call_machine")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Permit)
                    .HasColumnType("bit(1)")
                    .HasColumnName("permit")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.WaitBeforeSpeak)
                    .HasColumnType("int(11)")
                    .HasColumnName("wait_before_speak")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Visitorrecord>(entity =>
            {
                entity.ToTable("visitorrecord");

                entity.HasIndex(e => e.Id, "IDXVisitorRecord_ID");

                entity.HasIndex(e => e.LicenseCode, "IDXVisitorRecord_LicenseCode");

                entity.HasIndex(e => e.PeerNum, "IDXVisitorRecord_PeerNum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Company)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Event)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IssuingAgency)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LicEndDate).HasColumnType("datetime");

                entity.Property(e => e.LicStartDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseCode)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LicenseType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nation)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Photo)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Qrcode)
                    .HasColumnType("longtext")
                    .HasColumnName("QRCode")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sex)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sex")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VisitingTime).HasColumnType("datetime");

                entity.Property(e => e.Visitor)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Weekalmreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("weekalmreport");

                entity.Property(e => e.Administrator)
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BeginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("begin_time");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time");

                entity.Property(e => e.GroupNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Remark)
                    .HasColumnType("longtext")
                    .HasColumnName("remark")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WeekDay)
                    .HasColumnType("int(11)")
                    .HasColumnName("week_day")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Weekdatag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("weekdatag");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mon)
                    .HasColumnType("int(11)")
                    .HasColumnName("mon")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sat)
                    .HasColumnType("int(11)")
                    .HasColumnName("sat")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sun)
                    .HasColumnType("int(11)")
                    .HasColumnName("sun")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Thi)
                    .HasColumnType("int(11)")
                    .HasColumnName("thi")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tue)
                    .HasColumnType("int(11)")
                    .HasColumnName("tue")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tur)
                    .HasColumnType("int(11)")
                    .HasColumnName("tur")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Wes)
                    .HasColumnType("int(11)")
                    .HasColumnName("wes")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Welcomingspeech>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("welcomingspeech");

                entity.Property(e => e.BgImage)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Jsoncontent)
                    .HasColumnType("text")
                    .HasColumnName("JSONContent")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SiginalVal)
                    .HasColumnType("text")
                    .HasColumnName("siginalVal")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Woacceptorder>(entity =>
            {
                entity.ToTable("woacceptorder");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Claim)
                    .HasColumnType("int(11)")
                    .HasColumnName("claim");

                entity.Property(e => e.CreatedTime)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("created_time")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrentProcessor)
                    .HasColumnType("int(11)")
                    .HasColumnName("current_processor");

                entity.Property(e => e.Personnel)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("personnel")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TransferPersonnel)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("transfer_personnel")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkOrderId)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("work_order_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Woattachment>(entity =>
            {
                entity.ToTable("woattachment");

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedTime)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("created_time")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("extension")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SaveDate)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasColumnName("save_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkOrderId)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("work_order_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Womainfeedbackattachment>(entity =>
            {
                entity.ToTable("womainfeedbackattachment");

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("extension")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FeedbackId)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("feedback_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SaveDate)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasColumnName("save_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Womainfeedbackconfirm>(entity =>
            {
                entity.ToTable("womainfeedbackconfirm");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("creator")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FeedbackId)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("feedback_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("longtext")
                    .HasColumnName("remark")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.WorkOrderId)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("work_order_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Womaintenancefeedback>(entity =>
            {
                entity.ToTable("womaintenancefeedback");

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AcceptOrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("accept_order_id");

                entity.Property(e => e.CauseIssue)
                    .HasColumnType("longtext")
                    .HasColumnName("cause_issue")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedTime)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("created_time")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasColumnName("level");

                entity.Property(e => e.MaintenanceTime)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("maintenance_time")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcessContent)
                    .HasColumnType("longtext")
                    .HasColumnName("process_content")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Worecord>(entity =>
            {
                entity.ToTable("worecord");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedTime)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("created_time")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("creator")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkOrderId)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("work_order_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Workorder>(entity =>
            {
                entity.ToTable("workorder");

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CompletedTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("completed_time")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("content")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedTime)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("created_time")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("creator")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipType)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("equip_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasColumnName("level");

                entity.Property(e => e.MaintenanceSite)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("maintenance_site")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaintenanceTime)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("maintenance_time")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifiedTime)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("modified_time")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reason)
                    .HasColumnType("longtext")
                    .HasColumnName("reason")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.Topic)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("topic")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Workstation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("workstation");

                entity.Property(e => e.NetAddr)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("net_addr")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StaNm)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("sta_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaType)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("sta_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubPath)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("sub_path")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ycp>(entity =>
            {
                entity.HasKey(e => new { e.EquipNo, e.YcNo })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("ycp");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.YcNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("yc_no");

                entity.Property(e => e.AlarmAcceptableTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_acceptable_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmRepeatTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_repeat_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmRiseCycle)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmScheme)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_scheme")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmShield)
                    .HasColumnType("longtext")
                    .HasColumnName("alarm_shield")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurveLimit)
                    .HasColumnName("curve_limit")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CurveRcd)
                    .HasColumnType("bit(1)")
                    .HasColumnName("curve_rcd")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LvlLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("lvl_level");

                entity.Property(e => e.MainInstruction)
                    .HasColumnType("varchar(254)")
                    .HasColumnName("main_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mapping)
                    .HasColumnType("bit(1)")
                    .HasColumnName("mapping")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.MinorInstruction)
                    .HasColumnType("varchar(254)")
                    .HasColumnName("minor_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutmaxEvt)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("outmax_evt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutminEvt)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("outmin_evt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhysicMax)
                    .HasColumnName("physic_max")
                    .HasDefaultValueSql("'1000'");

                entity.Property(e => e.PhysicMin)
                    .HasColumnName("physic_min")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlanNo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcAdvice)
                    .HasColumnType("varchar(254)")
                    .HasColumnName("proc_advice")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RelatedPic)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("related_pic")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RelatedVideo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("related_video")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RestoreAcceptableTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("restore_acceptable_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RestoreMax).HasColumnName("restore_max");

                entity.Property(e => e.RestoreMin).HasColumnName("restore_min");

                entity.Property(e => e.SafeBgn)
                    .HasColumnType("datetime")
                    .HasColumnName("safe_bgn")
                    .HasDefaultValueSql("'2001-01-01 00:00:00'");

                entity.Property(e => e.SafeEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("safe_end")
                    .HasDefaultValueSql("'2001-01-01 00:00:00'");

                entity.Property(e => e.SafeTime)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("unit")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValMax).HasColumnName("val_max");

                entity.Property(e => e.ValMin).HasColumnName("val_min");

                entity.Property(e => e.ValTrait)
                    .HasColumnType("int(11)")
                    .HasColumnName("val_trait")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WaveFile)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("wave_file")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.YcMax)
                    .HasColumnName("yc_max")
                    .HasDefaultValueSql("'1000'");

                entity.Property(e => e.YcMin)
                    .HasColumnName("yc_min")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.YcNm)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("yc_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZiChanId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ZiChanID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ycyxevt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ycyxevt");

                entity.Property(e => e.AlarmState).HasColumnType("int(11)");

                entity.Property(e => e.Alarmlevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarmlevel");

                entity.Property(e => e.Confirmname)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("confirmname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Confirmremark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("confirmremark")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Confirmtime)
                    .HasColumnType("datetime")
                    .HasColumnName("confirmtime");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("event")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("GUID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcRec)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("proc_rec")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.WuBao)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.YcyxNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("ycyx_no");

                entity.Property(e => e.YcyxType)
                    .IsRequired()
                    .HasColumnType("varchar(1)")
                    .HasColumnName("ycyx_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ycyxevtreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ycyxevtreport");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.IndexNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("index_num")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n");

                entity.Property(e => e.YcyxNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("ycyx_no");

                entity.Property(e => e.YcyxType)
                    .IsRequired()
                    .HasColumnType("varchar(1)")
                    .HasColumnName("ycyx_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Yxp>(entity =>
            {
                entity.HasKey(e => new { e.EquipNo, e.YxNo })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("yxp");

                entity.Property(e => e.EquipNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("equip_no");

                entity.Property(e => e.YxNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("yx_no");

                entity.Property(e => e.AlarmAcceptableTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_acceptable_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmRepeatTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_repeat_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmRiseCycle)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmScheme)
                    .HasColumnType("int(11)")
                    .HasColumnName("alarm_scheme")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlarmShield)
                    .HasColumnType("longtext")
                    .HasColumnName("alarm_shield")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurveRcd)
                    .HasColumnType("bit(1)")
                    .HasColumnName("curve_rcd")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Evt01)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("evt_01")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Evt10)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("evt_10")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Initval)
                    .HasColumnType("int(11)")
                    .HasColumnName("initval")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Inversion)
                    .HasColumnType("bit(1)")
                    .HasColumnName("inversion")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LevelD)
                    .HasColumnType("int(11)")
                    .HasColumnName("level_d");

                entity.Property(e => e.LevelR)
                    .HasColumnType("int(11)")
                    .HasColumnName("level_r");

                entity.Property(e => e.MainInstruction)
                    .HasColumnType("varchar(254)")
                    .HasColumnName("main_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MinorInstruction)
                    .HasColumnType("varchar(254)")
                    .HasColumnName("minor_instruction")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanNo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcAdviceD)
                    .HasColumnType("varchar(254)")
                    .HasColumnName("proc_advice_d")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcAdviceR)
                    .HasColumnType("varchar(254)")
                    .HasColumnName("proc_advice_r")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RelatedPic)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("related_pic")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RelatedVideo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("related_video")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve1)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve2)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reserve3)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RestoreAcceptableTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("restore_acceptable_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SafeBgn)
                    .HasColumnType("datetime")
                    .HasColumnName("safe_bgn")
                    .HasDefaultValueSql("'2001-01-01 00:00:00'");

                entity.Property(e => e.SafeEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("safe_end")
                    .HasDefaultValueSql("'2001-01-01 00:00:00'");

                entity.Property(e => e.SafeTime)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StaN)
                    .HasColumnType("int(11)")
                    .HasColumnName("sta_n")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ValTrait)
                    .HasColumnType("int(11)")
                    .HasColumnName("val_trait")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WaveFile)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("wave_file")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.YxNm)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("yx_nm")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZiChanId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ZiChanID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
