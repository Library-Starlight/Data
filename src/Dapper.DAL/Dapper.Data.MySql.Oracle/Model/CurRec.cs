using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class CurRec
    {
        public int? StaN { get; set; }
        public int? EquipNo { get; set; }
        public int? YcNo { get; set; }
        public byte[] Data { get; set; }
    }
}
