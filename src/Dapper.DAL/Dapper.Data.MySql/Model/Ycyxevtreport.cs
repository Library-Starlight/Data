using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Ycyxevtreport
    {
        public string Name { get; set; }
        public int? StaN { get; set; }
        public int EquipNo { get; set; }
        public int YcyxNo { get; set; }
        public string YcyxType { get; set; }
        public int? IndexNum { get; set; }
    }
}
