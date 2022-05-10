using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public class FoodDetailsServices : CommonServices<FoodDetail>
    {
        public FoodDetailsServices(GuestManagementSystemContext guestManagementSystemContext) : base(guestManagementSystemContext)
        {
        }
    }
}
