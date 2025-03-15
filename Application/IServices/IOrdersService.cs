using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IOrdersService
    {
        Task<IEnumerable<Orders>> GetAllAsync();
        Task<Orders> GetByIdAsync(int id);
        Task AddAsync(Orders order);
        Task UpdateAsync(Orders order);
        Task DeleteAsync(int id);
    }
}
