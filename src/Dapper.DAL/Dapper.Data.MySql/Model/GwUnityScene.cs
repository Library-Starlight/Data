using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwUnityScene
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShowName { get; set; }
        public double? MoveSpeed { get; set; }
        public double? XrotSpeed { get; set; }
        public double? YrotSpeed { get; set; }
        public double? PymoveSpeed { get; set; }
        public double? PyscaleSpeed { get; set; }
        public double? ParadeSpeed { get; set; }
        public int? ParadeId { get; set; }
        public string InitPos { get; set; }
        public string InitRot { get; set; }
        public string WalkInitPos { get; set; }
        public string WalkInitRot { get; set; }
        public string OverLookPos { get; set; }
        public string OverLookRot { get; set; }
        public double? OverLookSize { get; set; }
        public string SkyBox { get; set; }
        public string MinMapSize { get; set; }
        public string Version { get; set; }
        public string BundleName { get; set; }
    }
}
