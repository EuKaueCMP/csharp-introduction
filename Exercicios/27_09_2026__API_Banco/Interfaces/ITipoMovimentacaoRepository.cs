using BancoAPI.Domains;

namespace BancoAPI
{
    public interface ITipoMovimentacaoRepository
    {
        public List<tipo_movimentacao> Listar();
        public tipo_movimentacao ObterPorId(int tipoMovimentacaoId);
        public void Adicionar(tipo_movimentacao tipo_Movimentacao);
        public void Atualizar(tipo_movimentacao tipoMovimentacao);
    }
}