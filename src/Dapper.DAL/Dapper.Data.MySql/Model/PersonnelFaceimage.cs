using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class PersonnelFaceimage
    {
        public string Id { get; set; }
        public DateTime? Time { get; set; }
        public string SourceId { get; set; }
        public string Race { get; set; }
        public string SourceType { get; set; }
        public string ImageUri { get; set; }
        public string Type { get; set; }
        public string AlarmId { get; set; }
        public int? FlagId { get; set; }
        public long? HashId { get; set; }
        public int PkId { get; set; }
    }
}
