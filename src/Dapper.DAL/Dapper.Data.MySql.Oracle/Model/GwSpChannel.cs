using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwSpChannel
    {
        public int Id { get; set; }
        public int? DvrId { get; set; }
        public int? ChannelId { get; set; }
        public string ChannelName { get; set; }
        public bool? IsCound { get; set; }
        public string CompactName { get; set; }
        public string EquipAddr { get; set; }
        public string CommunicationParam { get; set; }
    }
}
