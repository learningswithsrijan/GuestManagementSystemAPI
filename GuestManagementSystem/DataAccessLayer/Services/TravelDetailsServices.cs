using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public class TravelDetailsServices : CommonServices<TravelDetail>
    {
        public TravelDetailsServices(GuestManagementSystemContext guestManagementSystemContext) : base(guestManagementSystemContext)
        {
        }
    }
}
