﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Woacceptorder
    {
        public int Id { get; set; }
        public string WorkOrderId { get; set; }
        public int CurrentProcessor { get; set; }
        public string Personnel { get; set; }
        public int Claim { get; set; }
        public string TransferPersonnel { get; set; }
        public string CreatedTime { get; set; }
    }
}
