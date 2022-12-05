using SgbProject.Models;

namespace SgbProject.Services
{
    public interface IUsuariosService
    {
        Task<List<Usuario>> GetAll();
        Task<Usuario> GetById(Guid id);
        Task<Usuario> Add(Usuario usuario);
        Task<Usuario> Update(Usuario usuario, Guid id);
        Task<Usuario> Delete(Guid id);
    }
}
