using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Alarmrec
    {
        public string ProcName { get; set; }
        public string Administrator { get; set; }
        public string Event { get; set; }
        public DateTime? Time { get; set; }
        public string Comment { get; set; }
    }
}
