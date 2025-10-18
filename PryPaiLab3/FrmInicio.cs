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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaClientes frmListaClientes = new FrmListaClientes();
            frmListaClientes.ShowDialog();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frmNuevoCliente = new FrmNuevoCliente();
            frmNuevoCliente.ShowDialog();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente frmBuscarCliente = new FrmBuscarCliente();
            frmBuscarCliente.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarProductos frmListarProductos = new FrmListarProductos();
            frmListarProductos.ShowDialog();
        }

        private void agregarNuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto();
            frmNuevoProducto.ShowDialog();
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarProductor frmBuscarProductor = new FrmBuscarProductor();
            frmBuscarProductor.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevosPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoPedido frmNuevoPedido = new FrmNuevoPedido();
            frmNuevoPedido.ShowDialog();
        }

        private void totalesPorClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTotalPorCliente frmTotalPorCliente = new FrmTotalPorCliente();
            frmTotalPorCliente.ShowDialog();
        }

        private void nUEVOPAGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPago frmPago = new FrmPago();
            frmPago.ShowDialog();
        }
    }
}
