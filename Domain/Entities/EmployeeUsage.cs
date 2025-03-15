using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EmployeeUsage
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int RoomUsageId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public RoomUsageHistory RoomUsage { get; set; } = null!;
        public Members Employee { get; set; } = null!;
    }
}
