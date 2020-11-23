using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwHomeMenu
    {
        public int? Id { get; set; }
        public int? GroupId { get; set; }
        public string ModulName { get; set; }
        public string MenuName { get; set; }
        public string IconName { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
    }
}
