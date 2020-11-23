using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Operationrec
    {
        public int OperationId { get; set; }
        public string OperationTitle { get; set; }
        public string OperationPersion { get; set; }
        public string OperationComment { get; set; }
        public byte[] OperationProcedure { get; set; }
    }
}
