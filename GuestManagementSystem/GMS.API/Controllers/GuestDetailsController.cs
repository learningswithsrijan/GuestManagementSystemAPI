using DataAccessLayer;
using DataAccessLayer.Models;
using DataAccessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GMS.API.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<ActionResult<IEnumerable<GuestDetail>?>> GetGuestDetails()
        {
            var guestDetails = await guestDetailsService.GetAllAsync();
            
            if (guestDetails == null)
            {
                return NotFound();
            }

            return Ok(guestDetails);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GuestDetail?>> GetGuestDetails(int id)
        {
            var guestDetails = await guestDetailsService.GetByIDAsync(id);

            if (guestDetails == null)
            {
                return NotFound();
            }

            return Ok(guestDetails);
        }

        [HttpPost(Name = "PostGuestDetails")]
        public async Task<ActionResult<GuestDetail?>> PostGuestDetails(GuestDetail guestDetail)
        {
            var postGuestDetails = await guestDetailsService.Insert(guestDetail);
            
            if (postGuestDetails == 0)
                return NotFound();
            
            return CreatedAtAction(nameof(PostGuestDetails), guestDetail);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GuestDetail?>> PutGuestDetails(int id, GuestDetail guestDetail)
        {
            if (id != guestDetail.GuestId)
            {
                return BadRequest();
            }

            var postGuestDetails = await guestDetailsService.Update(guestDetail);

            if (postGuestDetails == 0)
                return NotFound();

            return NoContent();
        }

        [HttpDelete(Name = "DeleteGuestDetails")]
        public async Task<IActionResult> DeleteGuestDetails(GuestDetail guestDetail)
        {
            var todoItem = await guestDetailsService.Delete(guestDetail);

            if (todoItem == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuestDetails(int id)
        {
            var todoItem = await guestDetailsService.DeleteByID(id);
            
            if (todoItem == null)
            {
                return NotFound();
            }          

            return NoContent();
        }
    }
}
