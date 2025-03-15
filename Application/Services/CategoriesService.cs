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
    public class CategoriesService : ICategoriesService
    {
        private readonly IRepository<Categories> _repository;

        public CategoriesService(IRepository<Categories> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Categories>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Categories> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Categories category)
        {
            await _repository.AddAsync(category);
        }

        public async Task UpdateAsync(Categories category)
        {
            await _repository.UpdateAsync(category);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
