using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntregaSemana8.Models;

public partial class BdInfochill : DbContext
{
    public BdInfochill()
    {
    }

    public BdInfochill(DbContextOptions<BdInfochill> options)
        : base(options)
    {
    }

    public virtual DbSet<TbAlumno> TbAlumnos { get; set; }

    public virtual DbSet<TbDetalleVentum> TbDetalleVenta { get; set; }

    public virtual DbSet<TbProducto> TbProductos { get; set; }

    public virtual DbSet<TbVentum> TbVenta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-AMUJTOVV\\SQLEXPRESS;Initial Catalog=INFOCHILL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbAlumno>(entity =>
        {
            entity.HasKey(e => e.CodAlumno).HasName("PK__TB_ALUMN__F7169888FCE89D94");

            entity.ToTable("TB_ALUMNO");

            entity.Property(e => e.CodAlumno).HasColumnName("codAlumno");
            entity.Property(e => e.ApeAlu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apeAlu");
            entity.Property(e => e.DniAlu).HasColumnName("dniAlu");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.NomAlu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nomAlu");
            entity.Property(e => e.PassCli)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("passCli");
            entity.Property(e => e.TlfAlu)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("tlfAlu");
            entity.Property(e => e.UserCli)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("userCli");
        });

        modelBuilder.Entity<TbDetalleVentum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TB_DETALLE_VENTA");

            entity.Property(e => e.IdProducto)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdProductoNavigation).WithMany()
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__TB_DETALL__IdPro__3F466844");

            entity.HasOne(d => d.IdVentaNavigation).WithMany()
                .HasForeignKey(d => d.IdVenta)
                .HasConstraintName("FK__TB_DETALL__IdVen__3E52440B");
        });

        modelBuilder.Entity<TbProducto>(entity =>
        {
            entity.HasKey(e => e.IdPro).HasName("PK__TB_PRODU__3D795B277B3A31F0");

            entity.ToTable("TB_PRODUCTO");

            entity.Property(e => e.IdPro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idPro");
            entity.Property(e => e.CantCompra).HasColumnName("cantCompra");
            entity.Property(e => e.CatePro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("catePro");
            entity.Property(e => e.DesPro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desPro");
            entity.Property(e => e.PrePro)
                .HasColumnType("money")
                .HasColumnName("prePro");
            entity.Property(e => e.StkAct).HasColumnName("stkAct");
            entity.Property(e => e.StkMin).HasColumnName("stkMin");
        });

        modelBuilder.Entity<TbVentum>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__TB_VENTA__077D5614C3D58330");

            entity.ToTable("TB_VENTA");

            entity.Property(e => e.IdVenta).HasColumnName("idVenta");
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaVenta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.IdTransaccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MontoTotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.TbVenta)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__TB_VENTA__idClie__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
