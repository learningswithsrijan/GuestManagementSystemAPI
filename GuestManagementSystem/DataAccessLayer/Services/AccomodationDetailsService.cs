using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public class AccomodationDetailsService : CommonServices<AccomodationDetail>
    {
        public AccomodationDetailsService(GuestManagementSystemContext guestManagementSystemContext) : base(guestManagementSystemContext)
        {
        }
    }
}
