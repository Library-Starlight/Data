﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwQrCheck
    {
        public int? Qrtype { get; set; }
        public string Qrcreatname { get; set; }
        public string Vistorname { get; set; }
        public string Actionid { get; set; }
        public DateTime? Insertdate { get; set; }
        public int? Result { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
    }
}
