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

namespace NOTE4DAYZ.Nota
{
    public partial class FrmModiFecha : Form
    {
        private int idNotaSeleccionada = -1; 

        public FrmModiFecha()
        {
            InitializeComponent();
  
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
            comboBoxClasificacion.SelectedIndex = 0; // Seleccionar la opción inicial
        }

        private void CargarNotas()
        {
            string connectionString = SesionUsuario.CadenaConexion;
            string query = "SELECT idNota, titulo AS [Título], fechaCreacion AS [Fecha de Creación], fechaLimite AS [Fecha Límite] " +
                           "FROM Nota WHERE id = @idUsuario"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario);

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewNotas.DataSource = dataTable; // Asigna los datos filtrados al DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar las notas: " + ex.Message);
                    }
                }
            }
        }

        private void FrmModiFecha_Load(object sender, EventArgs e)
        {
            CargarComboBoxClasificacion();
            dataGridViewNotas.DataSource = null;


        }

        private void dataGridViewNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que no sea un encabezado
            {
                DataGridViewRow row = dataGridViewNotas.Rows[e.RowIndex];
                string tituloNota = row.Cells["Título"].Value.ToString();

                idNotaSeleccionada = ObtenerIdNotaPorTitulo(tituloNota); 
                if (row.Cells["Fecha Límite"].Value != DBNull.Value)
                {
                    dateTimePickerFechaLimite.Value = Convert.ToDateTime(row.Cells["Fecha Límite"].Value);
                }
                else
                {
                    dateTimePickerFechaLimite.Value = DateTime.Now; // Si no hay fecha límite, asigna la fecha actual
                }
            }
        }
        private int ObtenerIdNotaPorTitulo(string titulo)
        {
            string query = "SELECT idNota FROM Nota WHERE titulo = @titulo AND id = @idUsuario"; // Filtrar también por idUsuario

            using (SqlConnection connection = new SqlConnection(SesionUsuario.CadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@titulo", titulo);
                    command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario);

                    connection.Open();

                    object resultado = command.ExecuteScalar();
                    if (resultado != null)
                    {
                        return Convert.ToInt32(resultado);
                    }
                }
            }

            return -1; // Retorna -1 si no se encuentra
        }
        private void GuardarFechaLimite(int idNota, DateTime nuevaFechaLimite)
        {
            string connectionString = SesionUsuario.CadenaConexion;
            string query = "UPDATE Nota SET fechaLimite = @fechaLimite WHERE idNota = @idNota";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fechaLimite", nuevaFechaLimite);
                    command.Parameters.AddWithValue("@idNota", idNota);

                    try
                    {
                        connection.Open();
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Fecha límite actualizada exitosamente.");
                            CargarNotas(); // Recarga el DataGridView para reflejar los cambios
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la fecha límite.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la fecha límite: " + ex.Message);
                    }
                }
            }
        }

        private void btnGuardarFechaLimite_Click(object sender, EventArgs e)
        {
            if (idNotaSeleccionada > 0) // Asegúrate de que haya una nota seleccionada
            {
                DateTime nuevaFechaLimite = dateTimePickerFechaLimite.Value; // Obtén la nueva fecha límite
                GuardarFechaLimite(idNotaSeleccionada, nuevaFechaLimite);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una nota para modificar la fecha límite.");
            }
        }

        private void comboBoxClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clasificacionSeleccionada = comboBoxClasificacion.SelectedItem?.ToString();

            // Si la clasificación es "Seleccionar Clasificación" o está vacía, no cargar notas
            if (string.IsNullOrEmpty(clasificacionSeleccionada) || clasificacionSeleccionada == "Seleccionar Clasificación")
            {
                dataGridViewNotas.DataSource = null; // Limpia el DataGridView
                return;
            }

            // Cargar notas por clasificación
            CargarNotasPorClasificacion(clasificacionSeleccionada);
        }
        private void CargarNotasPorClasificacion(string clasificacion)
        {
            string connectionString = SesionUsuario.CadenaConexion;
            string query = "SELECT idNota, titulo AS [Título], fechaCreacion AS [Fecha de Creación], fechaLimite AS [Fecha Límite] " +
                           "FROM Nota WHERE clasificacion = @clasificacion AND id = @idUsuario"; // Filtrar también por idUsuario

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@clasificacion", clasificacion);
                    command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario);

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewNotas.DataSource = dataTable; // Asigna los datos filtrados al DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar las notas: " + ex.Message);
                    }
                }
            }
        }

    }
}
