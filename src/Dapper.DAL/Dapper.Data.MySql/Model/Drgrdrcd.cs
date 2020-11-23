using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Drgrdrcd
    {
        public int? GuardNo { get; set; }
        public int? DoorId { get; set; }
        public int? CardId { get; set; }
        public string Name { get; set; }
        public DateTime? Yymmdd { get; set; }
        public string Action { get; set; }
    }
}
