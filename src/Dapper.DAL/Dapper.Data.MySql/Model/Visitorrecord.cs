using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Visitorrecord
    {
        public double Id { get; set; }
        public string Sex { get; set; }
        public string Visitor { get; set; }
        public string LicenseCode { get; set; }
        public string LicenseType { get; set; }
        public string Address { get; set; }
        public string Nation { get; set; }
        public DateTime? Birthday { get; set; }
        public string IssuingAgency { get; set; }
        public DateTime? LicEndDate { get; set; }
        public DateTime? LicStartDate { get; set; }
        public double? Phone { get; set; }
        public string Remark { get; set; }
        public string Company { get; set; }
        public double? PeerNum { get; set; }
        public string Event { get; set; }
        public DateTime? VisitingTime { get; set; }
        public string Photo { get; set; }
        public string Qrcode { get; set; }
    }
}
