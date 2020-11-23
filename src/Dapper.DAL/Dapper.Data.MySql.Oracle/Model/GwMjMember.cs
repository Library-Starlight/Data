using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwMjMember
    {
        public int MemberId { get; set; }
        public int? DeptId { get; set; }
        public string MemberName { get; set; }
        public int? TrafficGroupId { get; set; }
        public string Tel { get; set; }
        public string Addr { get; set; }
        public string MemberStatue { get; set; }
        public bool? HeadFlag { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string Reserve4 { get; set; }
    }
}
