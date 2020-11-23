using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Womainfeedbackconfirm
    {
        public int Id { get; set; }
        public string WorkOrderId { get; set; }
        public string FeedbackId { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
        public string Creator { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
