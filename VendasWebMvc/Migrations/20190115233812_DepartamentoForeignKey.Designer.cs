﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VendasWebMvc.Data;

namespace VendasWebMvc.Migrations
{
    [DbContext(typeof(VendasWebMvcAppContext))]
    [Migration("20190115233812_DepartamentoForeignKey")]
    partial class DepartamentoForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VendasWebMvc.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("VendasWebMvc.Models.RegistroDeVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("Status");

                    b.Property<double>("Valor");

                    b.Property<int?>("vendedorId");

                    b.HasKey("Id");

                    b.HasIndex("vendedorId");

                    b.ToTable("RegistroDeVenda");
                });

            modelBuilder.Entity("VendasWebMvc.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int?>("DepartamentoId");

                    b.Property<string>("Nome");

                    b.Property<double>("SalarioBase");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("VendasWebMvc.Models.RegistroDeVenda", b =>
                {
                    b.HasOne("VendasWebMvc.Models.Vendedor", "vendedor")
                        .WithMany("Vendas")
                        .HasForeignKey("vendedorId");
                });

            modelBuilder.Entity("VendasWebMvc.Models.Vendedor", b =>
                {
                    b.HasOne("VendasWebMvc.Models.Departamento", "Departamento")
                        .WithMany("Vendedores")
                        .HasForeignKey("DepartamentoId");
                });
#pragma warning restore 612, 618
        }
    }
}
