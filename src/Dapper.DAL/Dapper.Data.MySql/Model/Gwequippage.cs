using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwequippage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pages { get; set; }
        public string HelpPath { get; set; }
        public string MultiScreens { get; set; }
        public string WebPage { get; set; }
    }
}
