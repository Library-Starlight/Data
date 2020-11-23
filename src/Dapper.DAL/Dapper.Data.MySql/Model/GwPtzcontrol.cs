using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwPtzcontrol
    {
        public int Id { get; set; }
        public int? EquipNum { get; set; }
        public int? ChannelNum { get; set; }
        public int? ControlEquip { get; set; }
        public int? Ptztop { get; set; }
        public int? Ptzbottom { get; set; }
        public int? Ptzleft { get; set; }
        public int? Ptzright { get; set; }
        public int? PtzzoomP { get; set; }
        public int? PtzzoomD { get; set; }
        public int? Ptzpreset { get; set; }
        public int? PtzpresetValue { get; set; }
    }
}
