﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Sycardno
    {
        public int? StaN { get; set; }
        public int? EquipNo { get; set; }
        public string Name { get; set; }
        public string CardNo { get; set; }
        public string Cardid { get; set; }
        public string App { get; set; }
        public string Cardtype { get; set; }
        public string Pin { get; set; }
    }
}
