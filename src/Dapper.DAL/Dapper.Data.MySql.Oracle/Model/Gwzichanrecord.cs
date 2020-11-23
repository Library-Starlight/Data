using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwzichanrecord
    {
        public int Id { get; set; }
        public string ZiChanId { get; set; }
        public string WeiHuName { get; set; }
        public string WeiHuRecord { get; set; }
        public string ItemAddMan { get; set; }
        public string Pictures { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
    }
}
