﻿using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwnavigationproperty
    {
        public int Id { get; set; }
        public string NavigateType { get; set; }
        public string NormalImage { get; set; }
        public string AlarmImage { get; set; }
        public string GuanlianComb { get; set; }
        public string PageComb { get; set; }
        public int? Enable { get; set; }
    }
}
