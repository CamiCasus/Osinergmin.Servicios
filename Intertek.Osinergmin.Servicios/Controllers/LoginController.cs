using Application.Dto;
using Application.MainModule.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Distributed.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    public class LoginController : Controller
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public LoginController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        [HttpPost("/api/autenticar")]
        public bool Listado([FromBody] UsuarioLoginDto login)
        {
            return _usuarioAppService.Autenticar(login.Usuario, login.Password);
        }
    }
}