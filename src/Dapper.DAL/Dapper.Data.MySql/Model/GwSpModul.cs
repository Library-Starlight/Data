using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwSpModul
    {
        public int ModulId { get; set; }
        public string ModulName { get; set; }
        public int? DvrTypeId { get; set; }
        public string ClassName { get; set; }
    }
}
