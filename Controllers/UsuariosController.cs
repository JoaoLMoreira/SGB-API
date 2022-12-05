using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SgbProject.Data;
using SgbProject.Models;
using SgbProject.Services;

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
        public IEnumerable<Usuario> GetAllUsuarios()
        {
            var usuario = _usuariosService.GetAllUsuarios();
            return (usuario);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<Usuario> GetUsuario([FromRoute] Guid id)
        {
            var usuario =  _usuariosService.GetById(id);
            return (usuario);
        }

        [HttpPost]
        public async Task<IActionResult> AddUsuario([FromBody] Usuario Usuario)
        {
            var newusuario =  _usuariosService.Add(Usuario);
            return Ok(newusuario);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUsuario([FromBody] Usuario Usuario)
        {
            var newusuario =  _usuariosService.Update(Usuario);
            return Ok(newusuario);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<ActionResult> DeletUsuario([FromRoute] Guid id)
        {
            var newusuario =  _usuariosService.Delete(id);
            return Ok(newusuario);
        }


    }
}
