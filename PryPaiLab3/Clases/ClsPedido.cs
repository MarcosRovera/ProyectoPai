using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PryPaiLab3
{
    internal class ClsPedido
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadenaConexion = "Provider = Microsoft.JET.OLEDB.4.0; Data Source = BaseDatosPai.mdb";
        private string tabla = "Pedidos";
    }
}
