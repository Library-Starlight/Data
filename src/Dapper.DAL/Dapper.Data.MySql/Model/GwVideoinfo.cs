using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwVideoinfo
    {
        public int? StaN { get; set; }
        public int? EquipNum { get; set; }
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public int? ChannelType { get; set; }
        public string ChannelNum { get; set; }
        public int? ControlEquip { get; set; }
        public string Path { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string Action { get; set; }
        public string StreamType { get; set; }
        public string Rtsp { get; set; }
    }
}
