using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwMjCard
    {
        public int CardId { get; set; }
        public int? MemberId { get; set; }
        public string CardNo { get; set; }
        public string Pwd { get; set; }
        public DateTime? ValidBegin { get; set; }
        public DateTime? ValidEnd { get; set; }
        public ulong Valided { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string Reserve4 { get; set; }
    }
}
