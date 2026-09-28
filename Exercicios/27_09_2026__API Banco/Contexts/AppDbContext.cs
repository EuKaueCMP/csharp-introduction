using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BancoAPI.Domains;

namespace BancoAPI.Contexts;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<status_transferencia> status_transferencia { get; set; }

    public virtual DbSet<tipo_alteracao> tipo_alteracao { get; set; }

    public virtual DbSet<tipo_transferencia> tipo_transferencia { get; set; }

    public virtual DbSet<tipo_usuario> tipo_usuario { get; set; }

    public virtual DbSet<usuario> usuario { get; set; }

    public virtual DbSet<usuario_log> usuario_log { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=Admin123!;Database=sistema_banco; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<status_transferencia>(entity =>
        {
            entity.HasKey(e => e.status_transferencia_id).HasName("status_transferencia_pkey");

            entity.ToTable("status_transferencia", "banco");

            entity.Property(e => e.nome_status).HasMaxLength(20);
        });

        modelBuilder.Entity<tipo_alteracao>(entity =>
        {
            entity.HasKey(e => e.tipo_alteracao_id).HasName("tipo_alteracao_pkey");

            entity.ToTable("tipo_alteracao", "banco");

            entity.Property(e => e.nome_alteracao).HasMaxLength(20);
        });

        modelBuilder.Entity<tipo_transferencia>(entity =>
        {
            entity.HasKey(e => e.tipo_transferencia_id).HasName("tipo_transferencia_pkey");

            entity.ToTable("tipo_transferencia", "banco");

            entity.Property(e => e.nome_tipo).HasMaxLength(20);
        });

        modelBuilder.Entity<tipo_usuario>(entity =>
        {
            entity.HasKey(e => e.tipo_usuario_id).HasName("tipo_usuario_pkey");

            entity.ToTable("tipo_usuario", "banco");

            entity.HasIndex(e => e.tipo, "tipo_usuario_tipo_key").IsUnique();

            entity.Property(e => e.tipo).HasMaxLength(20);
        });

        modelBuilder.Entity<usuario>(entity =>
        {
            entity.HasKey(e => e.usuario_id).HasName("usuario_pkey");

            entity.ToTable("usuario", "banco");

            entity.HasIndex(e => e.email, "usuario_email_key").IsUnique();

            entity.Property(e => e.email).HasMaxLength(100);
            entity.Property(e => e.saldo)
                .HasPrecision(10, 2)
                .HasDefaultValue(0m);
            entity.Property(e => e.senha).HasMaxLength(100);

            entity.HasOne(d => d.tipo_usuario).WithMany(p => p.usuario)
                .HasForeignKey(d => d.tipo_usuario_id)
                .HasConstraintName("usuario_tipo_usuario_id_fkey");
        });

        modelBuilder.Entity<usuario_log>(entity =>
        {
            entity.HasKey(e => e.log_id).HasName("usuario_log_pkey");

            entity.ToTable("usuario_log", "banco");

            entity.Property(e => e.email).HasMaxLength(100);
            entity.Property(e => e.nome).HasMaxLength(100);
            entity.Property(e => e.saldo).HasPrecision(10, 2);

            entity.HasOne(d => d.tipo_alteracao).WithMany(p => p.usuario_log)
                .HasForeignKey(d => d.tipo_alteracao_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("usuario_log_tipo_alteracao_id_fkey");

            entity.HasOne(d => d.usuario).WithMany(p => p.usuario_log)
                .HasForeignKey(d => d.usuario_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("usuario_log_usuario_id_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
