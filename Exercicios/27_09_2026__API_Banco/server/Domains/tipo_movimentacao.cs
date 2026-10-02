using System;
using System.Collections.Generic;

namespace BancoAPI.Domains;

public partial class tipo_movimentacao
{
    public int tipo_movimentacao_id { get; set; }

    public string? tipo { get; set; }

    public virtual ICollection<movimentacao> movimentacao { get; set; } = new List<movimentacao>();
}
