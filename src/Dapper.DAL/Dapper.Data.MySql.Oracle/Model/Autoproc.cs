using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Autoproc
    {
        public int Id { get; set; }
        public int? IequipNo { get; set; }
        public int? IycyxNo { get; set; }
        public string IycyxType { get; set; }
        public int? Delay { get; set; }
        public int? OequipNo { get; set; }
        public int? OsetNo { get; set; }
        public string Value { get; set; }
        public string ProcDesc { get; set; }
        public int? Enable { get; set; }
    }
}
