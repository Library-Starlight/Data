using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Womainfeedbackattachment
    {
        public string Id { get; set; }
        public string FeedbackId { get; set; }
        public string SaveDate { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
