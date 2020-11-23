using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Womainfeedbackconfirm
    {
        public int Id { get; set; }
        public string WorkOrderId { get; set; }
        public string FeedbackId { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
        public string Creator { get; set; }
    }
}
