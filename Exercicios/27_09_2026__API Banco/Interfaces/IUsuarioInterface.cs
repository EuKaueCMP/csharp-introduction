using BancoAPI.Domains;

namespace BancoAPI
{
    public interface IUsuarioInterface
    {
        public List<usuario> Listar();
        public List<usuario> ObterPorTipoId(int tipoId);
        public usuario ObterPorId(int id);
        public void Adicionar(usuario usuario);
        public void Atualizar(int id, usuario usuario);
        public void AtualizarSenha(int id, string senha);
        public void Remover(int id);
    }
}