﻿using System;
using System.Collections.Generic;

namespace MySql.DAL.Core
{
    public partial class Biz263010HddbsObjInfo
    {
        public int Id { get; set; }
        public int Objid { get; set; }
        public string Objtypename { get; set; }
        public string Objname { get; set; }
        public string Sshd { get; set; }
        public string Kzjb { get; set; }
        public string Ssxzjd { get; set; }
        public string Hzxm { get; set; }
        public string Lxfs { get; set; }
        public string Mbsz { get; set; }
        public string Ypbh { get; set; }
        public string Gl { get; set; }
        public string Skh { get; set; }
        public string Duty { get; set; }
        public string Xzkh { get; set; }
        public int? Isused { get; set; }
        public DateTime Updatetime { get; set; }
        public long Estarid { get; set; }
        public string Op { get; set; }
        public DateTime? BizTime { get; set; }
        public DateTime? LoadTime { get; set; }
    }
}
