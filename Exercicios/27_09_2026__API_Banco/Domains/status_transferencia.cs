using System;
using System.Collections.Generic;

namespace BancoAPI.Domains;

public partial class status_transferencia
{
    public int status_transferencia_id { get; set; }

    public string nome_status { get; set; } = null!;

    public virtual ICollection<log_transferencia> log_transferencia { get; set; } = new List<log_transferencia>();

    public virtual ICollection<transferencia> transferencia { get; set; } = new List<transferencia>();
}
