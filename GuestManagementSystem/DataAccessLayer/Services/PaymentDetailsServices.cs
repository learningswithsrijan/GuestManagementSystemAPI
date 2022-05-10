using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public class PaymentDetailsServices : CommonServices<PaymentDetail>
    {
        public PaymentDetailsServices(GuestManagementSystemContext guestManagementSystemContext) : base(guestManagementSystemContext)
        {
        }
    }
}
