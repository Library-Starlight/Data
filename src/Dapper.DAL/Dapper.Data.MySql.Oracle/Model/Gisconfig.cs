using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gisconfig
    {
        public int Id { get; set; }
        public string ControlType { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
        public string CheckImage { get; set; }
        public string AlarmImage { get; set; }
        public string ClickCmd { get; set; }
        public string AlarmExpression { get; set; }
        public int? Zoom { get; set; }
        public int? MaxZoomNum { get; set; }
        public int? MinZoomNum { get; set; }
        public string Tooltip { get; set; }
        public int? ImageWith { get; set; }
        public int? ImageHight { get; set; }
        public string OffsetPoint { get; set; }
    }
}
