using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Telphone
    {
        public string StaN { get; set; }
        public string EquipNo { get; set; }
        public string PhoneNum { get; set; }
        public string Name { get; set; }
        public bool? Permit { get; set; }
        public bool? IfCallMachine { get; set; }
        public int? WaitBeforeSpeak { get; set; }
        public string CallMachineFunctKey { get; set; }
        public string CallMachineFinalKey { get; set; }
        public int? DialInterval { get; set; }
        public int? DialRepeat { get; set; }
    }
}
