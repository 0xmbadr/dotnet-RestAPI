using BuberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BreakfastsController : ControllerBase
    {
       [HttpPost("/breakfasts")]
        public IActionResult Create(CreateBreakfastRequest request)
        {
            return Ok();
        }
    }
}