﻿using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwsnapshotconfig
    {
        public int Id { get; set; }
        public string SnapshotName { get; set; }
        public int? SnapshotLevelMin { get; set; }
        public int? SnapshotLevelMax { get; set; }
        public int? MaxCount { get; set; }
        public int? IsShow { get; set; }
        public string IconRes { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
    }
}
