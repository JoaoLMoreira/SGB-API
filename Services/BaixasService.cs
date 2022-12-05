using SgbProject.Models;
using SgbProject.Repositories;

namespace SgbProject.Services
{
    public class BaixasService : IBaixasServices
    {
        private readonly IRepository<Baixa> _baixaRepository;

        public BaixasService(IRepository<Baixa> baixaRepository)
        {
            _baixaRepository = baixaRepository;
        }

        public IEnumerable<Baixa> GetAllBaixas()
        {
            return _baixaRepository.GetAll();
        }
    }
}
