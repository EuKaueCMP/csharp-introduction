using BancoAPI.Contexts;
using BancoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI
{
    public class UsuarioLogRepository : IUsuarioLogRepository
    {
        private readonly AppDbContext ctx;
        public UsuarioLogRepository(AppDbContext _ctx) => ctx = _ctx;

        public Task<List<usuario_log>> Listar() => ctx.usuario_log.OrderByDescending(ul => ul.data_alteracao).ToListAsync();

        public Task<List<usuario_log>> ObterPorUsuarioId(int usuarioId) => ctx.usuario_log.Where(l => l.usuario_id == usuarioId)
                                                                              .OrderByDescending(l => l.data_alteracao)
                                                                              .ToListAsync();    
        public async Task<usuario_log> ObterPorId(int id) => await ctx.usuario_log.FindAsync(id);
    }
}