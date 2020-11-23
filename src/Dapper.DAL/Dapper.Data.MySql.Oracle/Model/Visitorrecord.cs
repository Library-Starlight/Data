using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
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
        public string IssuingAgency { get; set; }
        public double? Phone { get; set; }
        public string Remark { get; set; }
        public string Company { get; set; }
        public double? PeerNum { get; set; }
        public string Event { get; set; }
        public string Photo { get; set; }
        public string Qrcode { get; set; }
    }
}
