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
    public class MembersService : IMembersService
    {
        private readonly IRepository<Members> _repository;

        public MembersService(IRepository<Members> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Members>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Members> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Members member)
        {
            await _repository.AddAsync(member);
        }

        public async Task UpdateAsync(Members member)
        {
            await _repository.UpdateAsync(member);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
