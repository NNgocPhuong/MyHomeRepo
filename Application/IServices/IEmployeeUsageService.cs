using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IEmployeeUsageService
    {
        Task<IEnumerable<EmployeeUsage>> GetAllAsync();
        Task<EmployeeUsage> GetByIdAsync(int id);
        Task AddAsync(EmployeeUsage employeeUsage);
        Task UpdateAsync(EmployeeUsage employeeUsage);
        Task DeleteAsync(int id);
    }
}
