using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services
{
    public class CommonServices<T> where T : class
    {
        internal readonly GuestManagementSystemContext _guestManagementSystemContext;
        internal DbSet<T> _entities;

        public CommonServices(GuestManagementSystemContext guestManagementSystemContext)
        {
            this._guestManagementSystemContext = guestManagementSystemContext;
            _entities = _guestManagementSystemContext.Set<T>();            
        }

        public async Task<IEnumerable<T>?> GetAllAsync()
        {
            var entities = await _entities.ToListAsync();

            if (entities == null)
            {
                return null;
            }

            return entities;
        }
        
        public async Task<int> Insert(T entity)
        {
            if (entity == null)
            {
                return default(int);
            }
            _entities.Add(entity);
            return await _guestManagementSystemContext.SaveChangesAsync();
        }

        public async Task<int> Update(T entity)
        {
            if (entity == null)
            {
                return default(int);
            }
            return await _guestManagementSystemContext.SaveChangesAsync();
        }

        public async Task<int> Delete(T entity)
        {
            if (entity == null)
            {
                return default(int);
            }
            _entities.Remove(entity);
            return await _guestManagementSystemContext.SaveChangesAsync();
        }
    }
}
