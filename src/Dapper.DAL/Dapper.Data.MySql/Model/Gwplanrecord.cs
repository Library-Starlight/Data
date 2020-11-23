using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwplanrecord
    {
        public string PlanNo { get; set; }
        public string Content { get; set; }
        public string Editor { get; set; }
        public DateTime? EditDate { get; set; }
        public string State { get; set; }
    }
}
