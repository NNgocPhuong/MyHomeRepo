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
    public class ProductsService : IProductsService
    {
        private readonly IRepository<Products> _repository;

        public ProductsService(IRepository<Products> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Products>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Products> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Products product)
        {
            await _repository.AddAsync(product);
        }

        public async Task UpdateAsync(Products product)
        {
            await _repository.UpdateAsync(product);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
