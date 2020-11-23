using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwUnityMarkview
    {
        public int? SceneId { get; set; }
        public int? ResId { get; set; }
        public string Vposition { get; set; }
        public string Rotation { get; set; }
    }
}
