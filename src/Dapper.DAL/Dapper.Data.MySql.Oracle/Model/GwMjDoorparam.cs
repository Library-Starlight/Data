using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwMjDoorparam
    {
        public int? EquipNo { get; set; }
        public int? DoorId { get; set; }
        public string Name { get; set; }
        public string Paramtype { get; set; }
        public string DisName { get; set; }
        public string Value { get; set; }
        public bool IsUse { get; set; }
        public string Remark { get; set; }
    }
}
