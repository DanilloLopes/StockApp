using StockApp.Business.Entities;
using StockApp.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp.WindowsForms.Registers
{

    public partial class frmCategoria : Form
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public frmCategoria()
        {
            InitializeComponent();
        }
        public frmCategoria(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novaCategoria = new Categoria();
            novaCategoria.Nome = txtNome.Text;
            novaCategoria.Status = chkAtivo.Checked;

            var resultado = _categoriaRepositorio.Incluir(novaCategoria);

            if(resultado)
            {
                MessageBox.Show("Categoria cadastrada com sucesso!");
                return;
            }
            else
            {
                MessageBox.Show("Erro!");
            }

        }
    }
}
