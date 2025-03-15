using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IRoomUsageHistoryService
    {
        Task<IEnumerable<RoomUsageHistory>> GetAllAsync();
        Task<RoomUsageHistory> GetByIdAsync(int id);
        Task AddAsync(RoomUsageHistory roomUsageHistory);
        Task UpdateAsync(RoomUsageHistory roomUsageHistory);
        Task DeleteAsync(int id);
    }
}
