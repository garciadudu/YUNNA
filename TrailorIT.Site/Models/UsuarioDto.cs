using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrailorIT.Site.Models
{
    public class UsuarioDto
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Ativo { get; set; }
        public string Sexo { get; set; }
    }
}
