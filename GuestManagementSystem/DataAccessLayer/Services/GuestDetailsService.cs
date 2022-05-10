﻿using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public class GuestDetailsService : CommonServices<GuestDetail>
    {
        public GuestDetailsService(GuestManagementSystemContext guestManagementSystemContext) : base(guestManagementSystemContext)
        {
            
        }
    }
}
