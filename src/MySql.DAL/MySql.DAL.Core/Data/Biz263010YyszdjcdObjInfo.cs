using System;
using System.Collections.Generic;

namespace MySql.DAL.Core
{
    public partial class Biz263010YyszdjcdObjInfo
    {
        public int Id { get; set; }
        public int Objid { get; set; }
        public string Objtypename { get; set; }
        public string Objname { get; set; }
        public string Cdbh { get; set; }
        public string Sssf { get; set; }
        public string Ssds { get; set; }
        public string Ssqx { get; set; }
        public string Jd { get; set; }
        public string Wd { get; set; }
        public int? Isused { get; set; }
        public DateTime Updatetime { get; set; }
        public long Estarid { get; set; }
        public string Op { get; set; }
        public DateTime? BizTime { get; set; }
        public DateTime? LoadTime { get; set; }
    }
}
