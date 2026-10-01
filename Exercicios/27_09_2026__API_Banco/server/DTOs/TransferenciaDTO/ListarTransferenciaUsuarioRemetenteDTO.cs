namespace BancoAPI
{
    public partial class ListarTransferenciaUsuarioRemetenteDTO
    {
        public int transferencia_id { get; set; }

        public int? usuario_remetente_id { get; set; }

        public int? usuario_destinatario_id { get; set; }

        public DateTime? data_transferencia { get; set; }

        public int? tipo_id { get; set; }

        public int? status_id { get; set; }
    }
}