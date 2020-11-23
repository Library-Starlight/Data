using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Woattachment
    {
        public string Id { get; set; }
        public string WorkOrderId { get; set; }
        public string SaveDate { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string CreatedTime { get; set; }
    }
}
