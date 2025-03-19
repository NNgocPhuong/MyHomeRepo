using System.ComponentModel;

namespace Presentation.Models
{
    public class Rooms
    {
        public int Id { get; set; }
        [DisplayName("Tên phòng")]
        public string Name { get; set; } = string.Empty;
        [DisplayName("Loại phòng")]
        public string RoomType { get; set; } = string.Empty;
        [DisplayName("Giá theo giờ")]
        public decimal PricePerHour { get; set; }
        [DisplayName("Trạng thái")]
        public string Status { get; set; } = "Available"; // "Available", "Occupied", "Maintenance"
    }
}
