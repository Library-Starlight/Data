using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwSpChannel
    {
        public int Id { get; set; }
        public int? DvrId { get; set; }
        public int? ChannelId { get; set; }
        public string ChannelName { get; set; }
        public ulong IsCound { get; set; }
        public string CompactName { get; set; }
        public string EquipAddr { get; set; }
        public string CommunicationParam { get; set; }
    }
}
