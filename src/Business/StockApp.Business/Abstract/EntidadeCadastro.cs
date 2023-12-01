using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Business.Abstract
{
    public abstract class EntidadeCadastro : EntidadeBase
    {
        public string Nome { get; set; }
        public int Status { get; set; }
    }
}
