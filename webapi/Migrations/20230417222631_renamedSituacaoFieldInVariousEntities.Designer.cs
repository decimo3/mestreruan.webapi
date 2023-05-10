﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using mestreruan.api.Database;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230417222631_renamedSituacaoFieldInVariousEntities")]
    partial class renamedSituacaoFieldInVariousEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("mestreruan.api.Entities.Equipe", b =>
                {
                    b.Property<int>("servico")
                        .HasColumnType("integer");

                    b.Property<int>("espelho")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("dia")
                        .HasColumnType("date");

                    b.Property<int>("ajudanteId")
                        .HasColumnType("integer");

                    b.Property<int>("motoristaId")
                        .HasColumnType("integer");

                    b.Property<int>("supervisorId")
                        .HasColumnType("integer");

                    b.Property<long>("telefoneId")
                        .HasColumnType("bigint");

                    b.Property<string>("viaturaId")
                        .IsRequired()
                        .HasColumnType("character varying(7)");

                    b.HasKey("servico", "espelho", "dia");

                    b.HasIndex("ajudanteId");

                    b.HasIndex("motoristaId");

                    b.HasIndex("supervisorId");

                    b.HasIndex("telefoneId");

                    b.HasIndex("viaturaId");

                    b.ToTable("equipe", (string)null);
                });

            modelBuilder.Entity("mestreruan.api.Entities.Funcionario", b =>
                {
                    b.Property<int>("re")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("re"));

                    b.Property<string>("apelido")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)");

                    b.Property<int>("escala")
                        .HasColumnType("integer");

                    b.Property<int>("funcao")
                        .HasColumnType("integer");

                    b.Property<int>("matricula")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("senha")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<int>("situacaoFuncionario")
                        .HasColumnType("integer");

                    b.Property<string>("sobrenome")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)");

                    b.HasKey("re");

                    b.ToTable("funcionario", (string)null);
                });

            modelBuilder.Entity("mestreruan.api.Entities.Telefone", b =>
                {
                    b.Property<long>("numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("numero"));

                    b.Property<string>("chip")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("imei")
                        .HasColumnType("bigint");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<int>("situacaoTelefone")
                        .HasColumnType("integer");

                    b.HasKey("numero");

                    b.ToTable("telefone", (string)null);
                });

            modelBuilder.Entity("mestreruan.api.Entities.Viatura", b =>
                {
                    b.Property<string>("placa")
                        .HasMaxLength(7)
                        .HasColumnType("character varying(7)");

                    b.Property<int>("ordem")
                        .HasColumnType("integer");

                    b.Property<int>("situacaoViatura")
                        .HasColumnType("integer");

                    b.HasKey("placa");

                    b.ToTable("viatura", (string)null);
                });

            modelBuilder.Entity("mestreruan.api.Entities.Equipe", b =>
                {
                    b.HasOne("mestreruan.api.Entities.Funcionario", "ajudante")
                        .WithMany()
                        .HasForeignKey("ajudanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mestreruan.api.Entities.Funcionario", "motorista")
                        .WithMany()
                        .HasForeignKey("motoristaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mestreruan.api.Entities.Funcionario", "supervisor")
                        .WithMany()
                        .HasForeignKey("supervisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mestreruan.api.Entities.Telefone", "telefone")
                        .WithMany()
                        .HasForeignKey("telefoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mestreruan.api.Entities.Viatura", "viatura")
                        .WithMany()
                        .HasForeignKey("viaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ajudante");

                    b.Navigation("motorista");

                    b.Navigation("supervisor");

                    b.Navigation("telefone");

                    b.Navigation("viatura");
                });
#pragma warning restore 612, 618
        }
    }
}
