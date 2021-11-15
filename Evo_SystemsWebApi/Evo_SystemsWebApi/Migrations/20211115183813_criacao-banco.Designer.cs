﻿// <auto-generated />
using Evo_SystemsWebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Evo_SystemsWebApi.Migrations
{
    [DbContext(typeof(Evo_SystemsContext))]
    [Migration("20211115183813_criacao-banco")]
    partial class criacaobanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Evo_SystemsWebApi.Domains.Departamento", b =>
                {
                    b.Property<int>("idDepartamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("idDepartamento");

                    b.ToTable("Departamento");

                    b.HasData(
                        new
                        {
                            idDepartamento = 1,
                            Nome = "Recursos Humanos",
                            Sigla = "RH"
                        });
                });

            modelBuilder.Entity("Evo_SystemsWebApi.Domains.Funcionario", b =>
                {
                    b.Property<int>("idFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("idDepartamento")
                        .HasColumnType("int");

                    b.HasKey("idFuncionario");

                    b.HasIndex("idDepartamento");

                    b.ToTable("Funcionario");

                    b.HasData(
                        new
                        {
                            idFuncionario = 1,
                            Foto = "Foto.png",
                            Nome = "Lameck",
                            RG = "586985896",
                            idDepartamento = 1
                        });
                });

            modelBuilder.Entity("Evo_SystemsWebApi.Domains.Funcionario", b =>
                {
                    b.HasOne("Evo_SystemsWebApi.Domains.Departamento", "departamento")
                        .WithMany()
                        .HasForeignKey("idDepartamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("departamento");
                });
#pragma warning restore 612, 618
        }
    }
}
