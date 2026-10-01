using BancoAPI.Domains;

namespace BancoAPI
{
    public interface ITransferenciaRepository
    {
        public Task<List<transferencia>> Listar();
        public Task<List<transferencia>> ObterPorUsuarioRemetenteId(int usuarioId);
        public Task<List<transferencia>> ObterPorUsuarioDestinatarioId(int usuarioId);
        public Task<List<transferencia>> ObterPorUsuarioIdData(int usuarioid, DateOnly data);
        public Task<List<transferencia>> ObterPorUsuarioIdTipoId(int usuarioId, int tipoId);
        public Task<List<transferencia>> ObterPorUsuarioIdStatusId(int usuarioId, int statusId);
        public Task<transferencia> ObterPorId(int id);
        public void Transferir(int tipoTransferenciaId, int usuarioRemetenteId, int usuarioDestinatarioId, double saldo, DateOnly dataTransferencia, int statusId);
    }
}