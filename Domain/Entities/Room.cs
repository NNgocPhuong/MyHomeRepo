

namespace Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RoomType { get; set; } = string.Empty;
        public decimal PricePerHour { get; set; }
        public string Status { get; set; } = "Available"; // "Available", "Occupied", "Maintenance"
        public ICollection<RoomUsageHistory> histories { get; set; } = new List<RoomUsageHistory>();
    }
}
