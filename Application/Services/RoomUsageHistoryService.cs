using Application.IServices;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class RoomUsageHistoryService : IRoomUsageHistoryService
    {
        private readonly IRepository<RoomUsageHistory> _repository;

        public RoomUsageHistoryService(IRepository<RoomUsageHistory> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<RoomUsageHistory>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<RoomUsageHistory> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(RoomUsageHistory roomUsageHistory)
        {
            await _repository.AddAsync(roomUsageHistory);
        }

        public async Task UpdateAsync(RoomUsageHistory roomUsageHistory)
        {
            await _repository.UpdateAsync(roomUsageHistory);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
