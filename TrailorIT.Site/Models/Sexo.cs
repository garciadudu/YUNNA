using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrailorIT.Site.Models
{
    [Table("sexo")]
    public class Sexo
    {
        [Key]
        public int SexoId { get; set; }
        [Display(Name = "Sexo")]
        public string Descricao { get; set; }
    }
}
