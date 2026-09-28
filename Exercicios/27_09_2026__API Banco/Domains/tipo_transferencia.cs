using System;
using System.Collections.Generic;

namespace BancoAPI.Domains;

public partial class tipo_transferencia
{
    public int tipo_transferencia_id { get; set; }

    public string nome_tipo { get; set; } = null!;
}
