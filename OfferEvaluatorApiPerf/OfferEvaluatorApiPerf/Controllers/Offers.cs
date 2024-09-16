using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OfferEvaluatorApiPerf.Controllers
{
    [Route("api/offers")]
    [ApiController]
    public class Offers : ControllerBase
    {
        // GET: api/offers/evaluate
        [HttpGet("evaluate-lock/{userId}")]
        public IEnumerable<string> GetEligibilityLock(string userId)
        {
            // Lock
            return ["value1", "value2", userId];
        }

        // GET api/<Offers>/5
        [HttpGet("evaluate-bag/{userId}")]
        public IEnumerable<string> GetEligibilityBag(string userId)
        {
            return ["value1", "value2", userId];
        }
    }
}
