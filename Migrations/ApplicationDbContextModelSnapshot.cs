﻿// <auto-generated />
using System;
using MeuSistema.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MeuSis.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("MeuSistema.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CNPJ")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("MeuSistema.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
