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
    public class OrdersService : IOrdersService
    {
        private readonly IRepository<Orders> _repository;

        public OrdersService(IRepository<Orders> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Orders>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Orders> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Orders order)
        {
            await _repository.AddAsync(order);
        }

        public async Task UpdateAsync(Orders order)
        {
            await _repository.UpdateAsync(order);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
