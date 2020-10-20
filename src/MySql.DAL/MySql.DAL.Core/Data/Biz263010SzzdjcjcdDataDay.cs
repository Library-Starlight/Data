using System;
using System.Collections.Generic;

namespace MySql.DAL.Core
{
    public partial class Biz263010SzzdjcjcdDataDay
    {
        public int Dataid { get; set; }
        public int? Objid { get; set; }
        public string Objname { get; set; }
        public DateTime? Collecttime { get; set; }
        public double? Bh1 { get; set; }
        public double? Bh4 { get; set; }
        public double? Bh7 { get; set; }
        public double? Bh14 { get; set; }
        public double? Bh16 { get; set; }
        public int? Isused { get; set; }
        public DateTime Updatetime { get; set; }
        public long Estarid { get; set; }
        public string Op { get; set; }
        public DateTime? BizTime { get; set; }
        public DateTime? LoadTime { get; set; }
    }
}
