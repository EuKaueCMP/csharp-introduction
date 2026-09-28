using BancoAPI.Domains;

namespace BancoAPI
{
    public interface ILogTransferenciaRepository
    {
        public List<log_transferencia> Listar();
        public log_transferencia ObterPorId(int id);
        public List<log_transferencia> ObterPorUsuarioId(int usuarioId);
        public List<log_transferencia> ObterPorStatusId(int statusId);
        public List<log_transferencia> ObterPorUsuarioIdStatusId(int usuarioId, int statusId);
    }
}