using System;
using System.Collections.Generic;

namespace _27_09_2026__API_Banco.Domains;

public partial class tipo_usuario
{
    public int tipo_usuario_id { get; set; }

    public string tipo { get; set; } = null!;

    public virtual ICollection<usuario> usuario { get; set; } = new List<usuario>();
}
