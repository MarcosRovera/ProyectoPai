using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace PryPaiLab3
{
    internal class ClsProducto
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadenaConexion = "Provider = Microsoft.JET.OLEDB.4.0; Data Source = BaseDatosPai.mdb";
        private string tabla = "Productos";

        private Int32 idProd;
        private string nom;
        private Int32 stock;
        private decimal precio;
        public Int32 IdProd
        {
            get { return idProd; }
            set { idProd = value; }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public Int32 Stock
        {
            get { return stock; }
            set { stock = value; }
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
                            Grilla.Rows.Add(Dr.GetInt32(0),Dr.GetString(1), Dr.GetInt32(2), Dr.GetDecimal(3));

                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al listar los productos " + e.ToString());
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
                fila["IdProducto"] = idProd;
                fila["Nombre"] = nom;
                fila["Stock"] = stock;
                fila["PrecioUnitario"] = precio;
                dataTable.Rows.Add(fila);
                OleDbCommandBuilder Cambios = new
                OleDbCommandBuilder(adaptador);
                adaptador.Update(DS, tabla);
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al agregar el producto " + e.ToString());
            }
        }
        public void CargarCbxNombres(ComboBox combo)
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
                combo.ValueMember = "IdProducto";
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
                            idProd = Dr.GetInt32(0);
                            stock = Dr.GetInt32(2);
                            precio = Dr.GetDecimal(3);
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
                sql = "UPDATE Productos SET ";
                sql += "IdProducto = '" + idProd + "', ";
                sql += "Stock = '" + stock + "', ";
                sql += "PrecioUnitario = " + precio + " ";

                sql += " WHERE IdProducto = " + x.ToString();

                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                conexion.Close();
                MessageBox.Show("Producto Modificado Correctamente!!");
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
                sql = "DELETE * FROM Productos WHERE IdProducto = " + x.ToString();
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Producto Eliminado Correctamente!!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
