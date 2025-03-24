namespace Presentation.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }  // Giá bán hoặc giá thuê theo giờ
        public int CategoryId { get; set; }
        public bool IsHourly { get; set; } = false;  // Có phải tính theo giờ không?
    }
}
