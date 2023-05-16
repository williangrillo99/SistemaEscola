using Microsoft.AspNetCore.Mvc;
using SistemaAula.Date;
using SistemaAula.Entidades;

namespace SistemaAula.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private APIDbContext apiDbContext;

        public UsuarioController(APIDbContext aPIDbContext) {
            
            apiDbContext = aPIDbContext;
        }

        [HttpPost]
        public ActionResult<Usuario> AdicionarUsuario(string login, string senha)
        {
            Usuario usuario = new Usuario(login, senha);

            apiDbContext.Add(usuario);
            apiDbContext.SaveChanges();

            return usuario;
        }


        [HttpDelete]
        public ActionResult DeletarUsuario(int id)
        {
            Usuario usuario = apiDbContext.Usuarios.FirstOrDefault(x => x.Id == id);
            apiDbContext.Remove(usuario);
            apiDbContext.SaveChanges();

            return Ok(usuario);
        }

        [HttpGet]
        public IEnumerable<Usuario> RetonarUsuario()
        {
            return apiDbContext.Usuarios;
        }
    }
}
