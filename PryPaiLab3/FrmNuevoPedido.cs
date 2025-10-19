using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PryPaiLab3.Clases;

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
        ClsPedido pedido = new ClsPedido();
        ClsPilaPedidos pila = new ClsPilaPedidos();

        private void FrmNuevoPedido_Load(object sender, EventArgs e)
        {
            cliente.Buscar(CbxNombres);
            producto.CargarCbxNombres(CbxProducto);

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DataRowView fila = (DataRowView)CbxProducto.SelectedItem;
            ClsNodo nuevo = new ClsNodo();
            nuevo.IdProducto = Convert.ToInt32(fila["IdProducto"]);
            nuevo.Nombre = fila["Nombre"].ToString();
            nuevo.Precio = Convert.ToDecimal(fila["PrecioUnitario"]);
            nuevo.Cantidad = Convert.ToInt32(NudCantidad.Value);
            nuevo.Subtotal = nuevo.Precio * nuevo.Cantidad;

            pila.Agregar(nuevo);
            pila.Recorrer(DgvProductos);

            LblTotal.Text = pila.CalcularTotal().ToString();
            MessageBox.Show("Producto agregado al pedido");
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (pila.Primero != null)
            {
                pila.Eliminar();
                pila.Recorrer(DgvProductos);
                LblTotal.Text = pila.CalcularTotal().ToString();
                MessageBox.Show("Producto eliminado del pedido");
            }
            else
            {
                MessageBox.Show("No hay productos para eliminar");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            pedido.IdCli = Convert.ToInt32(CbxNombres.SelectedValue);
            pedido.Fecha = DtpFecha.Value;
            pedido.Guardar(pila);
            MessageBox.Show("Pedido guardado correctamente");
            Limpiar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            NudCantidad.Value = 1;
            DgvProductos.Rows.Clear();
            LblTotal.Text = "0";
            pila.Primero = null;
        }
    }
}
