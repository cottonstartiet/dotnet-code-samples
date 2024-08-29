using FourTierAppSample.BusinessLogic;
using FourTierAppSample.Controllers.Dto;
using FourTierAppSample.Controllers.Mapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FourTierAppSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly UserProfileBusinessLogic userProfileBusinessLogic;

        public UserProfileController(UserProfileBusinessLogic userProfileBusinessLogic)
        {
            this.userProfileBusinessLogic = userProfileBusinessLogic;
        }

        // GET api/<UserProfileController>/5
        [HttpGet("{id}")]
        public ActionResult<UserProfileResponse> Get(string userId)
        {
            Models.UserProfile userProfile = userProfileBusinessLogic.GetUserProfileById(userId);
            return Ok(UserProfileToDtoMapper.Map(userProfile));
        }

        // POST api/<UserProfileController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserProfileController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserProfileController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
