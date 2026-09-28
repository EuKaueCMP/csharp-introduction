using System;
using System.Collections.Generic;

namespace BancoAPI.Domains;

public partial class status_transferencia
{
    public int status_transferencia_id { get; set; }

    public string nome_status { get; set; } = null!;
}
