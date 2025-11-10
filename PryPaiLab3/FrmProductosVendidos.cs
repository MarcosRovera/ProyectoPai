using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace PryPaiLab3
{
    public partial class FrmProductosVendidos : Form
    {
        private OleDbConnection connexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string Cadenaconexion = "Provider = Microsoft.JET.OLEDB.4.0; Data Source = BaseDatosPai.mdb";

        public FrmProductosVendidos()
        {
            InitializeComponent();
        }

        private void FrmProductosVendidos_Load(object sender, EventArgs e)
        {
            CargarGrafico();
        }

        private void CargarGrafico()
        {
            try
            {
                
                ChartVentas.Series.Clear();
                ChartVentas.Titles.Clear();
                ChartVentas.Legends.Clear();

                ChartVentas.Titles.Add("Productos mas vendidos");
                ChartVentas.Titles[0].Font = new Font("Showcard Gothic", 16, FontStyle.Bold);

                Series serie = new Series("Ventas");
                serie.ChartType = SeriesChartType.Column; 
                serie.Color = Color.Red;
                serie.IsValueShownAsLabel = true; 

                DataTable datos = ObtenerDatos();

                if (datos.Rows.Count > 0)
                {
                    foreach (DataRow fila in datos.Rows)
                    {
                        string nombre = fila["Nombre"].ToString();
                        int cantidad = Convert.ToInt32(fila["Total"]);
                        serie.Points.AddXY(nombre, cantidad);
                    }
                }
                else
                {
                    MessageBox.Show("No hay ventas registradas");
                }

                ChartVentas.Series.Add(serie);

                ChartVentas.ChartAreas[0].AxisX.Title = "Productos";
                ChartVentas.ChartAreas[0].AxisY.Title = "Cantidad Vendida";
                ChartVentas.ChartAreas[0].AxisX.Interval = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfico: " + ex.Message);
            }
        }

        private DataTable ObtenerDatos()
        {
            DataTable tabla = new DataTable();
            try
            {
                connexion.ConnectionString = Cadenaconexion;
                connexion.Open();

                string sql = "SELECT Productos.Nombre, SUM(DetallePedido.Cantidad) AS Total " +
                             "FROM Productos INNER JOIN DetallePedido ON Productos.IdProducto = DetallePedido.IdProducto " +
                             "GROUP BY Productos.Nombre ORDER BY SUM(DetallePedido.Cantidad) DESC";

                comando.Connection = connexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tabla);

                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (connexion.State == ConnectionState.Open)
                    connexion.Close();
            }
            return tabla;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrafico();
            MessageBox.Show("Gráfico actualizado");
        }
    }
}
