using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T:BaseEntity 
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdatetAsync(T item);
        Task<bool> DeleteAsync(Guid id);
        Task<T> SelectAsync(Guid id);
        Task<IEnumerable<T>> SelectAsync(PaginationFilter filter);
        Task<bool> ExistAsync(Guid id);

        Task<IEnumerable<T>> GetAll();

        Task<bool> HasTimeByName(string name);

        Task<int> CountAsync();
    }
}
