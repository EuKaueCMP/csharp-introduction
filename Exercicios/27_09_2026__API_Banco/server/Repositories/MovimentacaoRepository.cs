using BancoAPI.Contexts;
using BancoAPI.Domains;
using BancoAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI.Repositories
{
    public class MovimentacaoRepository : IMovimentacaoRepository
    {
        private readonly AppDbContext _ctx;
        public MovimentacaoRepository(AppDbContext ctx) => _ctx = ctx;

        public Task<List<movimentacao>> Listar() => _ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).ToListAsync();

        public Task<List<movimentacao>> ObterPorUsuarioId(int usuarioId) => _ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).Where(m => m.usuario_id == usuarioId).ToListAsync();

        public Task<List<movimentacao>> ObterPorData(DateOnly data) => _ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).Where(l => DateTimeToOnly.ToOnly(l.data_movimentacao ?? DateTime.Now) == data).ToListAsync();
        public Task<List<movimentacao>> ObterPorUsuarioIdData(int usuarioId, DateOnly data) => _ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).Where(m => m.usuario_id == usuarioId && DateTimeToOnly.ToOnly(m.data_movimentacao ?? DateTime.Now) == data).ToListAsync();
        public async Task<movimentacao> ObterPorId(int id) => await _ctx.movimentacao.FindAsync();
    }   
}