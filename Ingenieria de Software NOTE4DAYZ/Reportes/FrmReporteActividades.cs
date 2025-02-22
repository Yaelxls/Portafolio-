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
    public partial class FrmReporteActividades : Form
    {
        public FrmReporteActividades()
        {
            InitializeComponent();
        }
        private string GenerarReporteActividades(int idUsuario)
        {
            string reporte = "";
            string connectionString = SesionUsuario.CadenaConexion;
            string query = @"
        SELECT 
            SUM(CASE WHEN No_Completado = 1 THEN 1 ELSE 0 END) AS NoCompletadas,
            SUM(CASE WHEN Completado = 1 THEN 1 ELSE 0 END) AS Completadas
        FROM CheckList
        INNER JOIN Nota ON CheckList.idNota = Nota.idNota
        WHERE Nota.id = @idUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            int noCompletadas = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            int completadas = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);

                            reporte = $"Reporte de Actividades:\n\n" +
                                      $"Actividades Completadas: {completadas}\n" +
                                      $"Actividades No Completadas: {noCompletadas}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el reporte: " + ex.Message);
                    }
                }
            }

            return reporte;
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
        private void EnviarReporteActividades()
        {
            string emailDestino = ObtenerCorreoUsuario();
            if (string.IsNullOrEmpty(emailDestino))
            {
                MessageBox.Show("No se encontró el correo electrónico del usuario.");
                return;
            }

            string reporte = GenerarReporteActividades(SesionUsuario.IdUsuario);
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
        private void CargarGraficaActividades(int idUsuario)
        {
            string connectionString = SesionUsuario.CadenaConexion;
            string query = @"
    SELECT 
        SUM(CASE WHEN No_Completado = 1 THEN 1 ELSE 0 END) AS NoCompletadas,
        SUM(CASE WHEN Completado = 1 THEN 1 ELSE 0 END) AS Completadas
    FROM CheckList
    INNER JOIN Nota ON CheckList.idNota = Nota.idNota
    WHERE Nota.id = @idUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            int noCompletadas = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            int completadas = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);

                            // Limpiar y configurar el gráfico
                            chartTiempoUso.Series.Clear();

                            // Crear serie para el gráfico de barras
                            Series serie = new Series("Actividades")
                            {
                                ChartType = SeriesChartType.Bar,
                                IsValueShownAsLabel = true
                            };

                            // Agregar datos a la serie
                            serie.Points.AddXY("No Completadas", noCompletadas);
                            serie.Points.AddXY("Completadas", completadas);

                            // Agregar la serie al gráfico
                            chartTiempoUso.Series.Add(serie);

                            // Configurar área del gráfico
                            chartTiempoUso.ChartAreas[0].AxisX.Title = "Estado de Actividades";
                            chartTiempoUso.ChartAreas[0].AxisY.Title = "Cantidad";

                            // Si no hay datos, muestra un mensaje
                            if (noCompletadas == 0 && completadas == 0)
                            {
                                MessageBox.Show("No hay datos disponibles para mostrar.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos del gráfico: " + ex.Message);
                    }
                }
            }
        }

        private void InicializarGrafico()
        {
            chartTiempoUso.Series.Clear();
            chartTiempoUso.ChartAreas.Clear();
            chartTiempoUso.Legends.Clear();
            chartTiempoUso.Titles.Clear();

            // Configurar área del gráfico
            ChartArea area = new ChartArea
            {
                Name = "ActividadesArea",
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
                Name = "ActividadesLegend",
                Docking = Docking.Top,
                Alignment = StringAlignment.Center,
                Font = new Font("Segoe UI", 9),
                BackColor = Color.Transparent
            };
            chartTiempoUso.Legends.Add(legend);

            // Agregar título
            Title titulo = new Title
            {
                Text = "Reporte de Actividades Completadas y No Completadas",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Docking = Docking.Top
            };
            chartTiempoUso.Titles.Add(titulo);
        }


        private void ConfigurarEjeX(Axis ejeX)
        {
            ejeX.Title = "Estado de Actividades";
            ejeX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            ejeX.LabelStyle.Font = new Font("Segoe UI", 9);
            ejeX.MajorGrid.LineColor = Color.LightGray;
            ejeX.MajorGrid.LineColor = Color.Transparent; 
            ejeX.MinorGrid.LineColor = Color.Transparent;
            ejeX.Interval = 1;
            ejeX.LabelStyle.Angle = 0; 
        }


        private void ConfigurarEjeY(Axis ejeY)
        {
            ejeY.Title = "Cantidad de Actividades";
            ejeY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            ejeY.LabelStyle.Font = new Font("Segoe UI", 9);
            ejeY.MajorGrid.LineColor = Color.LightGray;
            ejeY.MajorGrid.LineColor = Color.Transparent;
            ejeY.MinorGrid.LineColor = Color.Transparent;
        }

        private Series CrearSerie(string nombre)
        {
            return new Series(nombre)
            {
                ChartType = SeriesChartType.Column, // Barra horizontal para mayor legibilidad
                BorderWidth = 2,
                Color = Color.FromArgb(52, 152, 219), // Azul suave
                ShadowOffset = 0, 
                MarkerSize = 8,
                MarkerColor = Color.White
            };
        }
        private void AgregarDatosAlGrafico()
        {
            // Crear series
            Series serieCompletado = CrearSerie("Completado");
            serieCompletado.Points.AddXY("Completadas", 10); // Aquí agregas la cantidad de actividades completadas
            chartTiempoUso.Series.Add(serieCompletado);

            Series serieNoCompletado = CrearSerie("No Completado");
            serieNoCompletado.Points.AddXY("No Completadas", 15); // Aquí agregas la cantidad de actividades no completadas
            chartTiempoUso.Series.Add(serieNoCompletado);
        }


        private void FrmReporteActividades_Load(object sender, EventArgs e)
        {
            CargarGraficaActividades(SesionUsuario.IdUsuario);

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            EnviarReporteActividades();
        }
    }
}
