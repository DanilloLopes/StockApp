using StockApp.Business.Abstract;
using StockApp.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Business.Interfaces
{
    public interface ISubcategoriaRepositorio 
    {
        bool Incluir(Categoria categoria);
        bool Atualizar(Categoria categoria);
        bool Remover(int Id);
        bool Ativar(int Id);
        bool Inativar(int id);

        Categoria ObterPorId(int id);
        List<Categoria> ObterTodos();
        List<Categoria> ObterTodasAtivas();
    }
}
