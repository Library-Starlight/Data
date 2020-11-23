using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwMjTrafficGroupatdoorKingkang
    {
        public int? EquipNo { get; set; }
        public int? DoorId { get; set; }
        public int? GroupId { get; set; }
        public int? TimeZoneId { get; set; }
        public ulong HolidayFlag { get; set; }
        public ulong AntiSubmarineBackFlag { get; set; }
        public ulong MasterCardFlag { get; set; }
    }
}
