﻿// <auto-generated />
using System;
using CotacaoApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CotacaoApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CotacaoApi.Models.Cotacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CEP")
                        .HasColumnType("longtext");

                    b.Property<string>("CNPJComprador")
                        .HasColumnType("longtext");

                    b.Property<string>("CNPJFornecedor")
                        .HasColumnType("longtext");

                    b.Property<string>("Complemento")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCotacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataEntregaCotacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroCotacao")
                        .HasColumnType("longtext");

                    b.Property<string>("Observacao")
                        .HasColumnType("longtext");

                    b.Property<string>("UF")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cotacoes");
                });

            modelBuilder.Entity("CotacaoApi.Models.CotacaoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CotacaoId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Marca")
                        .HasColumnType("longtext");

                    b.Property<int>("NumeroItem")
                        .HasColumnType("int");

                    b.Property<float>("Preco")
                        .HasColumnType("float");

                    b.Property<float>("Quantidade")
                        .HasColumnType("float");

                    b.Property<string>("Unidade")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CotacaoId");

                    b.ToTable("CotacoesItens");
                });

            modelBuilder.Entity("CotacaoApi.Models.CotacaoItem", b =>
                {
                    b.HasOne("CotacaoApi.Models.Cotacao", null)
                        .WithMany("CotacaoItens")
                        .HasForeignKey("CotacaoId");
                });

            modelBuilder.Entity("CotacaoApi.Models.Cotacao", b =>
                {
                    b.Navigation("CotacaoItens");
                });
#pragma warning restore 612, 618
        }
    }
}