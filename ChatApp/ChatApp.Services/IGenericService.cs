using ChatApp.Data.Entities;
using ChatApp.Data.Models;

namespace ChatApp.Services
{
    public interface IGenericService<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task<int> CountAsync();
        Task<T> DeleteAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync(PaginationModel paginationModel);
        Task<T> UpdateAsync(T entity);

    }
}
