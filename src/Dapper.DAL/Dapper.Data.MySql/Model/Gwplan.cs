using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwplan
    {
        public string PlanNo { get; set; }
        public string Content { get; set; }
        public string LastEditor { get; set; }
        public DateTime? EditDate { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public int? IsModel { get; set; }
    }
}
