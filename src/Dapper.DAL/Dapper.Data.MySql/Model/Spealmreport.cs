using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Spealmreport
    {
        public int Id { get; set; }
        public int? StaN { get; set; }
        public int? GroupNo { get; set; }
        public string Administrator { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Remark { get; set; }
    }
}
