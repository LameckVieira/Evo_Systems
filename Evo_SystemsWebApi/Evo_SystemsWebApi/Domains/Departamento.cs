using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Evo_SystemsWebApi.Domains
{
    [Table("Departamento")]
    public class Departamento
    {
        // Define que será uma chave primária
        [Key]
        // Define o outo-incremento
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idDepartamento { get; set; }

            // Define o tipo de dado
        [Column(TypeName = "varchar(150)")]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(10)")]
        [Required(ErrorMessage = "O RG é obrigatório")]
        public string Sigla { get; set; }


       
    }
}
