using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPaiLab3
{
    public partial class FrmListarProductos : Form
    {
        public FrmListarProductos()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ClsProducto producto = new ClsProducto();
            producto.Listar(DgvProductos);
        }
    }
}
