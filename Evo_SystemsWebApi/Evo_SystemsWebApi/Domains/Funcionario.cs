using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Evo_SystemsWebApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade Funcionario
    /// </summary>
    [Table("Funcionario")]
    public class Funcionario
    {
        // Define que será uma chave primária
        [Key]
        // Define o outo-incremento
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idFuncionario { get; set; }

        // Define o tipo de dado
        [Column(TypeName = "varchar(150)")]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }

        // Define o tipo de dado
        [Column(TypeName = "varchar(150)")]
        [Required(ErrorMessage = "A foto é obrigatória")]
        public string Foto { get; set; }

        // Define o tipo de dado
        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "O RG é obrigatório")]
        public string RG { get; set; }
        public int idDepartamento { get; set; }

        // Define a chave estrangeira no banco
        [ForeignKey("idDepartamento")]
        public Departamento departamento { get; set; }


    }
}
