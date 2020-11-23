using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Setparm
    {
        public int? StaN { get; set; }
        public int EquipNo { get; set; }
        public int SetNo { get; set; }
        public string SetNm { get; set; }
        public string SetType { get; set; }
        public string MainInstruction { get; set; }
        public string MinorInstruction { get; set; }
        public ulong Record { get; set; }
        public string Action { get; set; }
        public string Value { get; set; }
        public ulong Canexecution { get; set; }
        public string VoiceKeys { get; set; }
        public ulong EnableVoice { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public int? QrEquipNo { get; set; }
    }
}
