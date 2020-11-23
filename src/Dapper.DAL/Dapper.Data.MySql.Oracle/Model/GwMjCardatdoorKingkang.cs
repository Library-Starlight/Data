using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwMjCardatdoorKingkang
    {
        public int? EquipNo { get; set; }
        public int? DoorId { get; set; }
        public int? CardId { get; set; }
        public int? TimeZoneId { get; set; }
        public bool HolidayFlag { get; set; }
        public bool AntiSubmarineBackFlag { get; set; }
        public bool MasterCardFlag { get; set; }
        public bool WrittenFlag { get; set; }
    }
}
