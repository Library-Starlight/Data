using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwelevatormarker
    {
        public int Id { get; set; }
        public string ElevatorNum { get; set; }
        public string ElevatorPosition { get; set; }
        public string ElevatorPlace { get; set; }
        public string ElevatorInfo { get; set; }
        public int? ElevatorState { get; set; }
    }
}
