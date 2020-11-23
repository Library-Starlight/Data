using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwMjDrgrdrcd
    {
        public short? GuardNo { get; set; }
        public sbyte? DoorId { get; set; }
        public short? CardId { get; set; }
        public string Name { get; set; }
        public DateTime? Yymmdd { get; set; }
        public string Action { get; set; }
    }
}
