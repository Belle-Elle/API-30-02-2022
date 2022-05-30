using APISenaiSCS.Interface;
using SenaiSCSV14.Contexts;
using SenaiSCSV14.Domains;
using System.Collections.Generic;
using System.Linq;

namespace APISenaiSCS.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        CampanhaContext ctx = new CampanhaContext();
        public void Atualizar(int idUsuario, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(idUsuario);


            usuarioBuscado.Senha = usuarioAtualizado.Senha;

            ctx.Usuario.Update(usuarioBuscado);
            ctx.SaveChanges();

        }

        public Usuario BuscarPorId(int idUsuario)
        {
            return ctx.Usuario
             .Select(u => new Usuario()
             {
                 id = u.id,
                 Nif = u.Nif,
             })
             .FirstOrDefault(u => u.id == idUsuario);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuario.Add(novoUsuario);

            ctx.SaveChanges();
        }
    

        public void Deletar(int idUsuario)
        {
            ctx.Usuario.Remove(BuscarPorId(idUsuario));

            ctx.SaveChanges();
        }
    

        public List<Usuario> Listar()
        {
             return ctx.Usuario.ToList();
        }

        public Usuario Login(string NIF, string senha)
        {
          return ctx.Usuario.FirstOrDefault(e => e.Nif == NIF && e.Senha == senha); 
        }
    }
}
