using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwzichanrecord
    {
        public int Id { get; set; }
        public string ZiChanId { get; set; }
        public DateTime? WeiHuDate { get; set; }
        public string WeiHuName { get; set; }
        public string WeiHuRecord { get; set; }
        public string ItemAddMan { get; set; }
        public DateTime? ItemAddDate { get; set; }
        public string Pictures { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
    }
}
