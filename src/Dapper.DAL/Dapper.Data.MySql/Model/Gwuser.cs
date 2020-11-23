using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwuser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public string HomePages { get; set; }
        public string AutoInspectionPages { get; set; }
        public string Remark { get; set; }
        public string ControlLevel { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string OppoUser { get; set; }
    }
}
