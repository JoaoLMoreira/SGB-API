using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SgbProject.Data;
using SgbProject.Models;
using SgbProject.Repositories;
using SgbProject.Services;

namespace SgbProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BovinosController : Controller
    {
        private readonly IBovinosService _bovinosService;

        public BovinosController(IBovinosService bovinosService)
        {
            _bovinosService = bovinosService;
        }

        [HttpGet]
        public IEnumerable<Bovino> GetAllBovinos()
        {
            var bovinos = _bovinosService.GetAllBovinos();
            return (bovinos);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<Bovino> GetBovino([FromRoute] Guid id)
        {
            var bovino = _bovinosService.GetBovino(id);
            return (bovino);
        }

        [HttpPost]
        public async Task<IActionResult> AddBovino([FromBody] Bovino bovino)
        {
            var newbovino = _bovinosService.AddBovino(bovino);
            return Ok(newbovino);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateBovino([FromBody] Bovino bovino)
        {
            var newbovino = _bovinosService.UpdateBovino(bovino);
            return Ok(newbovino);
        }

        [HttpDelete]
        public async Task<ActionResult> DeletBovino([FromQuery] RemoveBovinoRequest command)
        {
            return Ok(_bovinosService.Delete(command));
        }

    }

}
