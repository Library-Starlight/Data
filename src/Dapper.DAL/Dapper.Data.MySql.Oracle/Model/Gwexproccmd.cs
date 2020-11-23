using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwexproccmd
    {
        public int ProcCode { get; set; }
        public string CmdNm { get; set; }
        public string MainInstruction { get; set; }
        public string MinorInstruction { get; set; }
        public string Value { get; set; }
        public bool? Record { get; set; }
    }
}
