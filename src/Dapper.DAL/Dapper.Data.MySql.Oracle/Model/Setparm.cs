﻿using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
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
        public bool? Record { get; set; }
        public string Action { get; set; }
        public string Value { get; set; }
        public bool? Canexecution { get; set; }
        public string VoiceKeys { get; set; }
        public bool? EnableVoice { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public int? QrEquipNo { get; set; }
    }
}
