using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Setevt
    {
        public int? StaN { get; set; }
        public int EquipNo { get; set; }
        public string Event { get; set; }
        public DateTime Time { get; set; }
        public string Operator { get; set; }
        public string Gwsource { get; set; }
    }
}
