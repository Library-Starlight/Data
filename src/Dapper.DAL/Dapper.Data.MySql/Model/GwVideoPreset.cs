using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwVideoPreset
    {
        public int Id { get; set; }
        public int? ChannelId { get; set; }
        public int? EquipId { get; set; }
        public string Name { get; set; }
    }
}
