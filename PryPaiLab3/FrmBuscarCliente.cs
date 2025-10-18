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
    public partial class FrmBuscarCliente : Form
    {
        public FrmBuscarCliente()
        {
            InitializeComponent();
        }


        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            ClsCliente cliente = new ClsCliente();
            cliente.Buscar(CbxNombres);
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = false;
        }
        private void Limpiar()
        {
            TxtDirecc.Text = "";
            TxtTelefono.Text = "";
            CbxNombres.SelectedIndex = 0;
            TxtDirecc.ReadOnly = true;
            TxtTelefono.ReadOnly = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClsCliente cliente = new ClsCliente();
            Int32 nombre = Convert.ToInt32(CbxNombres.SelectedValue);
            cliente.BuscarNombre(nombre);
            BtnEliminar.Enabled = true;
            BtnModificar.Enabled = true;
            TxtDirecc.Text = cliente.Direcc;
            TxtTelefono.Text = cliente.Numero;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClsCliente x = new ClsCliente();
            Int32 nombre = Convert.ToInt32(CbxNombres.SelectedValue);
            x.ELiminar(nombre);
            Limpiar();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClsCliente x = new ClsCliente();
            x.Direcc = TxtDirecc.Text;
            x.Numero = TxtTelefono.Text;
            x.Modificar(Convert.ToInt32(CbxNombres.SelectedValue));
            Limpiar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = true;
            TxtDirecc.ReadOnly = false;
            TxtTelefono.ReadOnly = false;
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            ClsCliente x = new ClsCliente();
            x.Direcc = TxtDirecc.Text;
            x.Numero = TxtTelefono.Text;
            x.Modificar(Convert.ToInt32(CbxNombres.SelectedValue));
            Limpiar();
        }
    }
}
