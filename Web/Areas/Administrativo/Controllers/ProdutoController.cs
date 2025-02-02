﻿using Dominio.Entidades;
using Dominio.Repositorio;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Areas.Administrativo.Controllers
{

    [Authorize]
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


        [HttpPost]
        public ActionResult Alterar(Produto produto, HttpPostedFileBase image = null)
        {
            if (ModelState.IsValid)
            {
                _repositorio = new ProdutosRepositorio();
                _repositorio.Salvar(produto);

                TempData["mensagem"] = string.Format("{0} foi salvo com sucesso", produto.Nome);

                return RedirectToAction("Index");

            }
            return View(produto);
        }

        public ViewResult NovoProduto()
        {
            return View("Alterar", new Produto());
        }


        //[HttpPost]
        //public ActionResult Excluir(int produtoId)
        //{
        //    _repositorio = new ProdutosRepositorio();

        //    Produto prod = _repositorio.Excluir(produtoId);

        //    if (prod != null)
        //    {
        //        TempData["mensagem"] = string.Format("{0} excluído com sucesso", prod.Nome);
        //    }

        //    return RedirectToAction("Index");
        //}



        [HttpPost]
        public JsonResult Excluir(int produtoId)
        {
            // System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));

            string mensagem = string.Empty;
            _repositorio = new ProdutosRepositorio();

            Produto prod = _repositorio.Excluir(produtoId);

            if (prod != null)
            {
                mensagem = string.Format("{0} excluído com sucesso", prod.Nome);
            }

            return Json(mensagem, JsonRequestBehavior.AllowGet);
        }
    }
}