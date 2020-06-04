using System;
using System.Linq;
using System.Threading.Tasks;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private readonly RepositoryPatternDemoContext _repositoryPatternDemoContextContext;

        public Repository(RepositoryPatternDemoContext repositoryPatternDemoContextContext)
        {
            _repositoryPatternDemoContextContext = repositoryPatternDemoContextContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return _repositoryPatternDemoContextContext.Set<TEntity>();
            }
            catch (Exception)
            {
                throw new Exception("Couldn't retrieve entities");
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
                await _repositoryPatternDemoContextContext.AddAsync(entity);
                await _repositoryPatternDemoContextContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be saved");
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
                _repositoryPatternDemoContextContext.Update(entity);
                await _repositoryPatternDemoContextContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be updated");
            }
        }
    }
}