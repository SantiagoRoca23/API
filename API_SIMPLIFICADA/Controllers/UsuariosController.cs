using Microsoft.AspNetCore.Mvc;

namespace API_SIMPLIFICADA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsuarios()
        {
            // Datos hardcodeados - No necesita SQL Server
            var usuarios = new List<Usuario>
            {
                new Usuario
                {
                    Id = 1,
                    Nombre = "Juan Pérez",
                    Email = "juan@ejemplo.com",
                    Telefono = "1234567890",
                    RolId = 1,
                    Rol = new Rol { Id = 1, Nombre = "Administrador", Descripcion = "Usuario con permisos completos" }
                },
                new Usuario
                {
                    Id = 2,
                    Nombre = "María García",
                    Email = "maria@ejemplo.com",
                    Telefono = "0987654321",
                    RolId = 2,
                    Rol = new Rol { Id = 2, Nombre = "Usuario", Descripcion = "Usuario estándar" }
                },
                new Usuario
                {
                    Id = 3,
                    Nombre = "Carlos López",
                    Email = "carlos@ejemplo.com",
                    Telefono = "1122334455",
                    RolId = 3,
                    Rol = new Rol { Id = 3, Nombre = "Editor", Descripcion = "Usuario con permisos de edición" }
                },
                new Usuario
                {
                    Id = 4,
                    Nombre = "Ana Martínez",
                    Email = "ana@ejemplo.com",
                    Telefono = "5566778899",
                    RolId = 2,
                    Rol = new Rol { Id = 2, Nombre = "Usuario", Descripcion = "Usuario estándar" }
                },
                new Usuario
                {
                    Id = 5,
                    Nombre = "Pedro Rodríguez",
                    Email = "pedro@ejemplo.com",
                    Telefono = "9988776655",
                    RolId = 1,
                    Rol = new Rol { Id = 1, Nombre = "Administrador", Descripcion = "Usuario con permisos completos" }
                }
            };

            return Ok(usuarios);
        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Telefono { get; set; }
        public int RolId { get; set; }
        public Rol? Rol { get; set; }
    }

    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
    }
}

