using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Worecord
    {
        public int Id { get; set; }
        public string WorkOrderId { get; set; }
        public string Description { get; set; }
        public string Creator { get; set; }
        public string CreatedTime { get; set; }
    }
}
