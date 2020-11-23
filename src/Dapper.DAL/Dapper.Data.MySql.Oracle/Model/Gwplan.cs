using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwplan
    {
        public string PlanNo { get; set; }
        public string Content { get; set; }
        public string LastEditor { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public int? IsModel { get; set; }
    }
}
