using BancoAPI.Domains;

namespace BancoAPI
{
    public interface IUsuarioLogRepository
    {
        public List<usuario_log> Listar();
        public usuario_log ObterPorId(int id);
        public List<usuario_log> ObterPorUsuarioId(int usuarioId);
    }
}