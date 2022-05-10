using DataAccessLayer;
using DataAccessLayer.Models;
using DataAccessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GMS.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GuestDetailsController : ControllerBase
    {
        private GuestDetailsService guestDetailsService;
        private GuestManagementSystemContext _context;
        public GuestDetailsController()
        {
            _context = new GuestManagementSystemContext();
            guestDetailsService = new GuestDetailsService(_context);
        }

        [HttpGet(Name = "GetGuestDetails")]
        public IEnumerable<GuestDetail> GetGuestDetails()
        {
            return guestDetailsService.GetAll();
        }
    }
}
