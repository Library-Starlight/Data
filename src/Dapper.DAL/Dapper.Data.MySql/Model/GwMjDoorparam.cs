using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwMjDoorparam
    {
        public int? EquipNo { get; set; }
        public int? DoorId { get; set; }
        public string Name { get; set; }
        public string Paramtype { get; set; }
        public string DisName { get; set; }
        public string Value { get; set; }
        public ulong IsUse { get; set; }
        public string Remark { get; set; }
    }
}
