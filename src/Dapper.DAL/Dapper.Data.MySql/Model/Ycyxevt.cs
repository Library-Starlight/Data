﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Ycyxevt
    {
        public int? StaN { get; set; }
        public int EquipNo { get; set; }
        public int YcyxNo { get; set; }
        public string YcyxType { get; set; }
        public string Event { get; set; }
        public DateTime Time { get; set; }
        public string ProcRec { get; set; }
        public string Confirmname { get; set; }
        public DateTime? Confirmtime { get; set; }
        public string Confirmremark { get; set; }
        public string WuBao { get; set; }
        public int? Alarmlevel { get; set; }
        public int AlarmState { get; set; }
        public string Guid { get; set; }
    }
}
