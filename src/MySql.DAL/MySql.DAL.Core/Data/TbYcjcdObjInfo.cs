using System;
using System.Collections.Generic;

namespace MySql.DAL.Core
{
    public partial class TbYcjcdObjInfo
    {
        public int Id { get; set; }
        public int Objid { get; set; }
        public string Objtypename { get; set; }
        public string Objname { get; set; }
        public string Jd { get; set; }
        public string Wd { get; set; }
        public string Region { get; set; }
        public string State { get; set; }
        public string Deviceid { get; set; }
        public int? Isused { get; set; }
        public DateTime Updatetime { get; set; }
    }
}
