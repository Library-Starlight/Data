using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwexproccmd
    {
        public int ProcCode { get; set; }
        public string CmdNm { get; set; }
        public string MainInstruction { get; set; }
        public string MinorInstruction { get; set; }
        public string Value { get; set; }
        public ulong Record { get; set; }
    }
}
