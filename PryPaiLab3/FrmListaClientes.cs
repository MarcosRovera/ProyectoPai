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
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ClsCliente cliente = new ClsCliente();
            cliente.Listar(DgvListadoCliente);


        }
    }
}
