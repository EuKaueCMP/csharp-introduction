using System;
using System.Collections.Generic;

namespace _27_09_2026__API_Banco.Domains;

public partial class tipo_alteracao
{
    public int tipo_alteracao_id { get; set; }

    public string? nome_alteracao { get; set; }

    public virtual ICollection<usuario_log> usuario_log { get; set; } = new List<usuario_log>();
}
