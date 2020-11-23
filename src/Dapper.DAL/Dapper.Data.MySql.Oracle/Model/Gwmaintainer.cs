using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwmaintainer
    {
        public int Id { get; set; }
        public string MaintainerName { get; set; }
        public string MaintainerPosition { get; set; }
        public string MaintainerInfo { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
    }
}
