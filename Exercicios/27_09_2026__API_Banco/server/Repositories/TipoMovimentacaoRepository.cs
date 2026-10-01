using BancoAPI.Contexts;
using BancoAPI.Domains;
using BancoAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI.Repositories
{
    public class TipoMovimentacaoRepository : ITipoMovimentacaoRepository
    {
        private readonly AppDbContext _ctx;
        public TipoMovimentacaoRepository(AppDbContext ctx) => _ctx = ctx;

        public Task<List<tipo_movimentacao>> Listar() => _ctx.tipo_movimentacao.ToListAsync();
        public async Task<tipo_movimentacao> ObterPorId(int tipoId) => await _ctx.tipo_movimentacao.FindAsync(tipoId);

        public void Adicionar(tipo_movimentacao tipoMovimentacao)
        {
            _ctx.tipo_movimentacao.AddAsync(tipoMovimentacao);
            _ctx.SaveChangesAsync();
        }

        public void Atualizar(tipo_movimentacao tipoMovimentacao)
        {
            _ctx.tipo_movimentacao.Update(tipoMovimentacao);
            _ctx.SaveChangesAsync();
        }
    }
}
