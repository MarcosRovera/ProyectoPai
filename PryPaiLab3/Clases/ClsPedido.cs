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
using System.Drawing;
using System.Drawing.Printing;

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


                    sql = "UPDATE Productos SET Stock = Stock - " + aux.Cantidad + " WHERE IdProducto = " + aux.IdProducto;
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

        public void ImprimirPedido(PrintPageEventArgs Reporte)
        {
            try
            {
                OleDbConnection Conexion = new OleDbConnection();
                OleDbCommand Comando = new OleDbCommand();
                OleDbDataAdapter Adaptador = new OleDbDataAdapter();

                string CadenaConexion = "Provider = Microsoft.JET.OLEDB.4.0; Data Source = BaseDatosPai.mdb";
                string Tabla = "DetallePedido";
                Font LetraTitulo = new Font("Arial", 20);
                Font LetraSubtitulo = new Font("Arial", 14);
                Font LetraTexto = new Font("Arial", 11);


                Int32 linea = 200;
                Reporte.Graphics.DrawString("Detalle del Pedido", LetraTitulo, Brushes.Black, 250, 100);
                Reporte.Graphics.DrawString("ID Pedido: " + idPed.ToString(), LetraSubtitulo, Brushes.Black, 100, 150);
                Reporte.Graphics.DrawString("ID Cliente: " + idCli.ToString(), LetraSubtitulo, Brushes.Black, 100, 180);
                Reporte.Graphics.DrawString("Fecha: " + fecha.ToShortDateString(), LetraSubtitulo, Brushes.Black, 100, 210);
                linea += 100;

                Reporte.Graphics.DrawString("Id Producto", LetraTexto, Brushes.Black, 100, linea);
                Reporte.Graphics.DrawString("Cantidad", LetraTexto, Brushes.Black, 400, linea);
                linea += 30;
                Reporte.Graphics.DrawLine(Pens.Black, 100, linea, 500, linea);
                linea += 20;

                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                string sql = "SELECt IdProducto, Cantidad FROM DetallePedido WHERE IdPedido = " + idPed;
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = sql;

                OleDbDataReader Dr = Comando.ExecuteReader();

                while (Dr.Read())
                {
                    Reporte.Graphics.DrawString(Dr["IdProducto"].ToString(), LetraTexto, Brushes.Black, 100, linea);
                    Reporte.Graphics.DrawString(Dr["Cantidad"].ToString(), LetraTexto, Brushes.Black, 400, linea);
                    linea += 30;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir el pedido: " + ex.Message);

            }
        }

    }
}
