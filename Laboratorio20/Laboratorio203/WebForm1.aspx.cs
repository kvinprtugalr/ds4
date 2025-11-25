using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio203
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        bool nuevo
        {
            get { return (bool)(ViewState["nuevo"] ?? false); }
            set { ViewState["nuevo"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ResetForm();
            }
        }

        protected void tsbNuevo_Click(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = false;

            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;

            nuevo = true;

        }

        protected void tsbGuardar_Click(object sender, EventArgs e)
        {

            ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["ConexionProductos"];
            SqlConnection conexion = new SqlConnection(connString.ConnectionString);

                try
                {
                    conexion.Open();

                    string sql = nuevo
                        ? "INSERT INTO Laptops (NOMBRE, PRECIO, STOCK) VALUES (@NOMBRE, @PRECIO, @STOCK)"
                        : "UPDATE Laptops SET NOMBRE=@NOMBRE, PRECIO=@PRECIO, STOCK=@STOCK WHERE ID=@ID";

                    SqlCommand cmd = new SqlCommand(sql, conexion);

                    cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@PRECIO", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@STOCK", txtStock.Text);

                    if (!nuevo)
                        cmd.Parameters.AddWithValue("@ID", txtId.Text);

                    int i = cmd.ExecuteNonQuery();

                    lblMensaje.Text = nuevo ? "Registro ingresado correctamente!" : "Registro actualizado correctamente!";
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
                finally
                {
                    conexion.Close();
                }

                ResetForm();

            
        }

        protected void tsbCancelar_Click(object sender, EventArgs e)
        {
            ResetForm();
            lblMensaje.Text = "Operación cancelada.";

        }

        protected void tsbEliminar_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["ConexionProductos"];
            SqlConnection conexion = new SqlConnection(connString.ConnectionString);


                try
                {
                    conexion.Open();

                    string sql = "DELETE FROM Laptops WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@ID", txtId.Text);

                    int i = cmd.ExecuteNonQuery();
                    lblMensaje.Text = "Registro eliminado correctamente!";
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
                finally
                {
                    conexion.Close();
                }

                ResetForm();

        }

        protected void tsbBuscar_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["ConexionProductos"];
            SqlConnection conexion = new SqlConnection(connString.ConnectionString);

            try
            {
                conexion.Open();

                string sql = "SELECT * FROM Laptops WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@ID", tstId.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = reader[0].ToString();
                    txtNombre.Text = reader[1].ToString();
                    txtPrecio.Text = reader[2].ToString();
                    txtStock.Text = reader[3].ToString();

                    nuevo = false;

                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    tsbEliminar.Enabled = true;

                    txtNombre.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;

                    lblMensaje.Text = "Registro encontrado.";
                }
                else
                {
                    lblMensaje.Text = "No se encontró el registro.";
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
            finally
            {
                conexion.Close();
            }

            tstId.Text = "";

        }
        private void ResetForm()
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;

            txtId.Enabled = true;
            tsbBuscar.Enabled = true;

            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;

            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx"); // o cualquier página

        }
    }
}