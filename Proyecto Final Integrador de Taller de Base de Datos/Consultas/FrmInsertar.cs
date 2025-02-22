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

namespace Proyecto_Final.Formularios
{
    public partial class FrmInsertar : Form
    {
        public FrmInsertar()
        {
            InitializeComponent();
        }

        private void btnInsertarEstablecimiento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
        string.IsNullOrWhiteSpace(txtClee.Text) ||
        string.IsNullOrWhiteSpace(txtNom_estab.Text) ||
        string.IsNullOrWhiteSpace(texFecha_alta.Text) ||
        string.IsNullOrWhiteSpace(txtPer_ocu.Text) ||
        string.IsNullOrWhiteSpace(txtCodigo_act.Text))
            {
                MessageBox.Show("No se permiten datos vacíos para (id, Clee, Nom_estab, Fecha_alta, Per_ocu y Codigo_act).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        if (count > 0)
                        {
                            MessageBox.Show("ERROR: El ID del establecimiento ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarEstablecimiento", conexion))
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

                        MessageBox.Show("Establecimiento insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el establecimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
