using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwMjControllerParamKingkang
    {
        public int? EquipNo { get; set; }
        public int? DoorId { get; set; }
        public int? DoorOpenTime { get; set; }
        public int? DoorOpenAlarmTime { get; set; }
        public int? OpenDoorModel { get; set; }
        public int? MultiCardNum { get; set; }
        public ulong DoorOpenTimeOutAlarmFlag { get; set; }
        public ulong DoorWithoutOpeningAlarmFlag { get; set; }
        public ulong DoorInterlockFlag { get; set; }
        public ulong DoorOpenCloseStatueFlag { get; set; }
        public ulong ButtonTimeZoneLimitFlag { get; set; }
        public ulong PasswordTimeZoneLimitFlag { get; set; }
        public ulong MultiCardFlag { get; set; }
        public ulong CardTypeFlag { get; set; }
        public ulong WrittenFlag { get; set; }
    }
}
