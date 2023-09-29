﻿// <auto-generated />
using EletroMultiAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EletroMultiAPI.Migrations
{
    [DbContext(typeof(EletroMultiContext))]
    partial class EletroMultiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EletroMultiAPI.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("EletroMultiAPI.Models.Equipamento", b =>
                {
                    b.Property<int>("EquipamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Garantia")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NumSerie")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("EquipamentoId");

                    b.HasIndex("ServicoId");

                    b.ToTable("Equipamentos");
                });

            modelBuilder.Entity("EletroMultiAPI.Models.Servico", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroOs")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ServicoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("EletroMultiAPI.Models.Equipamento", b =>
                {
                    b.HasOne("EletroMultiAPI.Models.Servico", "Servico")
                        .WithMany("Equipamentos")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("EletroMultiAPI.Models.Servico", b =>
                {
                    b.HasOne("EletroMultiAPI.Models.Cliente", "Cliente")
                        .WithMany("Servicos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("EletroMultiAPI.Models.Cliente", b =>
                {
                    b.Navigation("Servicos");
                });

            modelBuilder.Entity("EletroMultiAPI.Models.Servico", b =>
                {
                    b.Navigation("Equipamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
