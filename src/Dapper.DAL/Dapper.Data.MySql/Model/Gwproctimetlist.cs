using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwproctimetlist
    {
        public int TableId { get; set; }
        public string TableName { get; set; }
        public string Comment { get; set; }
        public string Reference { get; set; }
    }
}
