using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PryPaiLab3
{
    internal class ClsCliente
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadenaConexion = "Provider = Microsoft.JET.OLEDB.4.0; Data Source = BaseDatosPai.mdb";
        private string tabla = "cliente";

        private Int32 idCli;
        private string nom;
        private string direcc;
        private string numero;

        public Int32 IdCli1
        {
            get { return idCli; }
            set { idCli = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Direcc
        {
            get { return direcc; }
            set { direcc = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                OleDbDataReader Dr = comando.ExecuteReader();
                Grilla.Rows.Clear();

                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        {
                            Grilla.Rows.Add(Dr.GetString(1), Dr.GetString(2), Dr.GetString(3));

                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al listar los clientes " + e.ToString());
            }
        }
        public void Agregar()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, tabla);
                DataTable dataTable = DS.Tables[tabla];
                DataRow fila = dataTable.NewRow();
                fila["Nombre"] = nom;
                fila["Direccion"] = direcc;
                fila["numero"] = numero;
                dataTable.Rows.Add(fila);
                OleDbCommandBuilder Cambios = new
                OleDbCommandBuilder(adaptador);
                adaptador.Update(DS, tabla);
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al agregar el cliente " + e.ToString());
            }
        }
        //------------------------------ buscar cliente ------------------------------
        public void Buscar(System.Windows.Forms.ComboBox combo)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, tabla);
                combo.DataSource = ds.Tables[tabla];
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "IdCliente";
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void BuscarNombre(Int32 c)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                OleDbDataReader Dr = comando.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        if (Dr.GetInt32(0) == c)
                        {

                            direcc = Dr.GetString(2);
                            numero = Dr.GetString(3);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Modificar(int x)
        {
            try
            {
                string sql = "";
                sql = "UPDATE cliente SET ";
                sql += "direccion = '" + direcc + "', ";
                sql += "numero= " + numero + " ";

                sql += " WHERE IdCliente = " + x.ToString();

                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                conexion.Close();
                MessageBox.Show("Cliente Modificado Correctamente!!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void ELiminar(Int32 x)
        {
            try
            {
                string sql = "";
                sql = "DELETE * FROM cliente WHERE IdCliente = " + x.ToString();
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Cliente Eliminado Correctamente!!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
