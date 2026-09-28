using System;
using System.Collections.Generic;

namespace _27_09_2026__API_Banco.Domains;

public partial class usuario
{
    public int usuario_id { get; set; }

    public string nome { get; set; } = null!;

    public string email { get; set; } = null!;

    public string senha { get; set; } = null!;

    public decimal? saldo { get; set; }

    public int? tipo_usuario_id { get; set; }

    public virtual tipo_usuario? tipo_usuario { get; set; }

    public virtual ICollection<usuario_log> usuario_log { get; set; } = new List<usuario_log>();
}
