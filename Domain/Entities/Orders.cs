using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public int RoomUsageId { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public bool IsPaid { get; set; }

        public RoomUsageHistory RoomUsage { get; set; } = null!;
        public ICollection<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}
