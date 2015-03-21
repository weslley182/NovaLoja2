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
    }
}
