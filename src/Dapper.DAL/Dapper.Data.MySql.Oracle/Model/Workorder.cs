using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Workorder
    {
        public string Id { get; set; }
        public string EquipType { get; set; }
        public string Topic { get; set; }
        public int Level { get; set; }
        public string MaintenanceSite { get; set; }
        public string MaintenanceTime { get; set; }
        public string Content { get; set; }
        public int Status { get; set; }
        public string Creator { get; set; }
        public string Reason { get; set; }
        public string CreatedTime { get; set; }
        public string ModifiedTime { get; set; }
        public string CompletedTime { get; set; }
    }
}
