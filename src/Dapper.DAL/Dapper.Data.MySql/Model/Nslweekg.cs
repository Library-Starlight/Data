using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Nslweekg
    {
        public int WeekGroup { get; set; }
        public int? Mon { get; set; }
        public int? Tue { get; set; }
        public int? Wed { get; set; }
        public int? Thu { get; set; }
        public int? Fri { get; set; }
        public int? Sat { get; set; }
        public int? Sun { get; set; }
    }
}
