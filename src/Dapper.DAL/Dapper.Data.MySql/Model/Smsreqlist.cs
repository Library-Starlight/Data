using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Smsreqlist
    {
        public int? ReqId { get; set; }
        public string ReqName { get; set; }
        public string Comment { get; set; }
    }
}
