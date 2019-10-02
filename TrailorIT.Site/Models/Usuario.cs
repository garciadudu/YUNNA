using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrailorIT.Site.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [Display(Name = "Nome do Usuário")]
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Ativo { get; set; }

        [ForeignKey("sexo")]
        public int SexoId { get; set; }
        public Sexo Sexo { get; set; }
    }
}
