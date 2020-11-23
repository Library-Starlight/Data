using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwproctimetlist
    {
        public int TableId { get; set; }
        public string TableName { get; set; }
        public string Comment { get; set; }
        public string Reference { get; set; }
    }
}
