using BancoAPI.Contexts;
using BancoAPI.Domains;

namespace BancoAPI
{
    public class MovimentacaoRepository : IMovimentacaoRepository
    {
        private readonly AppDbContext ctx;
        public MovimentacaoRepository(AppDbContext _ctx) => ctx = _ctx;

        public List<movimentacao> Listar() => ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).ToList();

        public List<movimentacao> ObterPorUsuarioId(int usuarioId) => ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).Where(m => m.usuario_id == usuarioId).ToList();

        public List<movimentacao> ObterPorData(DateOnly data) => ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).Where(m =>  DateTimeToOnly.ToOnly(m.data_movimentacao ?? DateTime.Now) == data).ToList();
        public List<movimentacao> ObterPorUsuarioIdData(int usuarioId, DateOnly data) => ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).Where(m => DateTimeToOnly.ToOnly(m.data_movimentacao ?? DateTime.Now)  == data && m.usuario.usuario_id == usuarioId).ToList();
    }
}