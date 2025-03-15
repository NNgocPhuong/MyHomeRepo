using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Members
    {
        public int Id { get; set; }  // Khóa chính
        public string UserName { get; set; } = string.Empty; // Tên đăng nhập
        public string PasswordHash { get; set; } = string.Empty; // Mã hóa mật khẩu
        public string FullName { get; set; } = string.Empty; // Tên đầy đủ
        public string Role { get; set; } = string.Empty; // Admin, Chủ quán, Nhân viên
        public bool IsActive { get; set; } = true; // Tài khoản có hoạt động không?
        public ICollection<EmployeeUsage> EmployeeUsages { get; set; } = new List<EmployeeUsage>();
    }
}
