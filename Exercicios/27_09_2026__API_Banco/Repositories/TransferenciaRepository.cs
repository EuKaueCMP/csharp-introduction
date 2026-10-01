using BancoAPI.Contexts;
using BancoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI
{
    public class TransferenciaRepository : ITransferenciaRepository 
    {
        private readonly AppDbContext ctx;
        public TransferenciaRepository(AppDbContext _ctx) => ctx = _ctx;

        public Task<List<transferencia>> Listar() => ctx.transferencia.ToListAsync();
        public Task<List<transferencia>> ObterPorUsuarioRemetenteId(int usuarioId) => ctx.transferencia.OrderByDescending(t => t.data_transferencia).ToListAsync();
        public Task<List<transferencia>> ObterPorUsuarioDestinatarioId(int usuarioId) => ctx.transferencia.OrderByDescending(t => t.data_transferencia).ToListAsync();
        public Task<List<transferencia>> ObterPorUsuarioIdData(int usuarioId, DateOnly data) => ctx.transferencia.OrderByDescending(t => t.data_transferencia).Where(t => DateTimeToOnly.ToOnly(t.data_transferencia ?? DateTime.Now) == data).ToListAsync();
        public Task<List<transferencia>> ObterPorUsuarioIdTipoId(int usuarioId, int tipoId) => ctx.transferencia.OrderByDescending(t => t.data_transferencia).Where(t => t.usuario_remetente_id == usuarioId && t.tipo_id == tipoId).ToListAsync(); 
        public Task<List<transferencia>> ObterPorUsuarioIdStatusId(int usuarioId, int statusId) => ctx.transferencia.OrderByDescending(t => t.data_transferencia).Where(t => t.usuario_remetente_id == usuarioId && t.status_id == statusId).ToListAsync(); 
        public async Task<transferencia> ObterPorId(int id) => await ctx.transferencia.FindAsync(id);
        public void Transferir(int tipoTransferenciaId, int usuarioRemetenteId, int usuarioDestinatarioId, double saldo, DateOnly dataTransferencia, int statusId)
        {
            transferencia transf = new transferencia
            {
                data_transferencia = Convert.ToDateTime(dataTransferencia),
                usuario_remetente_id = usuarioRemetenteId,
                usuario_destinatario_id = usuarioDestinatarioId,
                tipo_id = tipoTransferenciaId,
                status_id = statusId
            };
        }
    }
}