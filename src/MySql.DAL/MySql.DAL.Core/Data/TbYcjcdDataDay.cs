using System;
using System.Collections.Generic;

namespace MySql.DAL.Core
{
    public partial class TbYcjcdDataDay
    {
        public int Dataid { get; set; }
        public int? Objid { get; set; }
        public string Objname { get; set; }
        public DateTime? Collecttime { get; set; }
        public double? Pm10 { get; set; }
        public double? Pm25 { get; set; }
        public string State { get; set; }
        public string Fpm10 { get; set; }
        public string Fpm25 { get; set; }
        public int? Isused { get; set; }
        public DateTime Updatetime { get; set; }
    }
}
