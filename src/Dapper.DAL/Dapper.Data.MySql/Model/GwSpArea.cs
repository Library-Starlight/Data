using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwSpArea
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string AreaDvrChannel { get; set; }
    }
}
