using BancoAPI.Domains;

namespace BancoAPI
{
    public interface ITipoAlteracaoRepository
    {
        public Task<List<tipo_alteracao>> Listar();
        public Task<tipo_alteracao> ObterPorId(int id);
        public void Adicionar(tipo_alteracao tipoAlteracao);
        public void Atualizar(tipo_alteracao tipoAlteracao);
    }
}