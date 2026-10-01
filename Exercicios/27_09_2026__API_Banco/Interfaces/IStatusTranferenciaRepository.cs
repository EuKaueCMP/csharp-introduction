using BancoAPI.Domains;

namespace BancoAPI
{
    public interface IStatusTransferenciaRepository
    {
        public List<status_transferencia> Listar();
        public status_transferencia ObterPorId(int id);
        public void Adicionar(status_transferencia statusTransferencia);
        public void Atualizar(status_transferencia statusTransferencia);
    }
}