using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwassetinfo
    {
        public string AssetId { get; set; }
        public string EquipName { get; set; }
        public string EquipDetail { get; set; }
        public string EquipImage { get; set; }
        public string EquipLocation { get; set; }
        public string EquipType { get; set; }
    }
}
