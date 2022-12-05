using SgbProject.Data;
using SgbProject.Models;
using SgbProject.Repositories;

namespace SgbProject.Service
{
    public class BaixaRepository : GenericRepository<Baixa>
    {
        public BaixaRepository(Context context) : base(context)
        {
        }
    }
}
