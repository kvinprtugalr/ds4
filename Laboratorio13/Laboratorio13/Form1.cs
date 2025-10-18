using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;



namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=.;Database=Northwind;TrustServerCertificate=True;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectarSQL_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

            string query = "SELECT ProductName FROM Products";
            SqlCommand comando = new SqlCommand(query, conexion);

            // Ejecutar y leer resultados
            SqlDataReader reader = comando.ExecuteReader();

            // Limpiar el ListBox antes de llenarlo
            listProducts.Items.Clear();

            // Leer los datos fila por fila
            while (reader.Read())
            {
                listProducts.Items.Add(reader["ProductName"].ToString());
            }

            reader.Close();
            conexion.Close();
            MessageBox.Show("Se cerró la conexión");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
