using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwaddinmodule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public string HelpPath { get; set; }
        public string MultiScreens { get; set; }
        public string WebPage { get; set; }
    }
}
