using Minimal_API.Dominio.DTOs;
using Minimal_API.Dominio.Entidades;
using MinimalApi.DTOs;

namespace Minimal_API.Dominio.Interfaces
{
    public interface IAdministradorServico
    {
        Administrador? Login(LoginDTO loginDTO);
        Administrador Incluir(Administrador administrador);
        Administrador? BuscaPorId(int id);
        List<Administrador> Todos(int? pagina);

    }
}