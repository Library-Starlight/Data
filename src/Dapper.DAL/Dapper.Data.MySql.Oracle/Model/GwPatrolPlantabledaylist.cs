using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwPatrolPlantabledaylist
    {
        public int? PlanTableDayListId { get; set; }
        public int? PlanTableId { get; set; }
        public int? Day { get; set; }
        public int? Orders { get; set; }
    }
}
