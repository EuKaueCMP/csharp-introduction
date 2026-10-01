using System;
using System.Collections.Generic;

namespace BancoAPI.Domains;

public partial class movimentacao
{
    public int movimentacao_id { get; set; }

    public int? usuario_id { get; set; }

    public int? tipo_movimentacao_id { get; set; }

    public decimal saldo_anterior { get; set; }

    public decimal saldo_atual { get; set; }

    public DateTime? data_movimentacao { get; set; }

    public virtual tipo_movimentacao? tipo_movimentacao { get; set; }

    public virtual usuario? usuario { get; set; }
}
