﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Welcomingspeech
    {
        public string Jsoncontent { get; set; }
        public string BgImage { get; set; }
        public int? Type { get; set; }
        public string SiginalVal { get; set; }
        public int Id { get; set; }
    }
}
