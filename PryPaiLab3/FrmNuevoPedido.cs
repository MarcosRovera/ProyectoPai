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
    public partial class FrmNuevoPedido : Form
    {
        public FrmNuevoPedido()
        {
            InitializeComponent();
        }
        ClsCliente cliente = new ClsCliente();
        ClsProducto producto = new ClsProducto();

        private void FrmNuevoPedido_Load(object sender, EventArgs e)
        {
            cliente.Buscar(CbxNombres);
            producto.CargarCbxNombres(CbxProducto);

        }
    }
}
