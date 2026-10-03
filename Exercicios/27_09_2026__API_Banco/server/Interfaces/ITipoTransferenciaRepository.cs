using BancoAPI.Domains;

namespace BancoAPI.Interfaces
{
    public interface ITipoTransferenciaRepository
    {
        public Task<List<tipo_transferencia>> Listar();
        public Task<tipo_transferencia> ObterPorId(int transferenciaId);
        public Task<bool> ObterPorNome(string nome);
        public void Adicionar(tipo_transferencia tipoTransferencia);
        public void Atualizar(tipo_transferencia tipoTransferencia);

    }
}