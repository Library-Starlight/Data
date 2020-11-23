using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwmapmarker
    {
        public int MarkerId { get; set; }
        public string MarkerName { get; set; }
        public double MarkerType { get; set; }
        public string Position { get; set; }
        public int? MinZoom { get; set; }
        public int? MaxZoom { get; set; }
        public string ClassFullName { get; set; }
        public string Data { get; set; }
        public string AssemblyName { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string Path { get; set; }
        public double DefaultZoom { get; set; }
        public string Offset { get; set; }
        public string GroupId { get; set; }
        public string Xmlns { get; set; }
        public int? ZIndex { get; set; }
    }
}
