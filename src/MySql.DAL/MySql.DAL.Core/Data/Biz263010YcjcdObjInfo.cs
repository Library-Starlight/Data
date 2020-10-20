using System;
using System.Collections.Generic;

namespace MySql.DAL.Core
{
    public partial class Biz263010YcjcdObjInfo
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
        public long Estarid { get; set; }
        public string Op { get; set; }
        public DateTime? BizTime { get; set; }
        public DateTime? LoadTime { get; set; }
    }
}
