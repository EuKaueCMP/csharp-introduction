using BancoAPI.Domains;

namespace BancoAPI
{
    public interface ITipoTranferencia
    {
        public List<tipo_transferencia> Listar();
        public tipo_transferencia ObterPorId(int transferenciaId);
        public void Adicionar(tipo_transferencia tipoTransferencia);
        public void Atualizar(tipo_transferencia tipoTransferencia);

    }
}