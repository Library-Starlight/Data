using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Nsladmission
    {
        public int StaN { get; set; }
        public int EquipNo { get; set; }
        public string CardNo { get; set; }
        public int? Reader { get; set; }
        public bool? Permission { get; set; }
    }
}
