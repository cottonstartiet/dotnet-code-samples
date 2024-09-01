using Microsoft.AspNetCore.Mvc;
using NTierAppSample.Controllers.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NTierAppSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        public class UserProfileController(UserProfileBusinessLogic userProfileBusinessLogic)
        {

        }

        // GET api/<UserProfileController>/5
        [HttpGet("{id}")]
        public ActionResult<UserProfileResponse> Get(int id)
        {
            return;
        }

        // POST api/<UserProfileController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
