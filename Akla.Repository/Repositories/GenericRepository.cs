using Akla.SharedData.Context;
using Microsoft.EntityFrameworkCore;

namespace Akla.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AklaDbContext _context;
        private readonly DbSet<T> _query;

        public GenericRepository(AklaDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _query = _context.Set<T>();
        }

        public async Task<T?> GetByIdAsync(long id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("Invalid id provided.", nameof(id));

                var result = await _query.FindAsync(id);
                if (result is not null)
                    return result;

                return await _query.FirstOrDefaultAsync(q => q.Id == id);
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Error retrieving {typeof(T).Name} by id {id}.", ex);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync(bool isAsNoTracking)
        {
            try
            {
                if (isAsNoTracking)
                    return await _query.AsNoTracking().ToListAsync();

                return await _query.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Error retrieving all {typeof(T).Name} entities.", ex);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate, bool isAsNoTracking)
        {
            try
            {
                if (predicate == null)
                    throw new ArgumentNullException(nameof(predicate));

                if (isAsNoTracking)
                    return await _query.AsNoTracking().Where(predicate).ToListAsync();

                return await _query.Where(predicate).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Error finding {typeof(T).Name} entities.", ex);
            }
        }

        public async Task AddAsync(T entity)
        {
            try
            {
                if (entity is null)
                    throw new ArgumentNullException(nameof(entity));

                await _query.AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Error adding {typeof(T).Name}.", ex);
            }
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null || !entities.Any())
                    throw new ArgumentException("No entities provided for addition.", nameof(entities));

                await _query.AddRangeAsync(entities);
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Error adding multiple {typeof(T).Name} entities.", ex);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                if(entity is null)
                    throw new ArgumentNullException(nameof(entity));

                var existEntity = await GetByIdAsync(entity.Id);

                if(existEntity is null)
                    throw new KeyNotFoundException($"{typeof(T).Name} with id {entity.Id} not found.");

                _query.Update(entity);
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Error updating {typeof(T).Name}.", ex);
            }
        }

        public async Task DeleteAsync(long id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("Invalid id provided.", nameof(id));

                var existEntity = await GetByIdAsync(id);

                if (existEntity is null)
                    throw new KeyNotFoundException($"{typeof(T).Name} with id {id} not found.");

                _query.Remove(existEntity);
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Error deleting {typeof(T).Name} by id {id}.", ex);
            }
        }

        public async Task DeleteAsync(T entity)
        {
            try
            {
                if (entity is null)
                    throw new ArgumentNullException(nameof(entity));

                var existEntity = await GetByIdAsync(entity.Id);

                if (existEntity is null)
                    throw new KeyNotFoundException($"{typeof(T).Name} with id {entity.Id} not found.");

                _query.Remove(existEntity);
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Error deleting {typeof(T).Name}.", ex);
            }
        }
    }

    /// <summary>
    /// Custom repository exception to wrap low-level data access errors.
    /// </summary>
    public class RepositoryException : Exception
    {
        public RepositoryException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}


