using BancoAPI.Contexts;
using BancoAPI.Domains;
using BancoAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI.Repositories
{
    public class LogTransferenciaRepository : ILogTransferenciaRepository
    {
        private readonly AppDbContext _ctx;
        public LogTransferenciaRepository(AppDbContext ctx) =>_ctx = _ctx;

        public Task<List<log_transferencia>> Listar() =>_ctx.log_transferencia.OrderByDescending(l => l.data_alteracao).Include(u => u).ToListAsync();

        public Task<List<log_transferencia>> ObterPorUsuarioId(int usuarioId) =>_ctx.log_transferencia.OrderByDescending(l => l.data_alteracao).Include(u => u).Where(l => l.transferencia.transferencia_id == usuarioId).ToListAsync();

        public Task<List<log_transferencia>> ObterPorStatusId(int statusId) =>_ctx.log_transferencia.OrderByDescending(l => l.data_alteracao).Include(u => u).Where(l => l.status_id == statusId).ToListAsync();

        public Task<List<log_transferencia>> ObterPorUsuarioIdStatusId(int usuarioId, int statusId) =>_ctx.log_transferencia.OrderByDescending(l => l.data_alteracao).Include(u => u).Where(l => l.transferencia.usuario_remetente_id == usuarioId && l.status_id == statusId).ToListAsync();

        public async Task<log_transferencia> ObterPorId(int logId) => await _ctx.log_transferencia.FindAsync(logId);
    }
}