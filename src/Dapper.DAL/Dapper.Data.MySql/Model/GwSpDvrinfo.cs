using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwSpDvrinfo
    {
        public int DvrId { get; set; }
        public string DvrName { get; set; }
        public string Ip { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int? Port { get; set; }
        public int? ChannelNum { get; set; }
        public string Describe { get; set; }
        public int? DvrType { get; set; }
        public int? CloudMultiple { get; set; }
        public int? CloudSpeed { get; set; }
    }
}
