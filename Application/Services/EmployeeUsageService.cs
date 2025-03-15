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
    public class EmployeeUsageService : IEmployeeUsageService
    {
        private readonly IRepository<EmployeeUsage> _repository;

        public EmployeeUsageService(IRepository<EmployeeUsage> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EmployeeUsage>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<EmployeeUsage> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(EmployeeUsage employeeUsage)
        {
            await _repository.AddAsync(employeeUsage);
        }

        public async Task UpdateAsync(EmployeeUsage employeeUsage)
        {
            await _repository.UpdateAsync(employeeUsage);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
