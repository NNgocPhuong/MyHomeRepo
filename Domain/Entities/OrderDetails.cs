using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }  // Nullable vì có thể không dùng nếu tính theo giờ
        public decimal UnitPrice { get; set; }

        // Nếu là dịch vụ tính theo giờ
        public int? EmployeeId { get; set; } // Nếu là nhân viên thì có EmployeeId
        public DateTime? StartTime { get; set; } // Chỉ dùng nếu là dịch vụ nhân viên
        public DateTime? EndTime { get; set; } // Chỉ dùng nếu là dịch vụ nhân viên

        public Orders Order { get; set; } = null!;
        public Products Product { get; set; } = null!;
        public Members? Employee { get; set; } // Nếu là nhân viên thì có giá trị
    }
}
