using System.Reflection.Metadata.Ecma335;
using BancoAPI.Contexts;
using BancoAPI.Domains;
using BancoAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI.Repositories
{
    public class TipoAlteracaoRepository : ITipoAlteracaoRepository
    {
        private readonly AppDbContext _ctx;
        public TipoAlteracaoRepository(AppDbContext ctx) => _ctx = ctx;

        public Task<List<tipo_alteracao>> Listar() => _ctx.tipo_alteracao.ToListAsync();

        public Task<tipo_alteracao> ObterPorId(int id) => _ctx.tipo_alteracao.FindAsync(id).AsTask();

        public void Adicionar(tipo_alteracao tipoAlteracao)
        {
            _ctx.tipo_alteracao.AddAsync(tipoAlteracao);
            _ctx.SaveChangesAsync();
        }
        
        public void Atualizar(tipo_alteracao tipoAlteracao)
        {   
            _ctx.tipo_alteracao.Update(tipoAlteracao);
            _ctx.SaveChanges();
        }
    }
}