using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Almreport
    {
        public int Id { get; set; }
        public int? StaN { get; set; }
        public int? GroupNo { get; set; }
        public string Administrator { get; set; }
    }
}
