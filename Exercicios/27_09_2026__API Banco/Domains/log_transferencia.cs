using System;
using System.Collections.Generic;

namespace BancoAPI.Domains;

public partial class log_transferencia
{
    public int? transferencia_id { get; set; }

    public string descricao_log { get; set; } = null!;

    public int status_id { get; set; }

    public DateTime? data_alteracao { get; set; }

    public int log_id { get; set; }

    public virtual status_transferencia status { get; set; } = null!;

    public virtual transferencia? transferencia { get; set; }
}
