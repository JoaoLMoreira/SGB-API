using SgbProject.Data;
using SgbProject.Models;
using SgbProject.Repositories;

namespace SgbProject.Services
{
    public interface IBovinosService
    {
        public IEnumerable<Bovino> GetAllBovinos();
        public Bovino GetBovino(Guid id);
        public Bovino AddBovino(Bovino bovino);
        public Bovino UpdateBovino(Bovino bovino);
        public RemoveBovinoRequest Delete(RemoveBovinoRequest command);

    }

}
