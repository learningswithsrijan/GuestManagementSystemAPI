using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public class GuestDetailsService : CommonServices<GuestDetail>
    {
        public GuestDetailsService(GuestManagementSystemContext guestManagementSystemContext) : base(guestManagementSystemContext)
        {
            
        }

        public async Task<GuestDetail?> GetByIDAsync(int ID)
        {
            var entities = await _entities.FindAsync(ID);

            if (entities == null)
            {
                return null;
            }

            return entities;
        }

        public async Task<int?> DeleteByID(int ID)
        { 
            var entity = await _entities.FindAsync(ID);
            
            if (entity == null)
            {
                return null;
            }
            return await base.Delete(entity);
        }
    }
}
