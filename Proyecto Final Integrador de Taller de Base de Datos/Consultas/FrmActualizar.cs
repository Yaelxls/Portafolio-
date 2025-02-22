using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Consultas
{
    public partial class FrmActualizar : Form
    {
        private float idEstablecimiento;

        public FrmActualizar(float id)
        {
            InitializeComponent();
            this.idEstablecimiento = id;
            CargarDatos();
        }

        public FrmActualizar()
        {
            InitializeComponent(); 
        }

        private void btnActualizarEstablecimiento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtClee.Text) ||
                string.IsNullOrWhiteSpace(txtNom_estab.Text) ||
                string.IsNullOrWhiteSpace(texFecha_alta.Text) ||
                string.IsNullOrWhiteSpace(txtPer_ocu.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo_act.Text))
            {
                MessageBox.Show("No se permiten datos vacios para (id, Clee, Nom_estab, Fecha_alta, Per_ocu y Codigo_act).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            using (SqlConnection conexion = new SqlConnection("server=LAPTOP-RVC8PUD8\\SQLEXPRESS; database=BD_Final; integrated security=true"))
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Establecimiento WHERE id = @id", conexion))
                    {
                        checkCmd.Parameters.AddWithValue("@id", Convert.ToSingle(txtId.Text));

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("ERROR: No se encontró el ID para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarEstablecimiento", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", Convert.ToSingle(txtId.Text));
                        cmd.Parameters.AddWithValue("@clee", txtClee.Text);
                        cmd.Parameters.AddWithValue("@nom_estab", txtNom_estab.Text);
                        cmd.Parameters.AddWithValue("@raz_social", string.IsNullOrWhiteSpace(txRaz_social.Text) ? (object)DBNull.Value : txRaz_social.Text);
                        cmd.Parameters.AddWithValue("@telefono", string.IsNullOrWhiteSpace(txtTelefono.Text) ? (object)DBNull.Value : Convert.ToSingle(txtTelefono.Text));
                        cmd.Parameters.AddWithValue("@www", string.IsNullOrWhiteSpace(txtWww.Text) ? (object)DBNull.Value : txtWww.Text);
                        cmd.Parameters.AddWithValue("@correoelec", string.IsNullOrWhiteSpace(txtCorreoelec.Text) ? (object)DBNull.Value : txtCorreoelec.Text);
                        cmd.Parameters.AddWithValue("@tipoUniEco", txtTipoUniEco.Text);
                        cmd.Parameters.AddWithValue("@fecha_alta", texFecha_alta.Text);
                        cmd.Parameters.AddWithValue("@codigo_act", Convert.ToSingle(txtCodigo_act.Text));
                        cmd.Parameters.AddWithValue("@per_ocu", txtPer_ocu.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Establecimiento actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el establecimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarDatos()
        {
            if (idEstablecimiento == null)
                return;

            string connectionString = "server=LAPTOP-RVC8PUD8\\SQLEXPRESS; database=BD_Final; integrated security=true";
            string query = "SELECT * FROM Establecimiento WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", idEstablecimiento);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            txtClee.Text = reader["clee"].ToString();
                            txtNom_estab.Text = reader["nom_estab"].ToString();
                            txRaz_social.Text = reader["raz_social"].ToString();
                            txtTelefono.Text = reader["telefono"].ToString();
                            txtWww.Text = reader["www"].ToString();
                            txtCorreoelec.Text = reader["correoelec"].ToString();
                            txtTipoUniEco.Text = reader["tipoUniEco"].ToString();
                            texFecha_alta.Text = reader["fecha_alta"].ToString();
                            txtCodigo_act.Text = reader["codigo_act"].ToString();
                            txtPer_ocu.Text = reader["per_ocu"].ToString();
                            txtId.Text = reader["id"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos: " + ex.Message);
                    }
                }
            }
        }
    } 
}
