using Microsoft.AspNetCore.Mvc;

namespace RoutingDIExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private StudentService service;

        public HomeController(StudentService service)
        {
            this.service = service;
        }

        [HttpGet]
        public string Get()
        {
            return service.GetStudent();
        }
    }
}