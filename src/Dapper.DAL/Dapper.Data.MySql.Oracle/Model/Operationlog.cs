using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Operationlog
    {
        public string StaNm { get; set; }
        public string OperationTitle { get; set; }
        public string OperationPersion { get; set; }
        public int OperationId { get; set; }
    }
}
