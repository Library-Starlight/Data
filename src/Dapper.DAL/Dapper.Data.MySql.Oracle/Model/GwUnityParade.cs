using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwUnityParade
    {
        public int Id { get; set; }
        public int? SceneId { get; set; }
        public int? Vindex { get; set; }
        public double? ParadeSpeed { get; set; }
        public string Vposition { get; set; }
        public string Rotation { get; set; }
    }
}
