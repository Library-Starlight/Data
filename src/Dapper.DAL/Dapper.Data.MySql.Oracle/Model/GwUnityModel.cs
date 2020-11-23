using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwUnityModel
    {
        public double? Id { get; set; }
        public string Name { get; set; }
        public double? ResId { get; set; }
        public double? ParentId { get; set; }
        public double? SceneId { get; set; }
        public string BestViewPos { get; set; }
        public double? ShowMark { get; set; }
        public string BestViewRot { get; set; }
        public string Rotation { get; set; }
        public string Vposition { get; set; }
        public string Scale { get; set; }
        public string ValueCmd { get; set; }
        public double? WarType { get; set; }
        public string ClickCmd { get; set; }
        public string WarCmd { get; set; }
        public string ToolTip { get; set; }
    }
}
