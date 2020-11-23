using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwMjRealtimeinout
    {
        public int? GuardNo { get; set; }
        public int? DoorId { get; set; }
        public int? CardId { get; set; }
        public string Name { get; set; }
        public string Action { get; set; }
    }
}
