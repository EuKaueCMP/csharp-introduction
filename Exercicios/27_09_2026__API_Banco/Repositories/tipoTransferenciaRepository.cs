using BancoAPI.Contexts;
using BancoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI
{
    public class tipoTransferenciaRepository
    {
        private readonly AppDbContext ctx; 
        public tipoTransferenciaRepository(AppDbContext _ctx) => ctx = _ctx;

        public Task<List<tipo_transferencia>> Listar() => ctx.tipo_transferencia.ToListAsync();
        public async Task<tipo_transferencia> ObterPorid(int transferenciaId) => await ctx.tipo_transferencia.FindAsync(transferenciaId);
        
        public void Adicionar(tipo_transferencia tipoTransferencia)
        {
            ctx.tipo_transferencia.AddAsync(tipoTransferencia);
            ctx.SaveChangesAsync();
        }

        public void Atualizar(tipo_transferencia tipoTransferencia)
        {
            ctx.tipo_transferencia.Update(tipoTransferencia);
            ctx.SaveChangesAsync();
        }
    }
}