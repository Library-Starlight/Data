using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwPatrolComport
    {
        public int MeterType { get; set; }
        public string CommunicationParam { get; set; }
        public string Port { get; set; }
    }
}
