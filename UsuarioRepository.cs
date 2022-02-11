using System;
using System.Collections.Generic;

namespace apagarConsole
{
    public class UsuarioRepository: IUsuarioRepository
    {

        private int Id = 1;
        private List<Usuario> usuarios = new List<Usuario>();

        public UsuarioRepository()
        {
            Add(new Usuario { ID = 1, Nome = "nome", Email = "nome@gmail.com", Senha = "senha" });
            Add(new Usuario { ID = 2, Nome = "nome2", Email = "nome2@gmail.com", Senha = "senha2" });
        }

        public Usuario Add(Usuario item)
        {
            if(item == null)
            {
                throw new NotImplementedException(nameof(item));
            }
            item.ID = Id++;
            usuarios.Add(item);
            return item;
        }

        public bool Delete(int id)
        {
            usuarios.RemoveAll(x => x.ID == id);
            return true;
        }

        public Usuario Get(int id)
        {
            return usuarios.FindLast(x => x.ID == id);
        }

        public List<Usuario> GetAll()
        {
            return usuarios;
        }

        public bool Update(Usuario item)
        {
            if (item == null)
            {
                throw new NotImplementedException(nameof(item));
            }

            int index = usuarios.FindIndex(x => x.ID == item.ID);
            if(index == -1)
            {
                return false;
            }
            usuarios.RemoveAt(index);
            usuarios.Add(item);

            return true;
        }
    }
}
