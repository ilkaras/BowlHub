using BowlHub.DAL.Entities;

namespace BowlHub.DAL.Repositories.Interfaces;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> AddAsync(TEntity entity);
    Task DeleteAsync(Guid id);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<TEntity> GetByIdAsync(Guid id);
    IQueryable<TEntity> GetAll();
}