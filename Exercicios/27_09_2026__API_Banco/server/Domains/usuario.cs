using System;
using System.Collections.Generic;

namespace BancoAPI.Domains;

public partial class usuario
{
    public int usuario_id { get; set; }

    public string nome { get; set; } = null!;

    public string email { get; set; } = null!;

    public string senha { get; set; } = null!;

    public decimal? saldo { get; set; }

    public int? tipo_usuario_id { get; set; }

    public virtual ICollection<movimentacao> movimentacao { get; set; } = new List<movimentacao>();

    public virtual tipo_usuario? tipo_usuario { get; set; }

    public virtual ICollection<transferencia> transferenciausuario_destinatario { get; set; } = new List<transferencia>();

    public virtual ICollection<transferencia> transferenciausuario_remetente { get; set; } = new List<transferencia>();

    public virtual ICollection<usuario_log> usuario_log { get; set; } = new List<usuario_log>();
}
