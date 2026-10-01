using System.Security.Cryptography.X509Certificates;
using BancoAPI.Contexts;
using BancoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI
{
    public class StatusTransferenciaRepository : IStatusTransferenciaRepository
    {
        private readonly AppDbContext ctx;
        public StatusTransferenciaRepository(AppDbContext _ctx) => ctx = _ctx;

        public Task<List<status_transferencia>> Listar() => ctx.status_transferencia.ToListAsync();

        public Task<status_transferencia> ObterPorId(int id) => ctx.status_transferencia.FindAsync(id).AsTask();

        public void Adicionar(status_transferencia statusTransf)
        {
            ctx.status_transferencia.AddAsync(statusTransf);
            ctx.SaveChangesAsync();
        }

        public void Atualizar(status_transferencia statusTransf)
        {
            ctx.status_transferencia.Update(statusTransf);
            ctx.SaveChangesAsync();
        }
    }
}