using System.Security.Cryptography.X509Certificates;
using BancoAPI.Contexts;
using BancoAPI.Domains;

namespace BancoAPI
{
    public class StatusTransferenciaRepository : IStatusTransferenciaRepository
    {
        private readonly AppDbContext ctx;
        public StatusTransferenciaRepository(AppDbContext _ctx) => ctx = _ctx;

        public List<status_transferencia> Listar() => ctx.status_transferencia.ToList();

        public status_transferencia ObterPorId(int id) => ctx.status_transferencia.Find(id);

        public void Adicionar(status_transferencia statusTransf)
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