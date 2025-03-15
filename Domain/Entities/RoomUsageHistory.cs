using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RoomUsageHistory
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal TotalPrice { get; set; }
        // Quan hệ với bảng Room
        public Room Room { get; set; } = null!;

        public ICollection<EmployeeUsage> EmployeeUsages { get; set; } = new List<EmployeeUsage>();
    }
}
