using APISenaiSCS.Interface;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SenaiSCSV14.Contexts;
using SenaiSCSV14.Domains;

namespace APISenaiSCS.Repositories
{
    public class CampanhaRepository : ICampanhaRepository
    {
        private CampanhaContext ctx = new CampanhaContext();

        public void Atualizar(int idCampanhas, Campanha campanhaAtualizada)
        {
            Campanha campanhaBuscada = ctx.Campanha.Find(idCampanhas);


            campanhaBuscada.Imagem = campanhaAtualizada.Imagem;


            ctx.Campanha.Update(campanhaBuscada);
            ctx.SaveChanges();
        }

        public Campanha BuscarPorId(int id)
        {
            return ctx.Campanha.FirstOrDefault(e => e.Id == id);
        }

        public Campanha Cadastrar(Campanha novaCampanha)
        {
            ctx.Campanha.Add(novaCampanha);
            ctx.SaveChangesAsync();
            return novaCampanha;
        }

        public void Deletar(int idCampanhas)
        {
            ctx.Campanha.Remove(BuscarPorId(idCampanhas));

            ctx.SaveChanges();
        }

        public List<Campanha> Listar()
        {
            return ctx.Campanha.ToList();
        
        }
    }
}