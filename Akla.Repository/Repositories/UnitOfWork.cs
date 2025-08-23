using Akla.SharedData.Context;
using Microsoft.EntityFrameworkCore;

namespace Akla.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AklaDbContext _context;
        private readonly Dictionary<Type, object> _repositories;
        private bool _isDisposed;

        public UnitOfWork(AklaDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _repositories = new Dictionary<Type, object>();
        }

        public IGenericRepository<T> Repository<T>() where T : BaseEntity
        {
            if (_repositories.TryGetValue(typeof(T), out var repo))
            {
                if (repo is IGenericRepository<T> typedRepo)
                {
                    return typedRepo;
                }
                throw new InvalidCastException($"Stored repository is not of expected type {typeof(T).Name}");
            }

            var repositoryInstance = new GenericRepository<T>(_context);
            _repositories[typeof(T)] = repositoryInstance;

            return repositoryInstance;
        }

        public async Task<int> SaveChangesAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // Ideally log here before throwing
                throw new RepositoryException("An error occurred while saving changes to the database.", ex);
            }
        }

        //// Optional: Execute multiple operations in one transaction
        //public async Task ExecuteInTransactionAsync(Func<Task> action)
        //{
        //    if (action == null) throw new ArgumentNullException(nameof(action));

        //    using var transaction = await _context.Database.BeginTransactionAsync();
        //    try
        //    {
        //        await action();
        //        await _context.SaveChangesAsync();
        //        await transaction.CommitAsync();
        //    }
        //    catch
        //    {
        //        await transaction.RollbackAsync();
        //        throw;
        //    }
        //}

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed && disposing)
            {
                foreach (var repo in _repositories.Values.OfType<IDisposable>())
                {
                    repo.Dispose();
                }

                _context.Dispose();
                _isDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}