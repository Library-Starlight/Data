﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Operationrec
    {
        public int OperationId { get; set; }
        public string OperationTitle { get; set; }
        public string OperationPersion { get; set; }
        public DateTime? OperationDate { get; set; }
        public string OperationComment { get; set; }
        public byte[] OperationProcedure { get; set; }
    }
}
