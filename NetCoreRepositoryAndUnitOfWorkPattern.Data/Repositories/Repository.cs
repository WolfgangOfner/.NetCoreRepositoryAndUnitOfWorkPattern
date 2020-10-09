using System;
using System.Linq;
using System.Threading.Tasks;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly RepositoryPatternDemoContext RepositoryPatternDemoContext;

        public Repository(RepositoryPatternDemoContext repositoryPatternDemoContext)
        {
            RepositoryPatternDemoContext = repositoryPatternDemoContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return RepositoryPatternDemoContext.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await RepositoryPatternDemoContext.AddAsync(entity);
                await RepositoryPatternDemoContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                RepositoryPatternDemoContext.Update(entity);
                await RepositoryPatternDemoContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
    }
}