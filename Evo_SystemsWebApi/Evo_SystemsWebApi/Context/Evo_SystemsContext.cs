using Evo_SystemsWebApi.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evo_SystemsWebApi.Context
{
    /// <summary>
    /// Classe responsável pelo context do projeto
    /// Faz a cominicação entre API e o Banco de dados
    /// </summary>

    public class Evo_SystemsContext : DbContext
    {
        // Define as entidades do Banco de dados
        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Data Source=DESKTOP-0KGDOK7; initial catalog=Evo_Systems; Integrated Security=True;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            // Definir as entidades já com dados.
            modelBuilder.Entity<Funcionario>().HasData(
                new Funcionario
                {
                    idFuncionario = 1,
                    Nome = "Lameck",
                    Foto = "Foto.png",
                    RG = "586985896",
                    idDepartamento = 1
                }
                );

            modelBuilder.Entity<Departamento>().HasData(
                new Departamento
                {
                    idDepartamento = 1,
                    Nome = "Recursos Humanos",
                    Sigla = "RH"  
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
