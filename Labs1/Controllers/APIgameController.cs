using Labs1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labs1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIgameController : ControllerBase
    {
        public IActionResult Get()
        {
            Game106Model game106 = new Game106Model
            {
                CourseName = "Back-End Game Programming",
                CourseCode = "GAM106",
                Name = "Nguyễn Văn A",
                StudentCode = "PS12345",
                Class = "GA19305",
            };
            int status = 1;
            string message = "Get data sucess!";
            var data = new { status, message, game106 };
            return new JsonResult(data);
        }
    }
}
