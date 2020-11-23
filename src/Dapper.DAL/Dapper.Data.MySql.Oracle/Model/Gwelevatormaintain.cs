using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwelevatormaintain
    {
        public string Id { get; set; }
        public string MaintainCode { get; set; }
        public string MaintainName { get; set; }
        public string MaintainPosition { get; set; }
        public string Address { get; set; }
        public string Certificate { get; set; }
        public string CertificateLevel { get; set; }
        public string EligibilityScope { get; set; }
        public string VerificationTime { get; set; }
    }
}
