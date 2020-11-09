using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.DAL.Model
{
    public class EquipEvent
    {
        public int EquipNo { get; set; }
        public int PointNo { get; set; }
        public string Event { get; set; }
        public DateTime Time { get; set; }
    }
}
