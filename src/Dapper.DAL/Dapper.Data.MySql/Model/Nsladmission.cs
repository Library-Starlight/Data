using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Nsladmission
    {
        public int StaN { get; set; }
        public int EquipNo { get; set; }
        public string CardNo { get; set; }
        public int? Reader { get; set; }
        public ulong Permission { get; set; }
    }
}
