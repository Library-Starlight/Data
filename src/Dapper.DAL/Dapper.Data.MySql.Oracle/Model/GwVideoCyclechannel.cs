using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwVideoCyclechannel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Channels { get; set; }
        public int? Interval { get; set; }
        public int? Sort { get; set; }
    }
}
