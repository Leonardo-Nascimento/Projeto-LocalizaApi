﻿// <auto-generated />
using System;
using Localiza.Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Localiza.Infra.Migrations
{
    [DbContext(typeof(LocalizaDbContext))]
    [Migration("20220502121324_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Localiza.Domain.Models.Cliente", b =>
                {
                    b.Property<long>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ClienteId"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<long>("EnderecoId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCNH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Localiza.Domain.Models.Endereco", b =>
                {
                    b.Property<long>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("EnderecoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EnderecoId"), 1L, 1);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Localiza.Domain.Models.Fabricante", b =>
                {
                    b.Property<long>("FabricanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FabricanteId"), 1L, 1);

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FabricanteId");

                    b.ToTable("Fabricante");
                });

            modelBuilder.Entity("Localiza.Domain.Models.Modelo", b =>
                {
                    b.Property<long>("ModeloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ModeloId"), 1L, 1);

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<long>("FabricanteId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("ModeloId");

                    b.HasIndex("FabricanteId");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("Localiza.Domain.Models.Reserva", b =>
                {
                    b.Property<long>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ReservaId"), 1L, 1);

                    b.Property<long>("ClienteId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataDevolução")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPrevistaDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRetirada")
                        .HasColumnType("datetime2");

                    b.Property<string>("HoraDevolução")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraRetirada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("StatusReserva")
                        .HasColumnType("tinyint");

                    b.Property<long>("VeiculoId")
                        .HasColumnType("bigint");

                    b.HasKey("ReservaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Localiza.Domain.Models.Veiculo", b =>
                {
                    b.Property<long>("VeiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("VeiculoId"), 1L, 1);

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<long>("FabricanteId")
                        .HasColumnType("bigint");

                    b.Property<long>("ModeloId")
                        .HasColumnType("bigint");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("VeiculoId");

                    b.HasIndex("FabricanteId");

                    b.HasIndex("ModeloId")
                        .IsUnique();

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("Localiza.Domain.Models.Cliente", b =>
                {
                    b.HasOne("Localiza.Domain.Models.Endereco", "Endereco")
                        .WithMany("Cliente")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Localiza.Domain.Models.Modelo", b =>
                {
                    b.HasOne("Localiza.Domain.Models.Fabricante", "Fabricante")
                        .WithMany("Modelo")
                        .HasForeignKey("FabricanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fabricante");
                });

            modelBuilder.Entity("Localiza.Domain.Models.Reserva", b =>
                {
                    b.HasOne("Localiza.Domain.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Localiza.Domain.Models.Veiculo", "Veiculo")
                        .WithMany("Reserva")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("Localiza.Domain.Models.Veiculo", b =>
                {
                    b.HasOne("Localiza.Domain.Models.Fabricante", "Fabricante")
                        .WithMany()
                        .HasForeignKey("FabricanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Localiza.Domain.Models.Modelo", "Modelo")
                        .WithOne()
                        .HasForeignKey("Localiza.Domain.Models.Veiculo", "ModeloId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Fabricante");

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("Localiza.Domain.Models.Endereco", b =>
                {
                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Localiza.Domain.Models.Fabricante", b =>
                {
                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("Localiza.Domain.Models.Veiculo", b =>
                {
                    b.Navigation("Reserva");
                });
#pragma warning restore 612, 618
        }
    }
}