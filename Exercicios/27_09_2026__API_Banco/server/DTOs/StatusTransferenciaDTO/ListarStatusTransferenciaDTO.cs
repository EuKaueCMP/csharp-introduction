namespace BancoAPI.DTOs
{
    public partial class ListarStatusTransferenciaDTO
    {
        public int status_transferencia_id { get; set; }

        public string nome_status { get; set; } = null!;
    }
}