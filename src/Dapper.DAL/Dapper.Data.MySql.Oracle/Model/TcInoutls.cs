using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class TcInoutls
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
    }
}
