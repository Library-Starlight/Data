using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Nslcardno
    {
        public int StaN { get; set; }
        public int EquipNo { get; set; }
        public string CardNo { get; set; }
        public string CardCode { get; set; }
        public string PinCode { get; set; }
        public string Name { get; set; }
        public string WeekGroup { get; set; }
    }
}
