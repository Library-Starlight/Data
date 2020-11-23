using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwPatrolRecordOrigin
    {
        public int Id { get; set; }
        public string Locus { get; set; }
        public string PatrolMan { get; set; }
        public string MeterId { get; set; }
        public string ExceptionId { get; set; }
    }
}
