using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Womaintenancefeedback
    {
        public string Id { get; set; }
        public int AcceptOrderId { get; set; }
        public int Level { get; set; }
        public string MaintenanceTime { get; set; }
        public int Status { get; set; }
        public string CauseIssue { get; set; }
        public string ProcessContent { get; set; }
        public string CreatedTime { get; set; }
    }
}
