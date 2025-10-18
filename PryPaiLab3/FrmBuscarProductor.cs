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
    public partial class FrmBuscarProductor : Form
    {
        public FrmBuscarProductor()
        {
            InitializeComponent();
        }
        ClsProducto producto = new ClsProducto();
        private void FrmBuscarProductor_Load(object sender, EventArgs e)
        {
            ClsProducto x = new ClsProducto();
            x.CargarCbxNombres(CbxNombres);
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClsProducto Producto = new ClsProducto();
            Int32 codigo = Convert.ToInt32(CbxNombres.SelectedValue);
            Producto.BuscarNombre(codigo);
            BtnEliminar.Enabled = true;
            BtnModificar.Enabled = true;
            TxtIdProd.Text = Convert.ToString(Producto.IdProd);
            TxtStock.Text = Convert.ToString(Producto.Stock);
            TxtPrecio.Text = Convert.ToString(Producto.Precio);
        }
        private void Limpiar()
        {
            TxtIdProd.Text = "";
            TxtStock.Text = "";
            TxtPrecio.Text = "";
            CbxNombres.SelectedIndex = 0;
            TxtStock.ReadOnly = true;
            TxtPrecio.ReadOnly = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = false;
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Int32 nombre = Convert.ToInt32(CbxNombres.SelectedValue);
            producto.ELiminar(nombre);
            Limpiar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = true;
            TxtIdProd.ReadOnly = false;
            TxtStock.ReadOnly = false;
            TxtPrecio.ReadOnly = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            producto.IdProd = Convert.ToInt32(TxtIdProd.Text);
            producto.Stock = Convert.ToInt32(TxtStock.Text);
            producto.Precio = Convert.ToDecimal(TxtPrecio.Text);
            producto.Modificar(Convert.ToInt32(CbxNombres.SelectedValue));
            Limpiar();
        }

    }
}
