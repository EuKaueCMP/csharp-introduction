using System;
using System.Collections.Generic;

namespace BancoAPI.Domains;

public partial class tipo_usuario
{
    public int tipo_usuario_id { get; set; }

    public string tipo { get; set; } = null!;

    public virtual ICollection<usuario> usuario { get; set; } = new List<usuario>();
}
