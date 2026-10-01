namespace BancoAPI.DTOs
{
    public partial class ListarLogTransferenciaDTO
    {
        public int? transferencia_id { get; set; }

        public string descricao_log { get; set; } = null!;

        public int status_id { get; set; }

        public DateTime? data_alteracao { get; set; }

        public int log_id { get; set; }
    }
}