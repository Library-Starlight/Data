using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwVideoPreset
    {
        public int Id { get; set; }
        public int? ChannelId { get; set; }
        public int? EquipId { get; set; }
        public string Name { get; set; }
    }
}
