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
    public partial class FrmNuevoCliente : Form
    {
        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            ClsCliente cliente = new ClsCliente();
            cliente.Nom = TxtNom.Text;
            cliente.Direcc = TxtDirecc.Text;
            cliente.Numero = TxtTelefono.Text;
            cliente.Agregar();
            MessageBox.Show("Cliente agregado correctamente");
            TxtNom.Text = "";
            TxtDirecc.Text = "";
            TxtTelefono.Text = "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
