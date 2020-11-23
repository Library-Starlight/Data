using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class KingkangMember
    {
        public int? DeptId { get; set; }
        public string Name { get; set; }
        public int CardId { get; set; }
        public int? CardSection { get; set; }
        public int? CardCode { get; set; }
        public int? Pwd { get; set; }
        public string Tel { get; set; }
        public string Addr { get; set; }
    }
}
