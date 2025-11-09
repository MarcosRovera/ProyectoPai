using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PryPaiLab3.Clases
{
    internal class ClsTotalPorCliente
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadenaConexion = "Provider = Microsoft.JET.OLEDB.4.0; Data Source = BaseDatosPai.mdb";
        

        public void Mostrar(DataGridView Grilla, Int32 Id, string sql)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                adaptador = new OleDbDataAdapter(comando);
                DataSet dataSet = new DataSet();
                adaptador.Fill(dataSet);
                Grilla.DataSource = null;
                Grilla.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }
    }
}
