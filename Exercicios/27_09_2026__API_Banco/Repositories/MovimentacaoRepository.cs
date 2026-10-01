using BancoAPI.Contexts;
using BancoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI
{
    public class MovimentacaoRepository : IMovimentacaoRepository
    {
        private readonly AppDbContext ctx;
        public MovimentacaoRepository(AppDbContext _ctx) => ctx = _ctx;

        public Task<List<movimentacao>> Listar() => ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).ToListAsync();

        public Task<List<movimentacao>> ObterPorUsuarioId(int usuarioId) => ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).Where(m => m.usuario_id == usuarioId).ToListAsync();

        public Task<List<movimentacao>> ObterPorData(DateOnly data) => ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).Where(l => DateTimeToOnly.ToOnly(l.data_movimentacao ?? DateTime.Now) == data).ToListAsync();
        public Task<List<movimentacao>> ObterPorUsuarioIdData(int usuarioId, DateOnly data) => ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).Where(m => m.usuario_id == usuarioId && DateTimeToOnly.ToOnly(m.data_movimentacao ?? DateTime.Now) == data).ToListAsync();
    }
}