using System;
using System.Collections.Generic;

namespace BancoAPI.Domains;

public partial class transferencia
{
    public int transferencia_id { get; set; }

    public int? usuario_remetente_id { get; set; }

    public int? usuario_destinatario_id { get; set; }

    public DateTime? data_transferencia { get; set; }

    public int? tipo_id { get; set; }

    public int? status_id { get; set; }

    public virtual ICollection<log_transferencia> log_transferencia { get; set; } = new List<log_transferencia>();

    public virtual status_transferencia? status { get; set; }

    public virtual tipo_transferencia? tipo { get; set; }

    public virtual usuario? usuario_destinatario { get; set; }

    public virtual usuario? usuario_remetente { get; set; }
}
