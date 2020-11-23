using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Operationlog
    {
        public string StaNm { get; set; }
        public string OperationTitle { get; set; }
        public string OperationPersion { get; set; }
        public DateTime? OperationDate { get; set; }
        public int OperationId { get; set; }
    }
}
