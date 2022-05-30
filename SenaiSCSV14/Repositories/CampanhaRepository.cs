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
            throw new System.NotImplementedException();
        }

        public Campanha Cadastrar(Campanha novaCampanha)
        {
            throw new System.NotImplementedException();
        }

        public void Deletar(int idCampanhas)
        {
            throw new System.NotImplementedException();
        }

        public List<Campanha> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}