using BancoAPI.Domains;

namespace BancoAPI
{
    public interface ITipoAlteracaoInterface
    {
        public List<tipo_alteracao> Listar();
        public tipo_alteracao ObterPorId(int id);
        public void Adicionar(tipo_alteracao tipoAlteracao);
        public void Altualizar(int id, tipo_alteracao tipoAlteracao);
    }
}