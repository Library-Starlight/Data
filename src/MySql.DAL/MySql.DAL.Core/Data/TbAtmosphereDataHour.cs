using System;
using System.Collections.Generic;

namespace MySql.DAL.Core
{
    public partial class TbAtmosphereDataHour
    {
        public int Dataid { get; set; }
        public int? Objid { get; set; }
        public string Objname { get; set; }
        public DateTime? Collecttime { get; set; }
        public double? Co { get; set; }
        public string Cofzs { get; set; }
        public double? Aqi { get; set; }
        public double? No2 { get; set; }
        public string No2fzs { get; set; }
        public double? O3 { get; set; }
        public string O3fzs { get; set; }
        public double? O38 { get; set; }
        public string O3h8fzs { get; set; }
        public double? Pm10 { get; set; }
        public string Pm10fzs { get; set; }
        public string Sywrw { get; set; }
        public double? So2 { get; set; }
        public string So2fzs { get; set; }
        public double? Pm25 { get; set; }
        public string Pm25fzs { get; set; }
        public string O3h1 { get; set; }
        public string O3h1fzs { get; set; }
        public string Kqzllb { get; set; }
        public string Kqzlys { get; set; }
        public string Pm25h24 { get; set; }
        public string Pm25h24fzs { get; set; }
        public string Pm10h24 { get; set; }
        public string Pm10h24fzs { get; set; }
        public string Sywrwnd { get; set; }
        public string Kqzlzsjb { get; set; }
        public int? Isused { get; set; }
        public DateTime Updatetime { get; set; }
    }
}
