using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public class AccomodationDetailsService : CommonServices<AccomodationDetail>
    {
        public AccomodationDetailsService(GuestManagementSystemContext guestManagementSystemContext) : base(guestManagementSystemContext)
        {
        }

        public async Task<AccomodationDetail?> GetByIDAsync(int ID)
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
