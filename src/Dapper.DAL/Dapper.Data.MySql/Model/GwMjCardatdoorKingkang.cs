using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwMjCardatdoorKingkang
    {
        public int? EquipNo { get; set; }
        public int? DoorId { get; set; }
        public int? CardId { get; set; }
        public int? TimeZoneId { get; set; }
        public ulong HolidayFlag { get; set; }
        public ulong AntiSubmarineBackFlag { get; set; }
        public ulong MasterCardFlag { get; set; }
        public ulong WrittenFlag { get; set; }
    }
}
