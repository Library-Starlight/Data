using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class PersonnelFaceimage
    {
        public string Id { get; set; }
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
