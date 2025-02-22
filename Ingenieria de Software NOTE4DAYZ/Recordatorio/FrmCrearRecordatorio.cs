using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Net;

namespace NOTE4DAYZ.Recordatorio
{
    public partial class FrmCrearRecordatorio : Form
    {
  
        public FrmCrearRecordatorio()
        {
            InitializeComponent();

        }

        private void EnviarCorreo(string emailDestino, string tituloNota, DateTime fechaLimite, string nombreUsuario)
        {
            string mensaje = $"Hola {nombreUsuario}, este es un recordatorio de la nota \"{tituloNota}\". \nLa fecha límite es el {fechaLimite:dd/MM/yyyy}.";
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("notedayznoreply@gmail.com", "jgfn smkv kfsp qnva"),
                    EnableSsl = true
                };

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("notedayznoreply@gmail.com"),
                    Subject = "Recordatorio - NOTE4DAYZ",
                    Body = mensaje,
                    IsBodyHtml = false
                };

                mailMessage.To.Add(emailDestino);
                smtpClient.Send(mailMessage);
                MessageBox.Show("Correo enviado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}");
            }
        }


        private void comboBoxClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clasificacionSeleccionada = comboBoxClasificacion.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(clasificacionSeleccionada) || clasificacionSeleccionada == "Seleccionar Clasificación")
            {
                dataGridViewNotas.DataSource = null;
                return;
            }

            CargarNotasPorClasificacion(clasificacionSeleccionada);

        }
        private void CargarNotasPorClasificacion(string clasificacion)
        {
            string connectionString = SesionUsuario.CadenaConexion;
            string query = @"
        SELECT titulo AS [Título], fechaCreacion AS [Fecha de Creación], fechaLimite AS [Fecha Límite] 
        FROM Nota 
        WHERE clasificacion = @clasificacion AND id = @idUsuario"; 

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

                        dataGridViewNotas.DataSource = dataTable; 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar las notas: " + ex.Message);
                    }
                }
            }
        }
        private string ObtenerNombreUsuario()
        {
            string query = "SELECT nombre FROM Usuario WHERE id = @idUsuario";
            using (SqlConnection connection = new SqlConnection(SesionUsuario.CadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario);

                    try
                    {
                        connection.Open();
                        object resultado = command.ExecuteScalar();
                        if (resultado != null)
                        {
                            return resultado.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el nombre del usuario: " + ex.Message);
                    }
                }
            }
            return null;
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            if (dataGridViewNotas.SelectedRows.Count > 0)
            {
                string tituloSeleccionado = dataGridViewNotas.SelectedRows[0].Cells["Título"].Value.ToString();
                DateTime fechaLimite = Convert.ToDateTime(dataGridViewNotas.SelectedRows[0].Cells["Fecha Límite"].Value);

                int idNota = ObtenerIdNotaPorTitulo(tituloSeleccionado);
                if (idNota != -1)
                {
                    string emailUsuario = ObtenerCorreoUsuario();
                    string nombreUsuario = ObtenerNombreUsuario(); // Obtener el nombre del usuario
                    if (!string.IsNullOrEmpty(emailUsuario) && !string.IsNullOrEmpty(nombreUsuario))
                    {
                        EnviarCorreo(emailUsuario, tituloSeleccionado, fechaLimite, nombreUsuario);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener el correo o el nombre del usuario.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la nota seleccionada.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una nota antes de enviar el correo.");
            }

        }
        private string ObtenerCorreoUsuario()
        {

            string query = "SELECT email FROM Usuario WHERE id = @idUsuario";

            using (SqlConnection connection = new SqlConnection(SesionUsuario.CadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
            
                    command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario);

                    try
                    {
                        connection.Open();
                        object resultado = command.ExecuteScalar();
                        if (resultado != null)
                        {
                            return resultado.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el correo del usuario: " + ex.Message);
                    }
                }
            }

            return null; 
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
        private void CargarNotas()
        {
            string connectionString = SesionUsuario.CadenaConexion;
            string query = @"
        SELECT titulo AS [Título], fechaCreacion AS [Fecha de Creación], fechaLimite AS [Fecha Límite] 
        FROM Nota 
        WHERE id = @idUsuario"; // Filtra por el id del usuario

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario); // Usar el ID del usuario actual

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewNotas.DataSource = dataTable; // Mostrar notas filtradas
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar las notas: " + ex.Message);
                    }
                }
            }
        }

        private void FrmCrearRecordatorio_Load(object sender, EventArgs e)
        {
            CargarComboBoxClasificacion();
            CargarNotas();
            dataGridViewNotas.DataSource = null;

        }
        private int ObtenerIdNotaPorTitulo(string titulo)
        {
            string query = "SELECT idNota FROM Nota WHERE titulo = @titulo AND id = @idUsuario";

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

            return -1; 
        }
    }

}
