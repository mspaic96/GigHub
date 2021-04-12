using System.Linq;
using System.Web.Http;
using GigHubMosh.Dtos;
using GigHubMosh.Models;
using Microsoft.AspNet.Identity;

namespace GigHubMosh.Controllers.Api
{
    [Authorize]
    public class FollowingsController : ApiController
    {

        private ApplicationDbContext _context;

        private FollowingsController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto dto)
        {
            var userId = User.Identity.GetUserId();
            if (_context.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == dto.FolloweeId))
                return BadRequest("Following already exists.");

            var following = new Following
            {
                FollowerId = userId,
                FolloweeId = dto.FolloweeId

            };
            _context.Followings.Add(following);
            _context.SaveChanges();
            return Ok();

        }
    }
}
