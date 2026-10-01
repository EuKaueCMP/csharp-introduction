using BancoAPI.Domains;

namespace BancoAPI
{
    public interface ITransferenciaRepository
    {
        public List<transferencia> Listar();
        public List<transferencia> ObterPorUsuarioRemetenteId(int usuarioId);
        public List<transferencia> ObterPorUsuarioDestinatarioId(int usuarioId);
        public List<transferencia> ObterPorUsuarioIdData(int usuarioid, DateOnly data);
        public List<transferencia> ObterPorUsuariOIdTipoId(int usuarioId, int tipoId);
        public List<transferencia> ObterPorUsuarioIdStatusId(int usuarioId, int statusId);
    }
}