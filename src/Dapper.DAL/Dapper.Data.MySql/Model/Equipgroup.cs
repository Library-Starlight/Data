using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Equipgroup
    {
        public int? StaN { get; set; }
        public int GroupNo { get; set; }
        public string GroupName { get; set; }
        public string Equipcomb { get; set; }
    }
}
