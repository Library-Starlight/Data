using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwMjControllerParamKingkang
    {
        public int? EquipNo { get; set; }
        public int? DoorId { get; set; }
        public int? DoorOpenTime { get; set; }
        public int? DoorOpenAlarmTime { get; set; }
        public int? OpenDoorModel { get; set; }
        public int? MultiCardNum { get; set; }
        public bool DoorOpenTimeOutAlarmFlag { get; set; }
        public bool DoorWithoutOpeningAlarmFlag { get; set; }
        public bool DoorInterlockFlag { get; set; }
        public bool DoorOpenCloseStatueFlag { get; set; }
        public bool ButtonTimeZoneLimitFlag { get; set; }
        public bool PasswordTimeZoneLimitFlag { get; set; }
        public bool MultiCardFlag { get; set; }
        public bool CardTypeFlag { get; set; }
        public bool WrittenFlag { get; set; }
    }
}
