using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class TcInoutl
    {
        public int Id { get; set; }
        public string CarNo { get; set; }
        public string CardNo { get; set; }
        public string CtrlNoI { get; set; }
        public string CtrlNoInVideo { get; set; }
        public string CtrlNoO { get; set; }
        public string CtrlNoOutVideo { get; set; }
        public string CardType { get; set; }
        public string CarType { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
    }
}
