﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwLanguage
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int? LanguageType { get; set; }
        public int? VoiceType { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
    }
}
