using SgbProject.Data;
using SgbProject.Models;

namespace SgbProject.Repositories
{
    public class UsuariosRepository : GenericRepository<Usuario>
    {
        public UsuariosRepository(Context context) : base(context)
        {

        }

    }
}
