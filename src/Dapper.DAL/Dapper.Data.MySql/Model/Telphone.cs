using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Telphone
    {
        public string StaN { get; set; }
        public string EquipNo { get; set; }
        public string PhoneNum { get; set; }
        public string Name { get; set; }
        public ulong Permit { get; set; }
        public ulong IfCallMachine { get; set; }
        public int? WaitBeforeSpeak { get; set; }
        public string CallMachineFunctKey { get; set; }
        public string CallMachineFinalKey { get; set; }
        public int? DialInterval { get; set; }
        public int? DialRepeat { get; set; }
    }
}
