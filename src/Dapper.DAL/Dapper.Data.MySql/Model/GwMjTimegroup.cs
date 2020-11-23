using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwMjTimegroup
    {
        public int TimeGroupId { get; set; }
        public int? EquipNo { get; set; }
        public string TimeGroupName { get; set; }
        public int? WkPermission { get; set; }
        public DateTime? Time1Begin { get; set; }
        public DateTime? Time1End { get; set; }
        public DateTime? Time2Begin { get; set; }
        public DateTime? Time2End { get; set; }
        public DateTime? Time3Begin { get; set; }
        public DateTime? Time3End { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string Reserve4 { get; set; }
    }
}
