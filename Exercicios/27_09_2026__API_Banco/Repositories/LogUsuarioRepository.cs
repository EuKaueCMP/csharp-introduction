using BancoAPI.Contexts;
using BancoAPI.Domains;

namespace BancoAPI
{
    public class LogUsuarioRepository : IUsuarioLogRepository
    {
        private readonly AppDbContext ctx;
        public UsuarioLogRepository(AppDbContext _ctx) => ctx = _ctx;

        public List<usuario_log> Listar() => ctx.usuario_log.ToList();

        public usuario_log ObterPorId(int id) => ctx.usuario_log.Find(id);

        public List<usuario_log> ObterPorUsuarioId(int usuarioId) => ctx.usuario_log.Where(l => l.usuario_id == usuarioId)
                                                                              .OrderByDescending(l => l.data_alteracao)
                                                                              .ToList();    
    }
}