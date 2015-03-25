﻿using Dominio.Entidades;
using Dominio.Repositorio;
using System.Linq;
using System.Web.Mvc;

namespace Web.Areas.Administrativo.Controllers
{
    public class ProdutoController : Controller
    {

        private ProdutosRepositorio _repositorio;


        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos;
            return View(produtos);
        }


        public ViewResult Alterar(int produtoId)
        {
            _repositorio = new ProdutosRepositorio();
            Produto produto = _repositorio.Produtos
                .FirstOrDefault(p => p.ProdutoId == produtoId);
            return View(produto);
        }
    }
}