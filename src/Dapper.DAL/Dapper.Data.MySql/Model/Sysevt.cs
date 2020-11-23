using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Sysevt
    {
        public int? StaN { get; set; }
        public string Event { get; set; }
        public DateTime Time { get; set; }
        public string Confirmname { get; set; }
        public DateTime? Confirmtime { get; set; }
        public string Confirmremark { get; set; }
        public string Guid { get; set; }
    }
}
