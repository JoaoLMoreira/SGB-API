using SgbProject.Models;

namespace SgbProject.Services
{
    public interface IUsuariosService
    {
        IEnumerable<Usuario> GetAllUsuarios();
        Usuario GetById(Guid id);
        Usuario Add(Usuario usuario);
        Usuario Update(Usuario usuario);
        Usuario Delete(Guid id);
    }
}
