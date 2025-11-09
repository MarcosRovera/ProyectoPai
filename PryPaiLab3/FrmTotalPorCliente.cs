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
    public partial class FrmTotalPorCliente : Form
    {
        public FrmTotalPorCliente()
        {
            InitializeComponent();
        }

        private void FrmTotalPorCliente_Load(object sender, EventArgs e)
        {
            DgvTotalPorPedido.AutoGenerateColumns = false;
            ColPedido.DataPropertyName = "IdPedido";
            ColFecha.DataPropertyName = "Fecha";
            ColTotal.DataPropertyName = "TotalPedido";
            ColTotalPagado.DataPropertyName = "TotalPagado";
            ColSaldo.DataPropertyName = "Saldo";
            ClsCliente cliente = new ClsCliente();
            cliente.Buscar(CbxNombres);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClsTotalPorCliente BD = new ClsTotalPorCliente();

            int idCliente = Convert.ToInt32(CbxNombres.SelectedValue);

            string sql =
                "SELECT " +
                "    P.IdPedido, " +
                "    P.Fecha, " +
                "    T.Total AS TotalPedido, " +
                "    IIf(PG.TotalPagado Is Null, 0, PG.TotalPagado) AS TotalPagado, " +
                "    (T.Total - IIf(PG.TotalPagado Is Null, 0, PG.TotalPagado)) AS Saldo " +
                "FROM " +
                "    (Pedido AS P INNER JOIN TotalesPorPedido AS T ON P.IdPedido = T.IdPedido) " +
                "     LEFT JOIN ( SELECT IdPedido, SUM(MontoPago) AS TotalPagado FROM Pagos " +
                "        GROUP BY IdPedido ) AS PG ON P.IdPedido = PG.IdPedido " +
                "WHERE P.IdCliente = " + idCliente + " " +
                "ORDER BY P.Fecha DESC;";

            BD.Mostrar(DgvTotalPorPedido, idCliente, sql);
            CargarTotales();
        }

        private void CargarTotales()
        {
            decimal totalPedidos = 0;
            decimal totalPagado = 0;
            decimal saldoTotal = 0;
            foreach (DataGridViewRow fila in DgvTotalPorPedido.Rows)
            {
                totalPedidos += Convert.ToDecimal(fila.Cells["ColTotal"].Value);
                totalPagado += Convert.ToDecimal(fila.Cells["ColTotalPagado"].Value);
                saldoTotal += Convert.ToDecimal(fila.Cells["ColSaldo"].Value);
            }
            LblTotal.Text = totalPedidos.ToString("C");
            LblPagado.Text = totalPagado.ToString("C");
            LblSaldo.Text = saldoTotal.ToString("C");
        }
    }
}
