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

    public virtual DbSet<TbCliente> TbClientes { get; set; }

    public virtual DbSet<TbDetalleVentum> TbDetalleVenta { get; set; }

    public virtual DbSet<TbProducto> TbProductos { get; set; }

    public virtual DbSet<TbProveedor> TbProveedors { get; set; }

    public virtual DbSet<TbTrabajador> TbTrabajadors { get; set; }

    public virtual DbSet<TbUsuario> TbUsuarios { get; set; }

    public virtual DbSet<TbVentum> TbVenta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=JOELSPIANO\\SQLEXPRESS01;Initial Catalog=INFOCHILL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbCliente>(entity =>
        {
            entity.HasKey(e => e.CodCliente).HasName("PK__TB_CLIEN__39F43E92948BFC5F");

            entity.ToTable("TB_CLIENTE");

            entity.Property(e => e.CodCliente).HasColumnName("codCliente");
            entity.Property(e => e.ApeCli)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apeCli");
            entity.Property(e => e.DniCli).HasColumnName("dniCli");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.NomCli)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nomCli");
            entity.Property(e => e.TlfCli)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("tlfCli");
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
                .HasConstraintName("FK__TB_DETALL__IdPro__5165187F");

            entity.HasOne(d => d.IdVentaNavigation).WithMany()
                .HasForeignKey(d => d.IdVenta)
                .HasConstraintName("FK__TB_DETALL__IdVen__5070F446");
        });

        modelBuilder.Entity<TbProducto>(entity =>
        {
            entity.HasKey(e => e.IdPro).HasName("PK__TB_PRODU__3D795B27A51D2565");

            entity.ToTable("TB_PRODUCTO");

            entity.Property(e => e.IdPro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idPro");
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

        modelBuilder.Entity<TbProveedor>(entity =>
        {
            entity.HasKey(e => e.CodProveedor).HasName("PK__TB_PROVE__26E566FB6D5DCEAF");

            entity.ToTable("TB_PROVEEDOR");

            entity.Property(e => e.CodProveedor).HasColumnName("codProveedor");
            entity.Property(e => e.DirProveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dirProveedor");
            entity.Property(e => e.RazSocial).HasColumnName("razSocial");
            entity.Property(e => e.RepartidorVenta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("repartidorVenta");
            entity.Property(e => e.TlfProveedor)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("tlfProveedor");
        });

        modelBuilder.Entity<TbTrabajador>(entity =>
        {
            entity.HasKey(e => e.CodTrabaj).HasName("PK__TB_TRABA__40C66A9546FB496E");

            entity.ToTable("TB_TRABAJADOR");

            entity.Property(e => e.CodTrabaj).HasColumnName("codTrabaj");
            entity.Property(e => e.ApeTrabaj)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apeTrabaj");
            entity.Property(e => e.DniTrabaj).HasColumnName("dniTrabaj");
            entity.Property(e => e.FechaIngreTrabaj)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("fechaIngreTrabaj");
            entity.Property(e => e.NomTrabaj)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nomTrabaj");
            entity.Property(e => e.SueldoTrabaj)
                .HasColumnType("money")
                .HasColumnName("sueldoTrabaj");
            entity.Property(e => e.TlfTrabaj)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("tlfTrabaj");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TB_USUARIO");

            entity.Property(e => e.UsuClave)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.UsuUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.UsuUsuario)
                .HasConstraintName("FK__TB_USUARI__UsuUs__534D60F1");
        });

        modelBuilder.Entity<TbVentum>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__TB_VENTA__077D5614988CBBB7");

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
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.TbVenta)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__TB_VENTA__idClie__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
