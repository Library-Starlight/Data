using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwwebmapmarker
    {
        public int MarkerId { get; set; }
        public string MarkerName { get; set; }
        public decimal? MarkerType { get; set; }
        public string Size { get; set; }
        public string Position { get; set; }
        public string Data { get; set; }
        public string OffSet { get; set; }
        public string Template { get; set; }
        public string BindCmd { get; set; }
        public string Destination { get; set; }
        public int? EnableRotation { get; set; }
        public string ProjectName { get; set; }
    }
}
