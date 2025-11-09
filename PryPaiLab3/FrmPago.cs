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
    public partial class FrmPago : Form
    {
        ClsPago pago = new ClsPago();
        Decimal totalPedido;
        Decimal totalPagado;
        public FrmPago()
        {
            InitializeComponent();
            

        }
        

        private void FrmPago_Load(object sender, EventArgs e)
        {
            ClsCliente cliente = new ClsCliente();
            cliente.Buscar(CbxNombres);

            LstFecha.DisplayMember = "Fecha";
            LstFecha.ValueMember = "IdPedido";

        }

        private void CbxNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView fila = (DataRowView)CbxNombres.SelectedItem;
            Int32 idCliente = Convert.ToInt32(fila["IdCliente"]);
            DataTable pedidos = pago.BuscarPorFecha(idCliente);
            LstFecha.DataSource = pedidos;

        }

        private void LstFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView fila = (DataRowView)LstFecha.SelectedItem;
            Int32 idPedido = Convert.ToInt32(fila["IdPedido"]);
            totalPedido = pago.TotalPedido(idPedido);
            LblTotal.Text = totalPedido.ToString("C2");
            totalPagado = pago.TotalPagado(idPedido);
            LblMontoPagado.Text = totalPagado.ToString("C2");
            decimal saldo = totalPedido - totalPagado;
            LblSaldo.Text = saldo.ToString("C2");

            TxtMonto.Enabled = true;
            TxtMonto.ReadOnly = false;

        }

        private void TxtMonto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal Monto = Convert.ToDecimal(TxtMonto.Text);
                decimal NuevoSaldo = totalPedido - totalPagado - Monto;
                LblSaldo.Text = NuevoSaldo.ToString("C2");
            }
            catch 
            {

                LblSaldo.Text = "0.00";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            decimal Monto = Convert.ToDecimal(TxtMonto.Text);
            if (Monto <= 0)
            {
                MessageBox.Show("El monto a pagar debe ser mayor a cero.");
                return;
            }
            Decimal saldo = totalPedido - totalPagado;
            if (Monto > saldo)
            {
                MessageBox.Show("El monto a pagar no puede ser mayor al saldo pendiente.");
                return;
            }
            pago.idPed = Convert.ToInt32(LstFecha.SelectedValue);
            pago.fechaPago = DateTime.Now;
            pago.monto = Monto;
            pago.GuardarPago();

            MessageBox.Show("Pago registrado con éxito.");
        }
    }
}
