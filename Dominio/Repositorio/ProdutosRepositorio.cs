using Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly efDbContext _context = new efDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }

        //Salvar Produto - Alterar Produto
        public void Salvar(Produto produto)
        {
            if (produto.ProdutoId == 0)
            {
                //Salvado
                _context.Produtos.Add(produto);
            }
            else
            {
                //Alteração
                Produto prod = _context.Produtos.Find(produto.ProdutoId);

                if (prod != null)
                {
                    prod.Nome = produto.Nome;
                    prod.Descricao = produto.Descricao;
                    prod.Preco = produto.Preco;
                    prod.Categoria = produto.Categoria;
                }

            }

            _context.SaveChanges();
        }

        //Excluir

        public Produto Excluir(int produtoId)
        {
            Produto prod = _context.Produtos.Find(produtoId);

            if (prod != null)
            {
                _context.Produtos.Remove(prod);
                _context.SaveChanges();
            }

            return prod;
        }
    }
}
