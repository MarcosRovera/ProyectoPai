using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Threading.Tasks;

namespace PryPaiLab3.Clases
{
    internal class ClsPago
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadenaConexion = "Provider = Microsoft.JET.OLEDB.4.0; Data Source = BaseDatosPai.mdb";
        private string tabla = "Pagos";

        public Int32 idPago;
        public Int32 idPed;
        public DateTime fechaPago;
        public decimal monto;

        public Int32 IdPago
        {
            get { return idPago; }
            set { idPago = value; }
        }
        public Int32 IdPed
        {
            get { return idPed; }
            set { idPed = value; }
        }
        public DateTime FechaPago
        {
            get { return fechaPago; }
            set { fechaPago = value; }
        }
        public decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public DataTable BuscarPorFecha(Int32 Id)
        {
            DataTable tabla = new DataTable();
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                string sql = "SELECT IdPedido, Fecha FROM Pedido  WHERE IdCliente = " + Id;
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tabla);
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al mostrar Pedidos" + e.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return tabla;
        }

        public decimal TotalPedido(Int32 id)
        {
            decimal total = 0;
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                string sql = "SELECT Total FROM TotalesPorPedido WHERE IdPedido = " + id;
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                object result = comando.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    total = Convert.ToDecimal(result);
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al calcular total pagado" + e.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return total;
        }

        public decimal TotalPagado(Int32 id)
        {
            decimal totalPagado = 0;
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                string sql = "SELECT SUM(MontoPago) AS Pagado FROM Pagos WHERE IdPedido = " + id;
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                object result = comando.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalPagado = Convert.ToDecimal(result);
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al calcular total pagado" + e.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return totalPagado;
        }

        public void GuardarPago()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                string fechaFormato = fechaPago.ToString("yyyy-MM-dd");
                string sql = "INSERT INTO Pagos (IdPedido, FechaPago, MontoPago) VALUES (" + idPed + ", #" + fechaFormato + "#, " + monto + ")";
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar el pago: " + e.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
    }
}
