using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NOTE4DAYZ.Nota
{
    public partial class FrmConsultarNota : Form
    {
        public FrmConsultarNota()
        {
            InitializeComponent();

        }
        private void Form_Load(object sender, EventArgs e)
        {
        }
        private void FrmConsultarNota_Load(object sender, EventArgs e)
        {
            InicializarListaVersiones();
            CargarComboBoxClasificacion();
            CargarComboBoxModificarClasificacion();
            toolStripButtonDeshacer.Click += new EventHandler(toolStripButtonDeshacer_Click);
            toolStripButtonRehacer.Click += new EventHandler(toolStripButtonRehacer_Click);
            foreach (FontFamily font in FontFamily.Families)
            {
                toolStripComboBoxFuente.Items.Add(font.Name);
            }
            toolStripComboBoxFuente.SelectedItem = "Arial";
            toolStripComboBoxTamaño.Items.AddRange(new object[] { "8", "10", "12", "14", "16", "18", "20", "24", "28", "32", "36", "48", "72" });
            toolStripComboBoxTamaño.SelectedItem = "12";

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

        private void CargarComboBoxModificarClasificacion()
        {
            comboBoxModificarClasificacion.DataSource = new List<string>
    {
        "Nueva Clasificación",
        "Personal",
        "Trabajo",
        "Estudios",
        "Importante",
        "Otro"
    };
            comboBoxModificarClasificacion.SelectedIndex = 0;
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
            }
            else
            {
                comboBoxNotas.DataSource = null;
            }
        }
        private void CargarNota()
        {
            if (comboBoxNotas.SelectedValue != null)
            {
                int idNotaSeleccionada = Convert.ToInt32(comboBoxNotas.SelectedValue);

                string connectionString = SesionUsuario.CadenaConexion;
                string query = "SELECT contenido, titulo, fechaCreacion, fechaModificacion, fechaLimite FROM Nota WHERE idNota = @idNota AND id = @idUsuario";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idNota", idNotaSeleccionada);
                        command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Cargar contenido de la nota
                                string contenido = reader["contenido"]?.ToString();
                                if (!string.IsNullOrEmpty(contenido))
                                {
                                    richTextBoxContenido.Rtf = contenido;
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró contenido para esta nota.");
                                    richTextBoxContenido.Clear();
                                }

                                // Cargar título de la nota
                                string tituloNota = reader["titulo"]?.ToString();
                                if (!string.IsNullOrEmpty(tituloNota))
                                {
                                    txtTitulo.Text = tituloNota; // Asumiendo que txtTitulo es el TextBox
                                }

                                // Cargar fechas
                                DateTime? fechaCreacion = reader["fechaCreacion"] as DateTime?;
                                DateTime? fechaModificacion = reader["fechaModificacion"] as DateTime?;
                                DateTime? fechaLimite = reader["fechaLimite"] as DateTime?;

                                if (fechaCreacion.HasValue)
                                {
                                    lblfechaCreacion.Text = $"{fechaCreacion.Value.ToString("dd/MM/yyyy")}";
                                }
                                else
                                {
                                    lblfechaCreacion.Text = "Fecha de creación no disponible";
                                }

                                if (fechaModificacion.HasValue)
                                {
                                    lblfechaModificacion.Text = $"{fechaModificacion.Value.ToString("dd/MM/yyyy")}";
                                }
                                else
                                {
                                    lblfechaModificacion.Text = "Fecha de modificación no disponible";
                                }

                                if (fechaLimite.HasValue)
                                {
                                    lblFechaLimite.Text = $"{fechaLimite.Value.ToString("dd/MM/yyyy")}";
                                }
                                else
                                {
                                    lblFechaLimite.Text = "Fecha límite no disponible";
                                }

                                // Cargar imagen de la nota
                                CargarImagen(tituloNota);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró la nota seleccionada.");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una nota para cargar.");
            }
        }

        private byte[] RecuperarImagenNota(string tituloNota)
        {
            string query = "SELECT imagen FROM Nota WHERE titulo = @tituloNota";
            using (SqlConnection connection = new SqlConnection(SesionUsuario.CadenaConexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tituloNota", tituloNota);

                connection.Open();
                object resultado = command.ExecuteScalar();

                // Verificar si el resultado es DBNull
                if (resultado != DBNull.Value && resultado != null)
                {
                    return (byte[])resultado;
                }

                return null; // Retornar null si no hay imagen
            }
        }
        private void CargarImagen(string tituloNota)
        {
            byte[] imagenBytes = RecuperarImagenNota(tituloNota);

            if (imagenBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    pictureBoxImagen.Image = Image.FromStream(ms);
                    pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;

                }
            }
            else
            {
                pictureBoxImagen.Image = null;
            }
        }

        private void BuscarPalabraEnContenido(string palabra)
        {
            string contenido = richTextBoxContenido.Text;
            int indice = 0;

            // Desactiva la actualización del control para mejorar el rendimiento
            richTextBoxContenido.SuspendLayout();

            // Limpia cualquier resaltado previo
            richTextBoxContenido.SelectAll();
            richTextBoxContenido.SelectionBackColor = Color.White;

            // Busca y resalta todas las ocurrencias de la palabra
            while ((indice = contenido.IndexOf(palabra, indice, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                richTextBoxContenido.Select(indice, palabra.Length);
                richTextBoxContenido.SelectionBackColor = Color.Yellow;
                indice += palabra.Length; // Avanza el índice para buscar la siguiente ocurrencia
            }

            // Reactiva la actualización del control
            richTextBoxContenido.ResumeLayout();
        }


        private void btnCargarNota_Click(object sender, EventArgs e)
        {
            CargarNota();
        }

        private void toolStripButtonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Aplicar el color seleccionado al texto resaltado en el RichTextBox
                richTextBoxContenido.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButtonAlinearIzquierda_Click(object sender, EventArgs e)
        {
            richTextBoxContenido.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void toolStripButtonCentrar_Click(object sender, EventArgs e)
        {
            richTextBoxContenido.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void toolStripButtonAlinearDerecha_Click(object sender, EventArgs e)
        {
            richTextBoxContenido.SelectionAlignment = HorizontalAlignment.Right;

        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            if (richTextBoxContenido.SelectionFont != null)
            {
                // Comprobar si el texto ya está en negrita
                FontStyle newFontStyle = richTextBoxContenido.SelectionFont.Style;

                // Alternar negrita
                if (richTextBoxContenido.SelectionFont.Bold)
                    newFontStyle &= ~FontStyle.Bold; // Remover negrita
                else
                    newFontStyle |= FontStyle.Bold;  // Aplicar negrita

                // Aplicar el nuevo estilo
                richTextBoxContenido.SelectionFont = new Font(richTextBoxContenido.SelectionFont, newFontStyle);
            }
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            if (richTextBoxContenido.SelectionFont != null)
            {
                // Comprobar si el texto ya está en cursiva
                FontStyle newFontStyle = richTextBoxContenido.SelectionFont.Style;

                // Alternar cursiva
                if (richTextBoxContenido.SelectionFont.Italic)
                    newFontStyle &= ~FontStyle.Italic; // Remover cursiva
                else
                    newFontStyle |= FontStyle.Italic;  // Aplicar cursiva

                // Aplicar el nuevo estilo
                richTextBoxContenido.SelectionFont = new Font(richTextBoxContenido.SelectionFont, newFontStyle);
            }
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBoxContenido.SelectionFont != null)
            {
                // Comprobar si el texto ya está subrayado
                FontStyle newFontStyle = richTextBoxContenido.SelectionFont.Style;

                // Alternar subrayado
                if (richTextBoxContenido.SelectionFont.Underline)
                    newFontStyle &= ~FontStyle.Underline; // Remover subrayado
                else
                    newFontStyle |= FontStyle.Underline;  // Aplicar subrayado

                // Aplicar el nuevo estilo
                richTextBoxContenido.SelectionFont = new Font(richTextBoxContenido.SelectionFont, newFontStyle);
            }
        }

        private void mayúsculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxContenido.SelectedText.Length > 0)
            {
                // Convertir el texto seleccionado a mayúsculas
                richTextBoxContenido.SelectedText = richTextBoxContenido.SelectedText.ToUpper();
            }
        }

        private void minúsculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxContenido.SelectedText.Length > 0)
            {
                // Convertir el texto seleccionado a minúsculas
                richTextBoxContenido.SelectedText = richTextBoxContenido.SelectedText.ToLower();
            }
        }

        private void toolStripButtonDeshacer_Click(object sender, EventArgs e)
        {
            if (richTextBoxContenido.CanUndo)
            {
                richTextBoxContenido.Undo();
            }
        }

        private void toolStripButtonRehacer_Click(object sender, EventArgs e)
        {
            if (richTextBoxContenido.CanRedo)
            {
                richTextBoxContenido.Redo();
            }
        }

        private void checkRecordatorio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string palabraBuscada = textBuscarPalabra.Text; // Obtiene la palabra escrita en el TextBox
            BuscarPalabraEnContenido(palabraBuscada);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            if (comboBoxNotas.SelectedValue != null)
            {
                int idNotaSeleccionada = Convert.ToInt32(comboBoxNotas.SelectedValue);
                string nuevoContenido = richTextBoxContenido.Rtf;
                byte[] nuevaImagen = null;

                // Verificar si hay una imagen seleccionada para la nota
                if (pictureBoxImagen.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        nuevaImagen = ms.ToArray(); // Convertir la imagen a un arreglo de bytes
                    }
                }

                // Actualizar la base de datos con el nuevo contenido y la nueva imagen (si existe)
                string connectionString = SesionUsuario.CadenaConexion;
                string query = "UPDATE Nota SET contenido = @contenido, imagen = @imagen WHERE idNota = @idNota";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@contenido", nuevoContenido);
                        command.Parameters.AddWithValue("@idNota", idNotaSeleccionada);

                        // Si hay una imagen, agregarla al parámetro
                        if (nuevaImagen != null)
                        {
                            command.Parameters.AddWithValue("@imagen", nuevaImagen);
                        }
                        else
                        {
                            // Si no hay imagen, pasar null
                            command.Parameters.AddWithValue("@imagen", DBNull.Value);
                        }

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Nota guardada exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Hubo un problema al guardar la nota.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una nota para guardar los cambios.");
            }
        }

        private void listViewHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkGuardadoAuto_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool cambiosPendientes = false;

        private void richTextBoxContenido_TextChanged(object sender, EventArgs e)
        {
            cambiosPendientes = true;

        }

        private void toolStripComboBoxFuente_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBoxFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBoxContenido.SelectionFont != null)
            {
                // Obtenemos la fuente seleccionada del ComboBox
                string selectedFont = toolStripComboBoxFuente.SelectedItem.ToString();

                // Mantenemos el tamaño actual de la fuente
                float currentSize = richTextBoxContenido.SelectionFont.Size;

                // Aplicamos la nueva fuente manteniendo el tamaño actual
                richTextBoxContenido.SelectionFont = new Font(selectedFont, currentSize);
            }
        }

        private void toolStripComboBoxTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBoxContenido.SelectionFont != null)
            {
                // Obtenemos el tamaño de la fuente seleccionado
                float newSize = float.Parse(toolStripComboBoxTamaño.SelectedItem.ToString());

                // Mantenemos la fuente actual del texto seleccionado
                string currentFont = richTextBoxContenido.SelectionFont.Name;

                // Aplicamos el nuevo tamaño manteniendo la fuente actual
                richTextBoxContenido.SelectionFont = new Font(currentFont, newSize);
            }
        }

        private void toolStripComboBoxTamaño_Click(object sender, EventArgs e)
        {

        }

        private void checkGuardadoAuto_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkGuardadoAuto.Checked)
            {
                cambiosPendientes = true; // Inicializa cambios como pendientes para el primer guardado
                timerGuardadoAuto.Start();
            }
            else
            {
                timerGuardadoAuto.Stop();
            }
        }

        private void timerGuardadoAuto_Tick(object sender, EventArgs e)
        {
            if (cambiosPendientes)
            {
                GuardarAutomaticamente();
                cambiosPendientes = false; // Resetea la bandera tras guardar
            }
        }
        private void GuardarAutomaticamente()
        {
            if (comboBoxNotas.SelectedValue != null)
            {
                int idNotaSeleccionada = Convert.ToInt32(comboBoxNotas.SelectedValue);
                string nuevoContenido = richTextBoxContenido.Rtf;

                string connectionString = SesionUsuario.CadenaConexion;
                string query = "UPDATE Nota SET contenido = @contenido, fechaModificacion = GETDATE() WHERE idNota = @idNota";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@contenido", nuevoContenido);
                        command.Parameters.AddWithValue("@idNota", idNotaSeleccionada);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            lblfechaModificacion.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error en el guardado automático: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna nota seleccionada para guardar.");
            }
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                int selectionStart = richTextBoxContenido.SelectionStart;
                richTextBoxContenido.Text = richTextBoxContenido.Text.Insert(selectionStart, Clipboard.GetText());
            }
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBoxContenido.SelectedText))
            {
                Clipboard.SetText(richTextBoxContenido.SelectedText);
                richTextBoxContenido.SelectedText = "";
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBoxContenido.SelectedText))
            {
                Clipboard.SetText(richTextBoxContenido.SelectedText);
            }
        }

        private void comboBoxClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clasificacionSeleccionada = comboBoxClasificacion.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(clasificacionSeleccionada) || clasificacionSeleccionada == "Seleccionar Clasificación")
            {
                comboBoxNotas.DataSource = null;
                return;
            }
            CargarComboBoxNotas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBuscarPalabra_Enter(object sender, EventArgs e)
        {
            if (textBuscarPalabra.Text == "Buscar")
            {
                textBuscarPalabra.Text = "";
                textBuscarPalabra.ForeColor = Color.Black;
            }
        }

        private void textBuscarPalabra_Leave(object sender, EventArgs e)
        {
            if (textBuscarPalabra.Text == "")
            {
                textBuscarPalabra.Text = "Buscar";
                textBuscarPalabra.ForeColor = Color.Black;
            }
        }

        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "Título")
            {
                txtTitulo.Text = "";
                txtTitulo.ForeColor = Color.Black;
            }

        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                txtTitulo.Text = "Título";
                txtTitulo.ForeColor = Color.Black;
            }
        }

        private void listViewVersiones_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void InicializarListaVersiones()
        {
            listView1.Items.Clear();

            listView1.Items.Add("v1");
            listView1.Items.Add("v2");
            listView1.Items.Add("v3");
            listView1.Items.Add("v4");
            listView1.Items.Add("v5");
            listView1.Items.Add("v6");

            listView2.Items.Clear();

            listView2.Items.Add("Restaurar v1");
            listView2.Items.Add("Restaurar v2");
            listView2.Items.Add("Restaurar v3");
            listView2.Items.Add("Restaurar v4");
            listView2.Items.Add("Restaurar v5");
            listView2.Items.Add("Restaurar v6");

        }

        private void btnModificarClasificacion_Click(object sender, EventArgs e)
        {
            // Obtener la clasificación actual seleccionada en comboBoxClasificacion
            string clasificacionActual = comboBoxClasificacion.SelectedItem?.ToString();

            // Obtener la nueva clasificación seleccionada en comboBoxModificarClasificacion
            string nuevaClasificacion = comboBoxModificarClasificacion.SelectedItem?.ToString();

            // Validar que la clasificación actual y nueva no sean nulas o vacías
            if (string.IsNullOrEmpty(clasificacionActual) || clasificacionActual == "Seleccionar Clasificación")
            {
                MessageBox.Show("Seleccione una clasificación válida en el comboBox de clasificaciones.");
                return;
            }

            if (string.IsNullOrEmpty(nuevaClasificacion) || nuevaClasificacion == "Nueva Clasificación")
            {
                MessageBox.Show("Seleccione una nueva clasificación para modificar.");
                return;
            }

            // Verificar que la nueva clasificación no sea igual a la actual
            if (clasificacionActual.Equals(nuevaClasificacion, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("La nueva clasificación no puede ser igual a la actual.");
                return;
            }

            // Actualizar clasificación en la base de datos
            string connectionString = SesionUsuario.CadenaConexion;
            string query = "UPDATE Nota SET clasificacion = @nuevaClasificacion WHERE clasificacion = @clasificacionActual AND id = @idUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nuevaClasificacion", nuevaClasificacion);
                    command.Parameters.AddWithValue("@clasificacionActual", clasificacionActual);
                    command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario);

                    try
                    {
                        connection.Open();
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Clasificación modificada correctamente.");
                            CargarComboBoxModificarClasificacion(); // Recargar las clasificaciones
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron notas con la clasificación seleccionada.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar la clasificación: " + ex.Message);
                    }
                }
            }
        }

        private void btnEliminarClasificacion_Click(object sender, EventArgs e)
        {
            string clasificacionActual = comboBoxModificarClasificacion.Text.Trim();

            if (clasificacionActual == "Seleccionar Clasificación" || string.IsNullOrEmpty(clasificacionActual))
            {
                MessageBox.Show("Seleccione una clasificación válida.");
                return;
            }

            // Confirmar eliminación
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar la clasificación seleccionada?", "Confirmación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                return;
            }

            string connectionString = SesionUsuario.CadenaConexion;
            string query = "UPDATE Nota SET clasificacion = NULL WHERE clasificacion = @clasificacionActual AND id = @idUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@clasificacionActual", clasificacionActual);
                    command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario);

                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Clasificación eliminada correctamente.");
                        CargarComboBoxModificarClasificacion();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron notas con la clasificación seleccionada.");
                    }
                }
            }
        }

    }
}
