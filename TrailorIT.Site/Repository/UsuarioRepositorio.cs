using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TrailorIT.Site.Interfaces;
using TrailorIT.Site.Models;

namespace TrailorIT.Site.Repository
{
    public class UsuarioRepositorio: IUsuarioRepositorio, IDisposable
    {
        private readonly IConfiguration _configuration;

        public UsuarioRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<UsuarioDto> Usuarios(FiltroDto filtro)
        {
            using (SqlConnection conexao = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                return conexao.Query<UsuarioDto>(
                    " select u.UsuarioId, u.Nome, u.DataNascimento, u.Email, u.Senha, u.Ativo, s.Descricao as sexo "+
                    " from Usuario u "+
                    " inner join sexo s on s.SexoId = u.UsuarioId "+
                    " where 1 = 1 "+
                    " and u.Nome like '%"+filtro.nome+"%' "+
                    " and u.Ativo = "+filtro.ativo);
            }
        }

    }
}
