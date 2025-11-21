using Microsoft.AspNetCore.Mvc;

namespace API_SIMPLIFICADA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRoles()
        {
            // Datos hardcodeados - No necesita SQL Server
            var roles = new List<Rol>
            {
                new Rol { Id = 1, Nombre = "Administrador", Descripcion = "Usuario con permisos completos" },
                new Rol { Id = 2, Nombre = "Usuario", Descripcion = "Usuario estándar" },
                new Rol { Id = 3, Nombre = "Editor", Descripcion = "Usuario con permisos de edición" }
            };

            return Ok(roles);
        }
    }

    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
    }
}

