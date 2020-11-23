using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
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
