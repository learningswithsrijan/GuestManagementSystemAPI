using DataAccessLayer;
using DataAccessLayer.Models;
using DataAccessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccomodationDetailsController : ControllerBase
    {
        private AccomodationDetailsService accomodationDetailsService;
        private GuestManagementSystemContext _context;
        public AccomodationDetailsController()
        {
            _context = new GuestManagementSystemContext();
            accomodationDetailsService = new AccomodationDetailsService(_context);
        }

        [HttpGet(Name = "GetAccomodationDetails")]
        public async Task<ActionResult<IEnumerable<AccomodationDetail>?>> GetAccomodationDetails()
        {
            var accomodationDetails = await accomodationDetailsService.GetAllAsync();

            if (accomodationDetails == null)
            {
                return NotFound();
            }

            return Ok(accomodationDetails);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AccomodationDetail?>> GetAccomodationDetails(int id)
        {
            var accomodationDetails = await accomodationDetailsService.GetByIDAsync(id);

            if (accomodationDetails == null)
            {
                return NotFound();
            }

            return Ok(accomodationDetails);
        }

        [HttpPost(Name = "PostAccomodationDetails")]
        public async Task<ActionResult<AccomodationDetail?>> PostAccomodationDetails(AccomodationDetail accomodationDetail)
        {
            var postAccomodationDetails = await accomodationDetailsService.Insert(accomodationDetail);

            if (postAccomodationDetails == 0)
                return NotFound();

            return CreatedAtAction(nameof(PostAccomodationDetails), accomodationDetail);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AccomodationDetail?>> PutAccomodationDetails(int id, AccomodationDetail accomodationDetail)
        {
            if (id != accomodationDetail.AccomodationId)
            {
                return BadRequest();
            }

            var postAccomodationDetails = await accomodationDetailsService.Update(accomodationDetail);

            if (postAccomodationDetails == 0)
                return NotFound();

            return NoContent();
        }

        [HttpDelete(Name = "DeleteAccomodationDetails")]
        public async Task<IActionResult> DeleteAccomodationDetails(AccomodationDetail accomodationDetail)
        {
            var todoItem = await accomodationDetailsService.Delete(accomodationDetail);

            if (todoItem == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccomodationDetails(int id)
        {
            var todoItem = await accomodationDetailsService.DeleteByID(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
