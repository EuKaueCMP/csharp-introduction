using System.Security.Cryptography.X509Certificates;
using BancoAPI.Contexts;
using BancoAPI.Domains;
using BancoAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI.Repositories
{
    public class StatusTransferenciaRepository : IStatusTransferenciaRepository
    {
        private readonly AppDbContext _ctx;
        public StatusTransferenciaRepository(AppDbContext ctx) => _ctx = ctx;

        public Task<List<status_transferencia>> Listar() => _ctx.status_transferencia.ToListAsync();

        public Task<status_transferencia> ObterPorId(int id) => _ctx.status_transferencia.FindAsync(id).AsTask();

        public void Adicionar(status_transferencia statusTransf)
        {
            _ctx.status_transferencia.AddAsync(statusTransf);
            _ctx.SaveChangesAsync();
        }

        public void Atualizar(status_transferencia statusTransf)
        {
            _ctx.status_transferencia.Update(statusTransf);
            _ctx.SaveChangesAsync();
        }
    }
}