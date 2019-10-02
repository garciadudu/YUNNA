using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrailorIT.Site.Interfaces;
using TrailorIT.Site.Models;

namespace TrailorIT.Site.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly TailorItContext _context;
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(TailorItContext context,
                                 IUsuarioRepositorio usuarioRepositorio)
        {
            _context = context;
            _usuarioRepositorio = usuarioRepositorio; 
        }


        [HttpGet]
        public IActionResult Index()
        {
            List<Sexo> listaSexos = new List<Sexo>();

            //----pega dados da tabela
            listaSexos = (from sexo in _context.Sexos
                          select sexo).ToList();

            // Inser um item na lista
            listaSexos.Insert(0, new Sexo { SexoId = 0, Descricao = "Selecione" });
            ViewBag.ListaSexos = listaSexos;


            return View();
        }

        [HttpPost]
        public IActionResult Index(Usuario usuario)
        {
            List<Sexo> listaSexos = new List<Sexo>();

            //----pega dados da tabela
            listaSexos = (from sexo in _context.Sexos
                          select sexo).ToList();

            // Inser um item na lista
            listaSexos.Insert(0, new Sexo { SexoId = 0, Descricao = "Selecione" });
            ViewBag.ListaSexos = listaSexos;


            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();

                return View(usuario);
            } else
            {
                return View(usuario);
            }
        }

        public IActionResult Relatorio()
        {
            return View();
        }

        [HttpPost]
        public JsonResult RelatorioLista([FromBody]FiltroDto usuario)
        {
            return Json(_usuarioRepositorio.Usuarios(usuario));

            //return Json(_context.Usuarios.
            //                    Include(s => s.Sexo).
            //                    Where(x => x.Nome.Contains(usuario.nome) || x.Ativo.Equals(usuario.ativo)).
            //                    ToList());
        }
    }
}