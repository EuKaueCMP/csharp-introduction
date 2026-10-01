using System.Reflection.Metadata.Ecma335;
using BancoAPI.Contexts;
using BancoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI
{
    public class TipoAlteracaoRepository : ITipoAlteracaoRepository
    {
        private readonly AppDbContext ctx;
        public TipoAlteracaoRepository(AppDbContext _ctx) => ctx = _ctx;

        public Task<List<tipo_alteracao>> Listar() => ctx.tipo_alteracao.ToListAsync();

        public Task<tipo_alteracao> ObterPorId(int id) => ctx.tipo_alteracao.FindAsync(id).AsTask();

        public void Adicionar(tipo_alteracao tipoAlteracao)
        {
            ctx.tipo_alteracao.AddAsync(tipoAlteracao);
            ctx.SaveChangesAsync();
        }
        
        public void Atualizar(tipo_alteracao tipoAlteracao)
        {   
            ctx.tipo_alteracao.Update(tipoAlteracao);
            ctx.SaveChanges();
        }
    }
}