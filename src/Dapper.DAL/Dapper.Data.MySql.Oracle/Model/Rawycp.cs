using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Rawycp
    {
        public int? RawEquipNo { get; set; }
        public int? RawYcNo { get; set; }
        public string RawYcNm { get; set; }
        public bool? Mapping { get; set; }
        public double? YcMin { get; set; }
        public double? YcMax { get; set; }
        public double? PhysicMin { get; set; }
        public double? PhysicMax { get; set; }
        public double? ValMin { get; set; }
        public double? RestoreMin { get; set; }
        public double? RestoreMax { get; set; }
        public double? ValMax { get; set; }
        public int? ValTrait { get; set; }
        public string MainInstruction { get; set; }
        public string MinorInstruction { get; set; }
        public int? AlarmAcceptableTime { get; set; }
        public int? RestoreAcceptableTime { get; set; }
        public int? AlarmRepeatTime { get; set; }
        public string ProcAdvice { get; set; }
        public int? LvlLevel { get; set; }
        public string OutminEvt { get; set; }
        public string OutmaxEvt { get; set; }
        public string WaveFile { get; set; }
        public int? RelatedPic { get; set; }
        public int? AlarmScheme { get; set; }
        public bool? CurveRcd { get; set; }
    }
}
