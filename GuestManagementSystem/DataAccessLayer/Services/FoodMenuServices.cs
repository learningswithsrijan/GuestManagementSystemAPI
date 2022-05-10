using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public class FoodMenuServices : CommonServices<FoodMenu>
    {
        public FoodMenuServices(GuestManagementSystemContext guestManagementSystemContext) : base(guestManagementSystemContext)
        {
        }
    }
}
