using BancoAPI.Domains;

namespace BancoAPI
{
    public interface IMovimentacaoRepository
    {
        public List<movimentacao> Listar();
        public List<movimentacao> ObterPorUsuarioId(int usuarioId);
        public List<movimentacao> ObterPorData(DateOnly data);
        public List<movimentacao> ObterPorUsuarioIdData(int usarioId, DateOnly data);
    }
}