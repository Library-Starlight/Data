using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwSpMethod
    {
        public int MethodId { get; set; }
        public int? ModulId { get; set; }
        public string MethodName { get; set; }
        public string ClassName { get; set; }
    }
}
