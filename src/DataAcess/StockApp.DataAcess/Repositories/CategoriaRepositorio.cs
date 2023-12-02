using StockApp.Business.Entities;
using StockApp.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAcess.Repositories
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        public bool Ativar(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Atualizar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public bool Inativar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Incluir(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Categoria ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> ObterTodasAtivas()
        {
            throw new NotImplementedException();
        }

        public List<Categoria> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public bool Remover(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
