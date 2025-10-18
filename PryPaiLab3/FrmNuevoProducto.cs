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
    public partial class FrmNuevoProducto : Form
    {
        public FrmNuevoProducto()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            ClsProducto x = new ClsProducto();
            x.IdProd = Convert.ToInt32(TxtIdProd.Text);
            x.Nombre = TxtNom.Text;
            x.Stock = Convert.ToInt32(TxtStock.Text);
            x.Precio = Convert.ToDecimal(TxtPrecio.Text);
            x.Agregar();
            MessageBox.Show("Producto agregado correctamente");
            TxtIdProd.Text = "";
            TxtNom.Text = "";
            TxtStock.Text = "";
            TxtPrecio.Text = "";

        }
    }
}
