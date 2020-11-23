using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Rawyxp
    {
        public int? RawEquipNo { get; set; }
        public int? RawYxNo { get; set; }
        public string RawYxNm { get; set; }
        public string ProcAdviceR { get; set; }
        public string ProcAdviceD { get; set; }
        public int? LevelR { get; set; }
        public int? LevelD { get; set; }
        public string Evt01 { get; set; }
        public string Evt10 { get; set; }
        public DateTime? SafeBgn { get; set; }
        public DateTime? SafeEnd { get; set; }
        public int? AlarmAcceptableTime { get; set; }
        public int? RestoreAcceptableTime { get; set; }
        public int? AlarmRepeatTime { get; set; }
        public string MainInstruction { get; set; }
        public string MinorInstruction { get; set; }
        public string WaveFile { get; set; }
        public int? RelatedPic { get; set; }
        public ulong Inversion { get; set; }
        public int? AlarmScheme { get; set; }
        public int? Initval { get; set; }
        public int? ValTrait { get; set; }
    }
}
