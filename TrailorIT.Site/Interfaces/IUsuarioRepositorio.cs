using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailorIT.Site.Models;

namespace TrailorIT.Site.Interfaces
{
    public interface IUsuarioRepositorio
    {
        IEnumerable<UsuarioDto> Usuarios(FiltroDto filtro);
    }
}
