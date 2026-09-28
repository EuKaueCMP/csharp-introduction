using System;
using System.Collections.Generic;

namespace BancoAPI.Domains;

public partial class usuario_log
{
    public int log_id { get; set; }

    public int usuario_id { get; set; }

    public int tipo_alteracao_id { get; set; }

    public string nome { get; set; } = null!;

    public string email { get; set; } = null!;

    public decimal saldo { get; set; }

    public virtual tipo_alteracao tipo_alteracao { get; set; } = null!;

    public virtual usuario usuario { get; set; } = null!;
}
