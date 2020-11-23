using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwMjDoorinfo
    {
        public int EquipNo { get; set; }
        public int DoorId { get; set; }
        public string Path { get; set; }
        public string DoorName { get; set; }
        public string RelatedVideo { get; set; }
        public string ZiChanId { get; set; }
        public string PlanNo { get; set; }
        public string Statue { get; set; }
        public bool AttendanceLocusFlag { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string Reserve4 { get; set; }
    }
}
