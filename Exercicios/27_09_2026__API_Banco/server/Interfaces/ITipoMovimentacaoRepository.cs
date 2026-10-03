using BancoAPI.Domains;

namespace BancoAPI.Interfaces
{
    public interface ITipoMovimentacaoRepository
    {
        public Task<List<tipo_movimentacao>> Listar();
        public Task<tipo_movimentacao> ObterPorId(int tipoMovimentacaoId);
        public Task<bool> ObterPorNome(string nome);
        public void Adicionar(tipo_movimentacao tipo_Movimentacao);
        public void Atualizar(tipo_movimentacao tipoMovimentacao);
    }
}