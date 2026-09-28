using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LoginCinemantica.Models;

[Table("Usuario")]
[Index("Email", Name = "UQ__Usuario__AB6E616473DF6B5A", IsUnique = true)]
public partial class Usuario
{
    [Key]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("nome")]
    [StringLength(40)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [Column("email")]
    [StringLength(30)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("senha")]
    public byte[] Senha { get; set; } = null!;

    [Column("nick_name")]
    [StringLength(12)]
    [Unicode(false)]
    public string NickName { get; set; } = null!;

    [Column("data_nascimento")]
    public DateOnly DataNascimento { get; set; }

    [Column("desc_perfil")]
    [StringLength(100)]
    public string? DescPerfil { get; set; }

    [Column("foto_perfil")]
    public byte[]? FotoPerfil { get; set; }
}
