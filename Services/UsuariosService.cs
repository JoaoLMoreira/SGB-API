using Microsoft.EntityFrameworkCore;
using SgbProject.Data;
using SgbProject.Models;

namespace SgbProject.Services
{
    public class UsuariosService: IUsuariosService
    {
        private readonly Context Contexto;

        public UsuariosService(Context contexto)
        {
            this.Contexto = contexto;
        }

        public async Task<List<Usuario>> GetAll()
        {
            var usuario = await Contexto.Usuarios.ToListAsync();
            return (usuario);
        }

        public async Task<Usuario> GetById(Guid id)
        {
            var usuario = await Contexto.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            return (usuario);
        }


        public async Task<Usuario> Add(Usuario usuario)
        {
            usuario.Id = Guid.NewGuid();
            await Contexto.Usuarios.AddAsync(usuario);
            await Contexto.SaveChangesAsync();

            return (usuario);


        }


        public async Task<Usuario> Update(Usuario usuario, Guid id)
        {
            var usuarioExistente = await Contexto.Usuarios.FirstOrDefaultAsync(x => x.Id == id);

            usuarioExistente.NomeUsuario = usuario.NomeUsuario;
            usuarioExistente.Senha = usuario.Senha;
            usuarioExistente.Nome = usuario.Nome;
            usuarioExistente.Email = usuario.Email;

            await Contexto.SaveChangesAsync();
            return (usuarioExistente);

        }


        public async Task<Usuario> Delete(Guid id)
        {
            var UsuarioExistente = await Contexto.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            if (UsuarioExistente != null)
            {
                Contexto.Remove(UsuarioExistente);
                await Contexto.SaveChangesAsync();
                return (UsuarioExistente);
            }
            else
            {
                return (null);
            }




        }
    }
}
