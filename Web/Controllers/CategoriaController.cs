﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Dominio.Repositorio;

namespace Web.Controllers
{
    public class CategoriaController : Controller
    {
        private ProdutosRepositorio _repositorio;

        public PartialViewResult Menu(string categoria = null)
        {
            ViewBag.CategoriaSelecionada = categoria;

            _repositorio = new ProdutosRepositorio();

            IEnumerable<string> categorias = _repositorio.Produtos
                .Select(c => c.Categoria)
                .Distinct()
                .OrderBy(c => c);

            return PartialView(categorias);


        }
    }
}