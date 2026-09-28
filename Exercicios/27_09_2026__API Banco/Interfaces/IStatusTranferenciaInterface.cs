using BancoAPI.Domains;

namespace BancoAPI
{
    public interface IStatusTransferenciaInterface
    {
        public List<status_transferencia> Listar();
        public status_transferencia ObterPorId(int id);
        public void Adicionar(status_transferencia statusTransferencia);
        public void Altualizar(int id, status_transferencia statusTransferencia);
    }
}