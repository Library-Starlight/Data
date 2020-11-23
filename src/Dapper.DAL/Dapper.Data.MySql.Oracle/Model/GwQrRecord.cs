using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwQrRecord
    {
        public int? Qrtype { get; set; }
        public string Qrcreatname { get; set; }
        public string Vistorname { get; set; }
        public string Actionid { get; set; }
        public int? Result { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
    }
}
