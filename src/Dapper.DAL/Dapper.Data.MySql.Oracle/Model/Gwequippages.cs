using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwequippages
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pages { get; set; }
        public string HelpPath { get; set; }
        public string MultiScreens { get; set; }
        public string WebPage { get; set; }
    }
}
