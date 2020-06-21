﻿// <auto-generated />
using Examen1DeAplicada1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Examen1DeAplicada1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200616031922_Migracion_Inicial")]
    partial class Migracion_Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("Examen1DeAplicada1.Entidades.Articulos", b =>
                {
                    b.Property<int>("productoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("costo")
                        .HasColumnType("REAL");

                    b.Property<string>("descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("existencia")
                        .HasColumnType("TEXT");

                    b.Property<int>("valorInventario")
                        .HasColumnType("INTEGER");

                    b.HasKey("productoId");

                    b.ToTable("Articulos");
                });
#pragma warning restore 612, 618
        }
    }
}