using BancoAPI.Contexts;
using BancoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI
{
    public class LogTransferenciaRepository : ILogTransferenciaRepository
    {
        private readonly AppDbContext ctx;
        public LogTransferenciaRepository(AppDbContext _ctx) => ctx = _ctx;

        public Task<List<log_transferencia>> Listar() => ctx.log_transferencia.OrderByDescending(l => l.data_alteracao).ToListAsync();

        public Task<List<log_transferencia>> ObterPorUsuarioId(int usuarioId) => ctx.log_transferencia.OrderByDescending(l => l.data_alteracao).Where(l => l.transferencia.transferencia_id == usuarioId).ToListAsync();

        public Task<List<log_transferencia>> ObterPorStatusId(int statusId) => ctx.log_transferencia.OrderByDescending(l => l.data_alteracao).Where(l => l.status_id == statusId).ToListAsync();

        public Task<List<log_transferencia>> ObterPorUsuarioIdStatusId(int usuarioId, int statusId) => ctx.log_transferencia.OrderByDescending(l => l.data_alteracao).Where(l => l.transferencia.usuario_remetente_id == usuarioId && l.status_id == statusId).ToListAsync();

        public async Task<log_transferencia> ObterPorId(int logId) => await ctx.log_transferencia.FindAsync(logId);
    }
}