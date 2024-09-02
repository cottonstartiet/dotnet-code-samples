using Microsoft.AspNetCore.Mvc;
using UserProfile.Shared.Contract;
using UserProfileApi.BusinessLogic;
using UserProfileApi.Mappers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserProfileApi.Controllers
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
            Models.UserProfileInfo userProfileInfo = userProfileBusinessLogic.GetUserProfile(userId);
            return Ok(UserProfileMapper.MapFrom(userProfileInfo));
        }
    }
}
