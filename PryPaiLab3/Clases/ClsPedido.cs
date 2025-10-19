using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using PryPaiLab3.Clases;

namespace PryPaiLab3
{
    internal class ClsPedido
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadenaConexion = "Provider = Microsoft.JET.OLEDB.4.0; Data Source = BaseDatosPai.mdb";
        private string tabla = "Pedido";

        private Int32 idPed;
        private Int32 idCli;
        private DateTime fecha;

        public Int32 IdPed
        {
            get { return idPed; }
            set { idPed = value; }
        }
        public Int32 IdCli
        {
            get { return idCli; }
            set { idCli = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public void Guardar(ClsPilaPedidos pila)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                string fechaFormato = fecha.ToString("yyyy-MM-dd");
                string sql = "INSERT INTO Pedido (IdCliente, Fecha) VALUES (" + idCli + ", #" + fechaFormato + "#)";
                //string sql = "INSERT INTO " + tabla + " (IdCliente, Fecha) VALUES (@IdPedido, @IdCliente, @Fecha)";
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                comando.CommandText = "SELECT MAX(IdPedido) FROM " + tabla;
                idPed = Convert.ToInt32(comando.ExecuteScalar());

                ClsNodo aux = pila.Primero;
                while (aux != null)
                {
                    sql = "INSERT INTO DetallePedido (IdPedido, IdProducto, Cantidad) VALUES (" + idPed + "," + aux.IdProducto + ", " + aux.Cantidad + ")";
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    aux = aux.Siguiente;
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pedido: " + ex.Message);
            }
        }

    }
}
