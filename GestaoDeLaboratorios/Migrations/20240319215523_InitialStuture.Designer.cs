﻿// <auto-generated />
using System;
using GestaoDeLaboratorios.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoDeLaboratorios.Migrations
{
    [DbContext(typeof(InfnetDbContext))]
    [Migration("20240319215523_InitialStuture")]
    partial class InitialStuture
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestaoDeLaboratorios.Models.Computador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.Property<string>("HD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroPatrimonio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlacaMae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processador")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Computador", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
