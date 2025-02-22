using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTE4DAYZ.Nota
{
    public partial class FrmEliminarNota : Form
    {
        public FrmEliminarNota()
        {
            InitializeComponent();
        }

        private void FrmEliminarNota_Load(object sender, EventArgs e)
        {
            CargarComboBoxClasificacion();

        }
        private void CargarComboBoxNotas()
        {
            string clasificacionSeleccionada = comboBoxClasificacion.SelectedItem?.ToString();
            DataTable notas = ObtenerNotas(clasificacionSeleccionada);

            if (notas.Rows.Count > 0)
            {
                notas.Columns.Add("tituloConFecha", typeof(string));
                foreach (DataRow row in notas.Rows)
                {
                    DateTime fechaLimite = row["fechaLimite"] != DBNull.Value
                        ? Convert.ToDateTime(row["fechaLimite"])
                        : DateTime.MinValue;
                    row["tituloConFecha"] = $"{row["titulo"]} (Límite: {(fechaLimite != DateTime.MinValue ? fechaLimite.ToString("dd/MM/yyyy") : "Sin Fecha")})";
                }

                comboBoxNotas.DataSource = notas;
                comboBoxNotas.DisplayMember = "tituloConFecha"; 
                comboBoxNotas.ValueMember = "idNota"; 

                if (notas.Rows.Count > 0)
                {
                    comboBoxNotas.SelectedIndex = 0;
                    MostrarContenidoNota(Convert.ToInt32(comboBoxNotas.SelectedValue)); 
                }
                else
                {
                    richTxtContenido.Clear(); 
                }
            }
            else
            {
                comboBoxNotas.DataSource = null;
                richTxtContenido.Clear(); 
            }
        }

        private void CargarComboBoxClasificacion()
        {
            List<string> clasificaciones = new List<string>
    {
        "Seleccionar Clasificación",
        "Personal",
        "Trabajo",
        "Estudios",
        "Importante",
        "Otro"
    };

            comboBoxClasificacion.DataSource = clasificaciones;
            comboBoxClasificacion.SelectedIndex = 0; 
        }

        private DataTable ObtenerNotas(string clasificacion = null)
        {
            string connectionString = SesionUsuario.CadenaConexion;
            string query = "SELECT idNota, titulo, contenido, fechaLimite FROM Nota WHERE id = @idUsuario";

            if (!string.IsNullOrEmpty(clasificacion) && clasificacion != "Seleccionar Clasificación")
            {
                query += " AND clasificacion = @clasificacion";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario); 

                    if (!string.IsNullOrEmpty(clasificacion) && clasificacion != "Seleccionar Clasificación")
                    {
                        command.Parameters.AddWithValue("@clasificacion", clasificacion);
                    }

                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        private void MostrarContenidoNota(int idNota)
        {
            string connectionString = SesionUsuario.CadenaConexion;
            string query = "SELECT contenido FROM Nota WHERE idNota = @idNota AND id = @idUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idNota", idNota);
                    command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario); 

                    connection.Open();
                    object resultado = command.ExecuteScalar();

                    if (resultado != null)
                    {
                        richTxtContenido.Rtf = resultado.ToString(); 
                    }
                    else
                    {
                        richTxtContenido.Clear();
                    }
                }
            }
        }

        private void EliminarNota(int idNota)
        {
            string connectionString = SesionUsuario.CadenaConexion;
            string query = "DELETE FROM Nota WHERE idNota = @idNota AND id = @idUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idNota", idNota);
                    command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario); 

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Nota eliminada exitosamente.");
                        CargarComboBoxNotas(); // Recargar notas después de eliminar

                
                        if (comboBoxNotas.Items.Count > 0)
                        {
                            comboBoxNotas.SelectedIndex = 0; 
                            MostrarContenidoNota(Convert.ToInt32(comboBoxNotas.SelectedValue)); 
                        }
                        else
                        {
                            richTxtContenido.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al eliminar la nota.");
                    }
                }
            }
        }

        private void comboBoxClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clasificacionSeleccionada = comboBoxClasificacion.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(clasificacionSeleccionada) && clasificacionSeleccionada != "Seleccionar Clasificación")
            {
                CargarComboBoxNotas(); 
            }
            else
            {
                comboBoxNotas.DataSource = null; // Limpiar el ComboBox de notas
            }
        }

        private void comboBoxNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNotas.SelectedItem != null)
            {
                // Obtener la fila seleccionada como DataRowView
                DataRowView selectedRow = (DataRowView)comboBoxNotas.SelectedItem;

                // Acceder al valor de la columna 'idNota' de la fila seleccionada
                int idNotaSeleccionada = Convert.ToInt32(selectedRow["idNota"]);

                // Mostrar el contenido de la nota
                MostrarContenidoNota(idNotaSeleccionada);
            }
            else
            {
                richTxtContenido.Clear(); // Limpiar el contenido si no hay selección
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxNotas.SelectedValue != null)
            {
                int idNotaSeleccionada = Convert.ToInt32(comboBoxNotas.SelectedValue);
                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta nota?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    EliminarNota(idNotaSeleccionada);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una nota para eliminar.");
            }

        }
    }
}
