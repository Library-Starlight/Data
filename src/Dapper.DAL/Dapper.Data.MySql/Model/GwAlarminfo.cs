using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwAlarminfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int? EquipNo { get; set; }
        public string YcyxType { get; set; }
        public int? YcyxNo { get; set; }
        public string Action { get; set; }
        public string RelatedVideo { get; set; }
        public string ZichanNo { get; set; }
        public string PlanNo { get; set; }
        public string RelatedPic { get; set; }
    }
}
