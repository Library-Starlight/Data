﻿using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Sysevt
    {
        public int? StaN { get; set; }
        public string Event { get; set; }
        public string Confirmname { get; set; }
        public string Confirmremark { get; set; }
        public string Guid { get; set; }
    }
}
