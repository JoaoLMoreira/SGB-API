using Microsoft.AspNetCore.Mvc;
using SgbProject.Models;
using SgbProject.Services;

namespace SgbProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaixasController
    {
        private readonly IBaixasServices _baixasService;
        public BaixasController(IBaixasServices baixasService)
        {
            _baixasService = baixasService;
        }

        [HttpGet]
        public IEnumerable<Baixa> GetAllBaixas()
        {
            var baixas = _baixasService.GetAllBaixas();
            return (baixas);
        }

    }
}
