using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Workstation
    {
        public int? StaN { get; set; }
        public string StaNm { get; set; }
        public string StaType { get; set; }
        public string NetAddr { get; set; }
        public string SubPath { get; set; }
    }
}
