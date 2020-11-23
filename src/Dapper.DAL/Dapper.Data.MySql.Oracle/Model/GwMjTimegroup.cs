using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwMjTimegroup
    {
        public int TimeGroupId { get; set; }
        public int? EquipNo { get; set; }
        public string TimeGroupName { get; set; }
        public int? WkPermission { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string Reserve4 { get; set; }
    }
}
