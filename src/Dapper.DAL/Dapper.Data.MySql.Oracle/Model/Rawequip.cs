using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Rawequip
    {
        public int? RawEquipNo { get; set; }
        public string RawEquipNm { get; set; }
        public string EquipDetail { get; set; }
        public int? AccCyc { get; set; }
        public string RelatedPic { get; set; }
        public string ProcAdvice { get; set; }
        public string OutOfContact { get; set; }
        public string Contacted { get; set; }
        public string EventWav { get; set; }
        public int? CommunicatonType { get; set; }
        public string CommunicationDrv { get; set; }
        public string LocalAddr { get; set; }
        public string EquipAddr { get; set; }
        public string CommunicationParam { get; set; }
        public string CommunicationTimeParam { get; set; }
        public string Tabname { get; set; }
        public int? AlarmScheme { get; set; }
        public int? Attrib { get; set; }
    }
}
