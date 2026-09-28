using System.Reflection.Metadata.Ecma335;
using BancoAPI.Contexts;
using BancoAPI.Domains;

namespace BancoAPI
{
    public class TipoAlteracaoRepository : ITipoAlteracaoRepository
    {
        private readonly AppDbContext ctx;
        public TipoAlteracaoRepository(AppDbContext _ctx) => ctx = _ctx;

        public List<tipo_alteracao> Listar() => ctx.tipo_alteracao.ToList();

        public tipo_alteracao ObterPorId(int id) => ctx.tipo_alteracao.Find(id);

        public void Adicionar(tipo_alteracao tipoAlteracao)
        {
            ctx.tipo_alteracao.Add(tipoAlteracao);
            ctx.SaveChanges();
        }
        
        public void Atualizar(tipo_alteracao tipoAlteracao)
        {   
            ctx.tipo_alteracao.Update(tipoAlteracao);
            ctx.SaveChanges();
        }
    }
}