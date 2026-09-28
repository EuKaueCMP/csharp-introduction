using BancoAPI.Domains;

namespace BancoAPI
{
    public interface IUsuarioLogInterface
    {
        public List<usuario_log> Listar();
        public List<usuario_log> ObterPodId(int id);
        public List<usuario_log> ObterPorIdUsuario(int usuarioId);
    }
}