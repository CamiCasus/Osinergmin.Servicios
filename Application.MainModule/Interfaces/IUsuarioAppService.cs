using Application.Dto;

namespace Application.MainModule.Interfaces
{
    public interface IUsuarioAppService
    {
        UsuarioLoginDto Autenticar(string usuario, string password);
    }
}
