file:///home/kaue/Documents/studies/learning-csharp/Exercicios/27_09_2026__API_Banco/server/Repositories/TransferenciaRepository.cs {"mtime":1790807600549,"ctime":1790792161355,"size":1638,"etag":"3gnisgbao1lq","orphaned":false,"typeId":""}
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
        public Task<List<transferencia>> ObterPorUsuarioIdTipoId(int usuarioId, int statusId) => ctx.transferencia.OrderByDescending(t => t.data_transferencia).Where(t => t.usuario_remetente_id == usuarioId && t.status_id == statusId).ToListAsync(); 
        public async Task<transferencia> ObterPorId(int id) => await ctx.transferencia.FindAsync(id);
        public void Transferir(int tipoTransferenciaId, int usuarioRemetenteId, int usuarioDestinatarioId, double saldo, DateOnly dataTransferencia)
        {
            transferencia transf = new transferencia
            {
                data_transferencia = Convert.ToDateTime
                (dataTransferencia),
            }
        }
    }
}