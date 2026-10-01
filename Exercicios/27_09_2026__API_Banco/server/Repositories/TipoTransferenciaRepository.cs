using BancoAPI.Contexts;
using BancoAPI.Domains;
using BancoAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI.Repositories
{
    public class TipoTransferenciaRepository : ITipoTranferenciaRepository
    {
        private readonly AppDbContext _ctx; 
        public TipoTransferenciaRepository(AppDbContext ctx) => _ctx = ctx;

        public Task<List<tipo_transferencia>> Listar() => _ctx.tipo_transferencia.ToListAsync();
        public async Task<tipo_transferencia> ObterPorId(int transferenciaId) => await _ctx.tipo_transferencia.FindAsync(transferenciaId);
        
        public void Adicionar(tipo_transferencia tipoTransferencia)
        {
            _ctx.tipo_transferencia.AddAsync(tipoTransferencia);
            _ctx.SaveChangesAsync();
        }

        public void Atualizar(tipo_transferencia tipoTransferencia)
        {
            _ctx.tipo_transferencia.Update(tipoTransferencia);
            _ctx.SaveChangesAsync();
        }
    }
}