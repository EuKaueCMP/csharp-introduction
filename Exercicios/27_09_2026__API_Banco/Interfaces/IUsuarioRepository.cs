using BancoAPI.Domains;

namespace BancoAPI
{
    public interface IUsuarioRepository
    {
        public List<usuario> Listar();
        public List<usuario> ObterPorTipoId(int tipoId);
        public usuario ObterPorId(int id);
        public void Adicionar(usuario usuario);
        public void Atualizar(usuario usuario);
        public void AtualizarSenha(int id, string senha);
        public void Remover(int id);
    }
}