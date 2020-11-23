using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
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
