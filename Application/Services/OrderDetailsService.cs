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
    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly IRepository<OrderDetails> _repository;

        public OrderDetailsService(IRepository<OrderDetails> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<OrderDetails>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<OrderDetails> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(OrderDetails orderDetails)
        {
            await _repository.AddAsync(orderDetails);
        }

        public async Task UpdateAsync(OrderDetails orderDetails)
        {
            await _repository.UpdateAsync(orderDetails);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
