using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.Irepository
{
    public interface IVillaRepository
    {
        Task<List<Villa>> GetAllAsync(Expression<Func<Villa, bool>> filter = null);
        Task<Villa> GetAsync(Expression<Func<Villa, bool>> filter = null, bool tracked = false);
        Task CreateAsync(Villa villa);
        Task UpdateAsync(Villa villa);
        Task RemoveAsync(Villa villa);
        Task SaveAsync();
    }
}
