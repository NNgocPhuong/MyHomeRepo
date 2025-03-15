using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IProductsService
    {
        Task<IEnumerable<Products>> GetAllAsync();
        Task<Products> GetByIdAsync(int id);
        Task AddAsync(Products product);
        Task UpdateAsync(Products product);
        Task DeleteAsync(int id);
    }
}
