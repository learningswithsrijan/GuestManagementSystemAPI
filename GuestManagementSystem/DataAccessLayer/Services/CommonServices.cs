using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services
{
    public class CommonServices<T> where T : class
    {
        private readonly GuestManagementSystemContext _guestManagementSystemContext;
        private DbSet<T> _entities;

        public CommonServices(GuestManagementSystemContext guestManagementSystemContext)
        {
            this._guestManagementSystemContext = guestManagementSystemContext;
            _entities = _guestManagementSystemContext.Set<T>();            
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }
        
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entities.Add(entity);
            _guestManagementSystemContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _guestManagementSystemContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entities.Remove(entity);
            _guestManagementSystemContext.SaveChanges();
        }
    }
}
