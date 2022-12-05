using SgbProject.Data;
using SgbProject.Models;

namespace SgbProject.Repositories
{
    public class BaixaRepository : GenericRepository<Baixa>
    {
        public BaixaRepository(Context context) : base(context)
        {
        }
    }
}
