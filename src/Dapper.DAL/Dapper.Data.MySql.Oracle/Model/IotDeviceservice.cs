using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class IotDeviceservice
    {
        public string ServiceId { get; set; }
        public string DeviceId { get; set; }
        public int? YcYxSetNo { get; set; }
        public string ServiceType { get; set; }
        public string ServiceModel { get; set; }
        public string ServiceOption { get; set; }
        public string Description { get; set; }
        public string CurrentDate { get; set; }
        public string ServiceModelId { get; set; }
        public string ServiceModelName { get; set; }
        public string ReportMode { get; set; }
        public int ReportTimespan { get; set; }
        public float ReportLimit { get; set; }
    }
}
