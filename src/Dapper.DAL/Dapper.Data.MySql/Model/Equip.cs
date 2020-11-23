﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Equip
    {
        public int? StaN { get; set; }
        public int EquipNo { get; set; }
        public string EquipNm { get; set; }
        public string EquipDetail { get; set; }
        public int? AccCyc { get; set; }
        public string RelatedPic { get; set; }
        public string ProcAdvice { get; set; }
        public string OutOfContact { get; set; }
        public string Contacted { get; set; }
        public string EventWav { get; set; }
        public string CommunicationDrv { get; set; }
        public string LocalAddr { get; set; }
        public string EquipAddr { get; set; }
        public string CommunicationParam { get; set; }
        public string CommunicationTimeParam { get; set; }
        public int? RawEquipNo { get; set; }
        public string Tabname { get; set; }
        public int? AlarmScheme { get; set; }
        public int? Attrib { get; set; }
        public string StaIp { get; set; }
        public int? AlarmRiseCycle { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string RelatedVideo { get; set; }
        public string ZiChanId { get; set; }
        public string PlanNo { get; set; }
        public string SafeTime { get; set; }
    }
}
