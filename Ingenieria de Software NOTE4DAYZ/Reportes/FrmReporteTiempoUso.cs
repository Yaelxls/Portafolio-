using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace NOTE4DAYZ.Reportes
{
    public partial class FrmReporteTiempoUso : Form
    {
        public FrmReporteTiempoUso()
        {
            InitializeComponent();
        }

        private string GenerarReporteTiempoUso(int idUsuario)
        {
            string connectionString = SesionUsuario.CadenaConexion;
            string query = @"
SELECT fechaInicio, fechaFin, tiempoTotal 
FROM Reporte 
WHERE id = @id
ORDER BY fechaInicio DESC";

            StringBuilder reporte = new StringBuilder();
            reporte.AppendLine("Reporte de Tiempo de Uso de la Aplicación:");
            reporte.AppendLine("------------------------------------------------------");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", idUsuario);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime fechaInicio = Convert.ToDateTime(reader["fechaInicio"]);
                                DateTime? fechaFin = reader["fechaFin"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["fechaFin"]) : null;
                                int? tiempoTotal = reader["tiempoTotal"] != DBNull.Value ? (int?)Convert.ToInt32(reader["tiempoTotal"]) : null;

                                reporte.AppendLine($"Fecha de Inicio: {fechaInicio:dd/MM/yyyy HH:mm}");
                                if (fechaFin != null)
                                {
                                    reporte.AppendLine($"Fecha de Fin: {fechaFin:dd/MM/yyyy HH:mm}");
                                    reporte.AppendLine($"Tiempo Total: {tiempoTotal} minutos");
                                }
                                else
                                {
                                    reporte.AppendLine("Sesión activa");
                                }
                                reporte.AppendLine("------------------------------------------------------");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el reporte de tiempo de uso: " + ex.Message);
                    }
                }
            }

            return reporte.ToString();
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

        private void EnviarCorreo(string emailDestino, string mensaje)
        {
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
                    Subject = "Reporte - NOTE4DAYZ",
                    Body = mensaje,
                    IsBodyHtml = false
                };

                mailMessage.To.Add(emailDestino);
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}");
            }
        }

        private void EnviarReporteTiempoUso()
        {
            string emailDestino = ObtenerCorreoUsuario();
            if (string.IsNullOrEmpty(emailDestino))
            {
                MessageBox.Show("No se encontró el correo electrónico del usuario.");
                return;
            }

            string reporte = GenerarReporteTiempoUso(SesionUsuario.IdUsuario);
            if (string.IsNullOrEmpty(reporte))
            {
                MessageBox.Show("No se encontraron registros de tiempo de uso.");
                return;
            }

            try
            {
                EnviarCorreo(emailDestino, reporte);
                MessageBox.Show("Reporte  enviado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el reporte: {ex.Message}");
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            EnviarReporteTiempoUso();
        }
        private void CargarGraficaTiempoUso(int idUsuario)
        {
            // Cadena de conexión
            string connectionString = SesionUsuario.CadenaConexion;

            // Consulta SQL
            string query = @"
    SELECT fechaInicio, tiempoTotal
    FROM Reporte
    WHERE id = @id
    ORDER BY fechaInicio ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", idUsuario);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Inicializar el gráfico
                        InicializarGrafico();

                        // Crear serie y agregar puntos
                        Series serie = CrearSerie("Tiempo de Uso");
                        while (reader.Read())
                        {
                            DateTime fechaInicio = Convert.ToDateTime(reader["fechaInicio"]);
                            int tiempoTotal = reader["tiempoTotal"] != DBNull.Value ? Convert.ToInt32(reader["tiempoTotal"]) : 0;
                            serie.Points.AddXY(fechaInicio, tiempoTotal);
                        }

                        // Agregar serie al gráfico
                        chartTiempoUso.Series.Add(serie);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la gráfica de tiempo de uso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Inicializa el gráfico limpiando áreas, series y leyendas
        private void InicializarGrafico()
        {
            chartTiempoUso.Series.Clear();
            chartTiempoUso.ChartAreas.Clear();
            chartTiempoUso.Legends.Clear();
            chartTiempoUso.Titles.Clear();

            // Configurar área del gráfico
            ChartArea area = new ChartArea
            {
                Name = "TiempoDeUsoArea",
                BackColor = Color.WhiteSmoke,
                BorderColor = Color.LightGray,
                ShadowColor = Color.Gray
            };

            // Configurar ejes
            ConfigurarEjeX(area.AxisX);
            ConfigurarEjeY(area.AxisY);

            // Agregar área al gráfico
            chartTiempoUso.ChartAreas.Add(area);

            // Configurar leyenda
            Legend legend = new Legend
            {
                Name = "TiempoDeUsoLegend",
                Docking = Docking.Top,
                Alignment = StringAlignment.Center,
                Font = new Font("Segoe UI", 9),
                BackColor = Color.Transparent
            };
            chartTiempoUso.Legends.Add(legend);

            // Agregar título
            Title titulo = new Title
            {
                Text = "Tiempo de Uso por Sesión",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Docking = Docking.Top
            };
            chartTiempoUso.Titles.Add(titulo);
        }

        // Configura las propiedades del eje X
        private void ConfigurarEjeX(Axis ejeX)
        {
            ejeX.Title = "Fecha y Hora";
            ejeX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            ejeX.LabelStyle.Format = "dd/MM/yyyy\nHH:mm";
            ejeX.LabelStyle.Font = new Font("Segoe UI", 9);
            ejeX.MajorGrid.LineColor = Color.LightGray;
            ejeX.IntervalAutoMode = IntervalAutoMode.VariableCount;
        }

        // Configura las propiedades del eje Y
        private void ConfigurarEjeY(Axis ejeY)
        {
            ejeY.Title = "Tiempo de Uso (minutos)";
            ejeY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            ejeY.LabelStyle.Font = new Font("Segoe UI", 9);
            ejeY.MajorGrid.LineColor = Color.LightGray;
        }

        // Crea una nueva serie configurada para el gráfico
        private Series CrearSerie(string nombre)
        {
            return new Series(nombre)
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Int32,
                BorderWidth = 3,
                Color = Color.FromArgb(52, 152, 219),
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 7,
                MarkerColor = Color.White,
                ShadowOffset = 2
            };
        }


        private void FrmReporteTiempoUso_Load(object sender, EventArgs e)
        {
            CargarGraficaTiempoUso(SesionUsuario.IdUsuario);

        }
    }
}
