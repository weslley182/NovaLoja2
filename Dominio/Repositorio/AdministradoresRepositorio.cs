using Dominio.Entidades;
using System.Linq;


namespace Dominio.Repositorio
{
    public class AdministradoresRepositorio
    {
        private readonly efDbContext _context = new efDbContext();

        public Administrador ObterAdministrador(Administrador administrador)
        {
            return _context.Administradores.FirstOrDefault(a => a.Login == administrador.Login);
        }
    }
}
