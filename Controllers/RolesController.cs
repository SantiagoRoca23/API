using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRoles()
        {
            // Datos hardcodeados - Listo para Railway
            var roles = new List<Rol>
            {
                new Rol
                {
                    Id = 1,
                    Nombre = "Administrador",
                    Descripcion = "Usuario con permisos completos del sistema"
                },
                new Rol
                {
                    Id = 2,
                    Nombre = "Usuario",
                    Descripcion = "Usuario estándar con permisos básicos"
                },
                new Rol
                {
                    Id = 3,
                    Nombre = "Editor",
                    Descripcion = "Usuario con permisos de edición y modificación"
                }
            };

            return Ok(roles);
        }
    }
}

