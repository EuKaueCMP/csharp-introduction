file:///home/kaue/Documents/studies/learning-csharp/Exercicios/27_09_2026__API_Banco/server/Repositories/StatusTransferenciaRepostory.cs {"mtime":1790729935227,"ctime":1790729935227,"size":872,"etag":"3gnf5lrh8s4","orphaned":false,"typeId":""}
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

        public void AdicionarAsync(status_transferencia statusTransf)
        {
            ctx.status_transferencia.Add(statusTransf);
            ctx.SaveChanges();
        }

        public void Atualizar(status_transferencia statusTransf)
        {
            ctx.status_transferencia.Update(statusTransf);
            ctx.SaveChanges();
        }
    }
}