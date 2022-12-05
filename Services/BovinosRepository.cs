using Microsoft.EntityFrameworkCore;
using SgbProject.Data;
using SgbProject.Enums;
using SgbProject.Models;
using SgbProject.Repositories;

namespace SgbProject.Service
{
    public class BovinosRepository : GenericRepository<Bovino>
    {
        public BovinosRepository(Context context) : base(context)
        {
        }
    }
}
