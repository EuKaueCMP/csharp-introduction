using BancoAPI.Contexts;
using BancoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly AppDbContext ctx;
        public TipoUsuarioRepository(AppDbContext _ctx)
        {
            ctx = _ctx;
        }

        public Task<List<tipo_usuario>> Listar() => ctx.tipo_usuario.ToListAsync();

        public async Task<tipo_usuario> ObterPorId(int id) => await ctx.tipo_usuario.FindAsync(id);

        public void Adicionar(tipo_usuario tipoUsu)
        {
            ctx.tipo_usuario.AddAsync(tipoUsu);
            ctx.SaveChangesAsync();
        }

        public void Atualizar(tipo_usuario tipoUsu)
        {
            ctx.tipo_usuario.Update(tipoUsu);
            ctx.SaveChangesAsync();
        }
    }
}