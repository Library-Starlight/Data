using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class IotDevice
    {
        public string DeviceId { get; set; }
        public int? EquipNo { get; set; }
        public string NodeId { get; set; }
        public string NodeType { get; set; }
        public string GatewayId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string Description { get; set; }
        public string ManufactureId { get; set; }
        public string ManufactureName { get; set; }
        public string Mac { get; set; }
        public string Location { get; set; }
        public string DeviceType { get; set; }
        public string Model { get; set; }
        public string SwVersion { get; set; }
        public string FwVersion { get; set; }
        public string HwVersion { get; set; }
        public string Imsi { get; set; }
        public string ProtocolType { get; set; }
        public string RadiusIp { get; set; }
        public string BridgeId { get; set; }
        public string SigVersion { get; set; }
        public string SerialNumber { get; set; }
        public string Lnglat { get; set; }
        public string Height { get; set; }
        public string ReportData { get; set; }
        public string SystemType { get; set; }
        public string SystemTypeName { get; set; }
        public string UnitName { get; set; }
        public string BuildName { get; set; }
        public string AreaName { get; set; }
        public string DeviceTypeId { get; set; }
        public string DeviceTypeName { get; set; }
    }
}
