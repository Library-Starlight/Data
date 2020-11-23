﻿using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwPatrolCard
    {
        public int CardId { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public int? Orders { get; set; }
        public int? GroupId { get; set; }
    }
}
