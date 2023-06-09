using Microsoft.AspNetCore.Mvc;
using TallerBackendRubioMero.models;

namespace TallerBackendRubioMero.Controllers
{

    [ApiController]
    [Route("api/usuario")]

    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return Ok();
        }

    }
}
