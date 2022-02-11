using System.Collections.Generic;

namespace apagarConsole
{
    public class UsuariosController
    {
        readonly IUsuarioRepository _usuarioRepositorio;
        public UsuariosController(IUsuarioRepository repository)
        {
            this._usuarioRepositorio = repository;
        }

        // GET: Usuarios
        public List<Usuario> Index()
        {
            var data = _usuarioRepositorio.GetAll();
            return data;
        }
    }
}
