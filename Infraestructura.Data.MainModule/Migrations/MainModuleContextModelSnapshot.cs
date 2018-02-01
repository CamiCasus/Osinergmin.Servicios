﻿// <auto-generated />
using Infraestructura.Data.MainModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Infraestructura.Data.MainModule.Migrations
{
    [DbContext(typeof(MainModuleContext))]
    partial class MainModuleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.MainModule.Entities.DetalleGuiaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CantidadMuestras");

                    b.Property<string>("CodigoEstablecimiento");

                    b.Property<string>("CodigoProducto");

                    b.Property<DateTime>("FechaMuestreo");

                    b.Property<string>("FotoMuestra");

                    b.Property<int>("GuiaId");

                    b.Property<string>("NombreArchivo");

                    b.Property<string>("NumeroActa");

                    b.Property<int>("NumeroMuestra");

                    b.Property<string>("NumeroPrescintoDirimencia");

                    b.Property<string>("NumeroPrescintoLaboratorio");

                    b.Property<string>("OrigenProducto");

                    b.Property<string>("TipoEnvase");

                    b.Property<int>("TipoMuestra");

                    b.HasKey("Id");

                    b.HasIndex("GuiaId");

                    b.ToTable("DetalleGuiaEntity");
                });

            modelBuilder.Entity("Domain.MainModule.Entities.GuiaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<string>("Comentario");

                    b.Property<string>("DniRepresentanteIntertek");

                    b.Property<string>("DniRepresentanteOsinergmin");

                    b.Property<int>("Estado");

                    b.Property<DateTime>("FechaRecepcion");

                    b.Property<string>("GuiaAdjunta");

                    b.Property<string>("NombreArchivo");

                    b.Property<string>("RepresentanteIntertek");

                    b.Property<string>("RepresentanteOsinergmin");

                    b.Property<string>("SupervisorExtraccionMuestra");

                    b.HasKey("Id");

                    b.ToTable("Guias");
                });

            modelBuilder.Entity("Domain.MainModule.Entities.DetalleGuiaEntity", b =>
                {
                    b.HasOne("Domain.MainModule.Entities.GuiaEntity", "Guia")
                        .WithMany("Detalles")
                        .HasForeignKey("GuiaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
