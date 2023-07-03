using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalRoutePrefixApp.Controllers
{
    [Route("RoutePrefixTest")]
    [ApiController]
    public class RoutePrefixTestController : ControllerBase
    {
        public IActionResult GetCity()
        {
            var checkBaseRoutePath = HttpContext.Request.PathBase;

            var cityList = new List<City>()
            {
                new City { Id = 101, Name = "Alberta" },
                new City { Id = 102, Name = "Toronto" },
                new City { Id = 103, Name = "British Comlombia" },
            };
            return Ok(cityList);
        }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
