using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwMjDeptment
    {
        public int DeptId { get; set; }
        public string DeptNm { get; set; }
        public DateTime? ValidBegin { get; set; }
        public DateTime? ValidEnd { get; set; }
    }
}
