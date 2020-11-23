using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class CurDatum
    {
        public DateTime? Tmdate { get; set; }
        public int? StaN { get; set; }
        public int? EquipNo { get; set; }
        public int? YcNo { get; set; }
        public double? Data { get; set; }
    }
}
