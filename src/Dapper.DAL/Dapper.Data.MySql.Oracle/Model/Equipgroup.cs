using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Equipgroup
    {
        public int? StaN { get; set; }
        public int GroupNo { get; set; }
        public string GroupName { get; set; }
        public string Equipcomb { get; set; }
    }
}
