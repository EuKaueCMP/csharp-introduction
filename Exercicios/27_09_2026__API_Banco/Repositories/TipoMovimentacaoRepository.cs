using BancoAPI.Contexts;
using BancoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI
{
    public class TipoMovimentacaoRepository : ITipoMovimentacaoRepository
    {
        private readonly AppDbContext ctx;
        public TipoMovimentacaoRepository(AppDbContext _ctx) => _ctx = ctx;

        public Task<List<tipo_movimentacao>> Listar() => ctx.tipo_movimentacao.ToListAsync();
        public async Task<tipo_movimentacao> ObterPorId(int tipoId) => await ctx.tipo_movimentacao.FindAsync(tipoId);

        public void Adicionar(tipo_movimentacao tipoMovimentacao)
        {
            ctx.tipo_movimentacao.AddAsync(tipoMovimentacao);
            ctx.SaveChangesAsync();
        }

        public void Atualizar(tipo_movimentacao tipoMovimentacao)
        {
            ctx.tipo_movimentacao.Update(tipoMovimentacao);
            ctx.SaveChangesAsync();
        }
    }
}
