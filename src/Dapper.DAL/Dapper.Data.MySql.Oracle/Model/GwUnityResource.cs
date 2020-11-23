using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwUnityResource
    {
        public double? Height { get; set; }
        public double? Id { get; set; }
        public string Name { get; set; }
        public double? Width { get; set; }
        public double? Type { get; set; }
        public string TexName { get; set; }
        public string DevName { get; set; }
        public string BestViewPos { get; set; }
        public string DevIconColor { get; set; }
        public string DevIconName { get; set; }
        public string BestViewRot { get; set; }
    }
}
