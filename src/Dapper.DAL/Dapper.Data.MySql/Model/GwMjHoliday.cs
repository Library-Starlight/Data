using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwMjHoliday
    {
        public int? HolidayId { get; set; }
        public string HolidayName { get; set; }
        public DateTime? HolidayStart { get; set; }
        public DateTime? HolidayEnd { get; set; }
    }
}
