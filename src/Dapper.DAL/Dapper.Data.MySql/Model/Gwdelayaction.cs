using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwdelayaction
    {
        public int Id { get; set; }
        public int? GwStaN { get; set; }
        public int? GwEquipNo { get; set; }
        public int? GwSetNo { get; set; }
        public string GwValue { get; set; }
        public DateTime? GwAddDateTime { get; set; }
        public string GwUserNm { get; set; }
        public int? GwDelayNum { get; set; }
        public int? GwState { get; set; }
        public int? GwSource { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
    }
}
