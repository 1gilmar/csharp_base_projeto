using System;
using System.Collections.Generic;

namespace apagarConsole
{
    public interface IUsuarioRepository
    {
        //IEnumerable<Usuario> getAll();

        List<Usuario> GetAll();
        Usuario Get(int id);
        Usuario Add(Usuario item);
        bool Update(Usuario item);
        bool Delete(int id);
    }
}
