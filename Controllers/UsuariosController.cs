using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SgbProject.Data;
using SgbProject.Models;
using SgbProject.Service;

namespace SgbProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : Controller
    {
        private readonly IUsuariosService _usuariosService;

        public UsuariosController(IUsuariosService usuariosService)
        {
            this._usuariosService = usuariosService;
        }

        [HttpGet]
        public Task<List<Usuario>> GetAllUsuarios()
        {
            var usuario = _usuariosService.GetAll();
            return (usuario);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<Usuario> GetUsuario([FromRoute] Guid id)
        {
            var usuario = await _usuariosService.GetById(id);
            return (usuario);
        }

        [HttpPost]
        public async Task<IActionResult> AddUsuario([FromBody] Usuario Usuario)
        {
            var newusuario = await _usuariosService.Add(Usuario);
            return Ok(newusuario);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateUsuario([FromRoute] Guid id, [FromBody] Usuario Usuario)
        {
            var newusuario = await _usuariosService.Update(Usuario, id);
            return Ok(newusuario);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<ActionResult> DeletUsuario([FromRoute] Guid id)
        {
            var newusuario = await _usuariosService.Delete(id);
            return Ok(newusuario);
        }


    }
}
