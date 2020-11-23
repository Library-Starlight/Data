using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Womainfeedbackattachment
    {
        public string Id { get; set; }
        public string FeedbackId { get; set; }
        public string SaveDate { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
    }
}
