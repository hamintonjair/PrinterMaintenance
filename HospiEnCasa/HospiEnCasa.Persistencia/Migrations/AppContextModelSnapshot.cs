﻿// <auto-generated />
using System;
using HospiEnCasa.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospiEnCasa.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HospiEnCasa.Dominio.CompraRepuesto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("fecha_compra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("impresoraid")
                        .HasColumnType("int");

                    b.Property<int?>("repuestoid")
                        .HasColumnType("int");

                    b.Property<string>("tipo_repuesto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("impresoraid");

                    b.HasIndex("repuestoid");

                    b.ToTable("CompraRepuestos");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.Impresiones3D", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Tipo_impresion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cantidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("impresoraid")
                        .HasColumnType("int");

                    b.Property<string>("precio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("impresoraid");

                    b.ToTable("Impresion3D");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.Impresora", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ano_modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("detalles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecha_mantenimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("otros_caracteristicas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais_origen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tipoImpresoraid")
                        .HasColumnType("int");

                    b.Property<string>("velocidad_imp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("volumen_imp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("tipoImpresoraid");

                    b.ToTable("Impresoras");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.NivelEstudio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("estudio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("NivelEstudios");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecha_nacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("nivelEstudioid")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("socio")
                        .HasColumnType("int");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("nivelEstudioid");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.Repuesto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cantidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("n_Repuesto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Repuestos");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.Revision", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("compraid")
                        .HasColumnType("int");

                    b.Property<string>("detalles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<string>("fecha_revision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("impresoraid")
                        .HasColumnType("int");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<string>("valor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("compraid");

                    b.HasIndex("impresoraid");

                    b.HasIndex("personaid");

                    b.ToTable("Revisiones");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.Rol", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<string>("tipo_Rol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("personaid");

                    b.ToTable("Roles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Rol");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.SeguroImpresora", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("fecha_activacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecha_vencimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("impresoraid")
                        .HasColumnType("int");

                    b.Property<string>("precio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo_seguro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("impresoraid");

                    b.ToTable("SeguroImpresoras");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.TipoImpresora", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre_impresora")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TipoImpresoras");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.Login", b =>
                {
                    b.HasBaseType("HospiEnCasa.Dominio.Rol");

                    b.HasDiscriminator().HasValue("Login");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.CompraRepuesto", b =>
                {
                    b.HasOne("HospiEnCasa.Dominio.Impresora", "impresora")
                        .WithMany()
                        .HasForeignKey("impresoraid");

                    b.HasOne("HospiEnCasa.Dominio.Repuesto", "repuesto")
                        .WithMany()
                        .HasForeignKey("repuestoid");

                    b.Navigation("impresora");

                    b.Navigation("repuesto");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.Impresiones3D", b =>
                {
                    b.HasOne("HospiEnCasa.Dominio.Impresora", "impresora")
                        .WithMany()
                        .HasForeignKey("impresoraid");

                    b.Navigation("impresora");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.Impresora", b =>
                {
                    b.HasOne("HospiEnCasa.Dominio.TipoImpresora", "tipoImpresora")
                        .WithMany()
                        .HasForeignKey("tipoImpresoraid");

                    b.Navigation("tipoImpresora");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.Persona", b =>
                {
                    b.HasOne("HospiEnCasa.Dominio.NivelEstudio", "nivelEstudio")
                        .WithMany()
                        .HasForeignKey("nivelEstudioid");

                    b.Navigation("nivelEstudio");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.Revision", b =>
                {
                    b.HasOne("HospiEnCasa.Dominio.CompraRepuesto", "compra")
                        .WithMany()
                        .HasForeignKey("compraid");

                    b.HasOne("HospiEnCasa.Dominio.Impresora", "impresora")
                        .WithMany()
                        .HasForeignKey("impresoraid");

                    b.HasOne("HospiEnCasa.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("compra");

                    b.Navigation("impresora");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.Rol", b =>
                {
                    b.HasOne("HospiEnCasa.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("HospiEnCasa.Dominio.SeguroImpresora", b =>
                {
                    b.HasOne("HospiEnCasa.Dominio.Impresora", "impresora")
                        .WithMany()
                        .HasForeignKey("impresoraid");

                    b.Navigation("impresora");
                });
#pragma warning restore 612, 618
        }
    }
}
