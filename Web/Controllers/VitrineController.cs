using Dominio.Repositorio;
using System.Linq;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class VitrineController : Controller
    {
       private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 8;

        public ViewResult ListaProdutos(string categoria, int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();

            ProdutosViewModel model = new ProdutosViewModel
            {
                Produtos = _repositorio.Produtos
                    .Where(p => categoria == null || p.Categoria == categoria)
                    .OrderBy(p => p.Descricao)
                    .Skip((pagina - 1) * ProdutosPorPagina)
                    .Take(ProdutosPorPagina),


                Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = _repositorio.Produtos.Count()
                },

                CategoriaAtual = categoria
            };


            return View(model);

        }
        
    }
}