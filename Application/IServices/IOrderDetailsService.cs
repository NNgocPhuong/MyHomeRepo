using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IOrderDetailsService
    {
        Task<IEnumerable<OrderDetails>> GetAllAsync();
        Task<OrderDetails> GetByIdAsync(int id);
        Task AddAsync(OrderDetails orderDetails);
        Task UpdateAsync(OrderDetails orderDetails);
        Task DeleteAsync(int id);
    }
}
