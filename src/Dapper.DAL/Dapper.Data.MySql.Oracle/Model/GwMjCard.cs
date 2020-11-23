using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwMjCard
    {
        public int CardId { get; set; }
        public int? MemberId { get; set; }
        public string CardNo { get; set; }
        public string Pwd { get; set; }
        public bool Valided { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string Reserve4 { get; set; }
    }
}
