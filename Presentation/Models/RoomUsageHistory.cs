using Domain.Entities;

namespace Presentation.Models
{
    public class RoomUsageHistory
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal TotalPrice { get; set; }
        
    }
}
