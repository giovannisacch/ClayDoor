using Microsoft.AspNetCore.Mvc;

namespace ClayDoor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoorController : Controller
    {
        public DoorController()
        {

        }
        [HttpGet]
        public async Task <ActionResult> OpenDoor(Guid idDoor, Guid idUser)
        {
            return 
        }
    }
}
