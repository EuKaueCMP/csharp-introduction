using BancoAPI.Contexts;
using BancoAPI.Domains;

namespace BancoAPI
{
    public class LogTransferenciaRepository : ILogTransferenciaRepository
    {
        private readonly AppDbContext ctx;
        public LogTransferenciaRepository(AppDbContext _ctx) => ctx = _ctx;

        public List<log_transferencia> Listar() => ctx.log_transferencia.OrderByDescending(l => l.data_alteracao).ToList();

        public List<log_transferencia> ObterPorUsuarioId(int usuarioId ) => ctx.log_transferencia.OrderByDescending(l => l.data_alteracao).Where(l => l.transferencia.transferencia_id == usuarioId).ToList();

        public List<log_transferencia> ObterPorStatusId(int statusId) => ctx.log_transferencia.OrderByDescending(l => l.data_alteracao).Where(l => l.status_id == statusId).ToList();

        public List<log_transferencia> ObterPorUsuarioIdStatusId(int usuarioId, int statusId) => ctx.log_transferencia.OrderByDescending(l => l.data_alteracao).Where(l => l.transferencia.usuario_remetente_id == usuarioId && l.status_id == statusId).ToList();
        
        public log_transferencia ObterPorId(int logId) => ctx.log_transferencia.Find(logId);
    }
}