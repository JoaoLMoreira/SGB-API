using Microsoft.EntityFrameworkCore;
using SgbProject.Data;
using SgbProject.Models;
using SgbProject.Repositories;

namespace SgbProject.Services
{
    public class UsuariosService : IUsuariosService
    {
        private readonly IRepository<Usuario> _usuarioRepository;

        public UsuariosService(IRepository<Usuario> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }


        public IEnumerable<Usuario> GetAllUsuarios()
        {
            return _usuarioRepository.GetAll();
        }

        public Usuario GetById(Guid id)
        {
            return _usuarioRepository.GetById(id);
        }


        public Usuario Add(Usuario usuario)
        {
            usuario.Id = Guid.NewGuid();
            var usuarioadicionado = _usuarioRepository.Add(usuario);
            _usuarioRepository.SaveChanges();
            return (usuarioadicionado);
        }


        public Usuario Update(Usuario usuario)
        {
            var novousuario = _usuarioRepository.Update(usuario);
            _usuarioRepository.SaveChanges();
            return (novousuario);
        }

        public Usuario Delete(Guid id)
        {
            var usuario = _usuarioRepository.GetById(id);
            _usuarioRepository.Remove(usuario);
            _usuarioRepository.SaveChanges();
            return (usuario);

        }
    }
}
