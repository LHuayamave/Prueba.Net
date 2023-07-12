﻿// <auto-generated />
using System;
using FacturasAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FacturasAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230712172336_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FacturasAPI.Entidad.FacturaCabecera", b =>
                {
                    b.Property<int>("IdFacturaCabecera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFacturaCabecera"), 1L, 1);

                    b.Property<string>("DireccionEmpresa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EstadoFacturaCabecera")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasDefaultValue("A");

                    b.Property<DateTime>("FechaFacturaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime");

                    b.Property<double?>("Iva")
                        .HasColumnType("float");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NombreEmpresa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NumeroFactura")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TelefonoEmpresa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<double?>("TotalFactura")
                        .HasColumnType("float");

                    b.HasKey("IdFacturaCabecera")
                        .HasName("PK__FacturaCabecera");

                    b.ToTable("FacturaCabecera", (string)null);
                });

            modelBuilder.Entity("FacturasAPI.Entidad.FacturaDetalle", b =>
                {
                    b.Property<int>("IdFacturaDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFacturaDetalle"), 1L, 1);

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("IdFacturaCabecera")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SubtotalProducto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdFacturaDetalle")
                        .HasName("PK__FacturaDetalle");

                    b.HasIndex("IdFacturaCabecera");

                    b.HasIndex("IdProducto");

                    b.ToTable("FacturaDetalle", (string)null);
                });

            modelBuilder.Entity("FacturasAPI.Entidad.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"), 1L, 1);

                    b.Property<string>("EstadoProducto")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasDefaultValue("A");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("FechaEliminacion")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdProducto")
                        .HasName("PK__Producto");

                    b.ToTable("Producto", (string)null);
                });

            modelBuilder.Entity("FacturasAPI.Entidad.FacturaDetalle", b =>
                {
                    b.HasOne("FacturasAPI.Entidad.FacturaCabecera", "FacturaCabecera")
                        .WithMany("FacturaDetalle")
                        .HasForeignKey("IdFacturaCabecera")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_FacturaDetalle_FacturaCabecera");

                    b.HasOne("FacturasAPI.Entidad.Producto", "Producto")
                        .WithMany("FacturaDetalle")
                        .HasForeignKey("IdProducto")
                        .IsRequired()
                        .HasConstraintName("FK_FacturaDetalle_Producto");

                    b.Navigation("FacturaCabecera");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("FacturasAPI.Entidad.FacturaCabecera", b =>
                {
                    b.Navigation("FacturaDetalle");
                });

            modelBuilder.Entity("FacturasAPI.Entidad.Producto", b =>
                {
                    b.Navigation("FacturaDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}