using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IMembersService
    {
        Task<IEnumerable<Members>> GetAllAsync();
        Task<Members> GetByIdAsync(int id);
        Task AddAsync(Members member);
        Task UpdateAsync(Members member);
        Task DeleteAsync(int id);
    }
}
