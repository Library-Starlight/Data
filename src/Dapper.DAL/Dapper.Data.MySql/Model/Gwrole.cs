using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwrole
    {
        public string Name { get; set; }
        public string ControlEquips { get; set; }
        public string ControlEquipsUnit { get; set; }
        public string BrowseEquips { get; set; }
        public string BrowsePages { get; set; }
        public string Remark { get; set; }
        public string SpecialBrowseEquip { get; set; }
        public string SystemModule { get; set; }
    }
}
