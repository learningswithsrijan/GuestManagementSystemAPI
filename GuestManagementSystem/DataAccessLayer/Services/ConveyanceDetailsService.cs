using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public class ConveyanceDetailsService : CommonServices<ConveyanceDetail>
    {
        public ConveyanceDetailsService(GuestManagementSystemContext guestManagementSystemContext) : base(guestManagementSystemContext)
        {
        }
    }
}
