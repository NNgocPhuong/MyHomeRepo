using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface ICategoriesService
    {
        Task<IEnumerable<Categories>> GetAllAsync();
        Task<Categories> GetByIdAsync(int id);
        Task AddAsync(Categories category);
        Task UpdateAsync(Categories category);
        Task DeleteAsync(int id);
    }
}
