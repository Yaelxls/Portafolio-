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
using System.Windows.Controls;
using System.Windows.Forms;

namespace NOTE4DAYZ
{
    public partial class FrmCrearNota : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarClasificaciones();
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


        public FrmCrearNota()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBoxFuente_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripComboBoxFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTxtContenido.SelectionFont != null)
            {
                string selectedFont = toolStripComboBoxFuente.SelectedItem.ToString();

                float currentSize = richTxtContenido.SelectionFont.Size;

                richTxtContenido.SelectionFont = new Font(selectedFont, currentSize);
            }
        }

        private void toolStripComboBoxTamaño_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBoxTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTxtContenido.SelectionFont != null)
            {
                // Obtenemos el tamaño de la fuente seleccionado
                float newSize = float.Parse(toolStripComboBoxTamaño.SelectedItem.ToString());

                // Mantenemos la fuente actual del texto seleccionado
                string currentFont = richTxtContenido.SelectionFont.Name;

                // Aplicamos el nuevo tamaño manteniendo la fuente actual
                richTxtContenido.SelectionFont = new Font(currentFont, newSize);
            }
        }

        private void toolStripButtonAlinearIzquierda_Click(object sender, EventArgs e)
        {
            richTxtContenido.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void toolStripButtonCentrar_Click(object sender, EventArgs e)
        {
            richTxtContenido.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void toolStripButtonAlinearDerecha_Click(object sender, EventArgs e)
        {
            richTxtContenido.SelectionAlignment = HorizontalAlignment.Right;

        }

        private void toolStripButtonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Aplicar el color seleccionado al texto resaltado en el RichTextBox
                richTxtContenido.SelectionColor = colorDialog1.Color;
            }

        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            if (richTxtContenido.SelectionFont != null)
            {
                // Comprobar si el texto ya está en negrita
                FontStyle newFontStyle = richTxtContenido.SelectionFont.Style;

                // Alternar negrita
                if (richTxtContenido.SelectionFont.Bold)
                    newFontStyle &= ~FontStyle.Bold; // Remover negrita
                else
                    newFontStyle |= FontStyle.Bold;  // Aplicar negrita

                // Aplicar el nuevo estilo
                richTxtContenido.SelectionFont = new Font(richTxtContenido.SelectionFont, newFontStyle);
            }
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            if (richTxtContenido.SelectionFont != null)
            {
                // Comprobar si el texto ya está en cursiva
                FontStyle newFontStyle = richTxtContenido.SelectionFont.Style;

                // Alternar cursiva
                if (richTxtContenido.SelectionFont.Italic)
                    newFontStyle &= ~FontStyle.Italic; // Remover cursiva
                else
                    newFontStyle |= FontStyle.Italic;  // Aplicar cursiva

                // Aplicar el nuevo estilo
                richTxtContenido.SelectionFont = new Font(richTxtContenido.SelectionFont, newFontStyle);
            }
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            if (richTxtContenido.SelectionFont != null)
            {
                // Comprobar si el texto ya está subrayado
                FontStyle newFontStyle = richTxtContenido.SelectionFont.Style;

                // Alternar subrayado
                if (richTxtContenido.SelectionFont.Underline)
                    newFontStyle &= ~FontStyle.Underline; // Remover subrayado
                else
                    newFontStyle |= FontStyle.Underline;  // Aplicar subrayado

                // Aplicar el nuevo estilo
                richTxtContenido.SelectionFont = new Font(richTxtContenido.SelectionFont, newFontStyle);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {   

        }

        private void checkRecordatorio_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkGuardadoAuto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void datefechaLimite_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txtNomNota_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblfechaCreacion_Click(object sender, EventArgs e)
        {

        }

        private void lblfechaModificacion_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTxtContenido_TextChanged(object sender, EventArgs e)
        {
            toolStripButtonDeshacer.Enabled = richTxtContenido.CanUndo;
            toolStripButtonRehacer.Enabled = richTxtContenido.CanRedo;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarClasificaciones()
        {
            comboBoxClasificacion.Items.Insert(0, "Clasificación");
            comboBoxClasificacion.SelectedIndex = 0;

            comboBoxClasificacion.Items.Add("Personal");
            comboBoxClasificacion.Items.Add("Trabajo");
            comboBoxClasificacion.Items.Add("Estudios");
            comboBoxClasificacion.Items.Add("Importante");
            comboBoxClasificacion.Items.Add("Otro");

            // Evento para manejar el despliegue del ComboBox
            comboBoxClasificacion.DropDown += (s, e) =>
            {
                if (comboBoxClasificacion.Items[0].ToString() == "Clasificación")
                {
                    comboBoxClasificacion.Items.RemoveAt(0);
                }
            };
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void mayúsculasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTxtContenido.SelectedText.Length > 0)
            {
                richTxtContenido.SelectedText = richTxtContenido.SelectedText.ToUpper();
            }

        }

        private void minúsculasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTxtContenido.SelectedText.Length > 0)
            {
                richTxtContenido.SelectedText = richTxtContenido.SelectedText.ToLower();
            }
        }

        private void toolStripButtonDeshacer_Click(object sender, EventArgs e)
        {
            if (richTxtContenido.CanUndo)
            {
                richTxtContenido.Undo();
            }

        }

        private void toolStripButtonRehacer_Click(object sender, EventArgs e)
        {
            if (richTxtContenido.CanRedo)
            {
                richTxtContenido.Redo();
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"; 
                openFileDialog.FilterIndex = 1; 
                openFileDialog.RestoreDirectory = true; 

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string rutaImagen = openFileDialog.FileName;

                        pictureBoxImagen.Image = System.Drawing.Image.FromFile(rutaImagen);
                        pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom; 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string contenido = richTxtContenido.Rtf.Trim();
            string textoPlano = richTxtContenido.Text.Trim();
            string clasificacion = comboBoxClasificacion.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(titulo) || titulo == "Título")
            {
                MessageBox.Show("El título es obligatorio.");
                return;
            }
            if (datefechaLimite.Checked && datefechaLimite.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha límite no puede ser anterior a la fecha actual.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textoPlano))
            {
                MessageBox.Show("El contenido es obligatorio.");
                return;
            }

            if (string.IsNullOrEmpty(clasificacion) || clasificacion == "Clasificación")
            {
                MessageBox.Show("Debe seleccionar una clasificación válida.");
                return;
            }

            DateTime? fechaLimite = datefechaLimite.Checked ? datefechaLimite.Value : (DateTime?)null;
            bool recordatorio = checkRecordatorio.Checked;
            byte[] imagen = null;

            if (pictureBoxImagen.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagen = ms.ToArray();
                }
            }

            string connectionString = SesionUsuario.CadenaConexion;
            string query = @"
INSERT INTO Nota (
    titulo, contenido, imagen, fechaCreacion, fechaModificacion, 
    clasificacion, recordatorio, fechaLimite, 
    guardadoAutomatico, intervaloGuardado, id
) VALUES (
    @titulo, @contenido, @imagen, GETDATE(), GETDATE(), 
    @clasificacion, @recordatorio, @fechaLimite, 
    @guardadoAutomatico, @intervaloGuardado, @idUsuario
)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@titulo", titulo);
                    command.Parameters.AddWithValue("@contenido", contenido);
                    command.Parameters.Add("@imagen", SqlDbType.VarBinary, -1).Value = imagen ?? (object)DBNull.Value;
                    command.Parameters.AddWithValue("@clasificacion", clasificacion);
                    command.Parameters.AddWithValue("@recordatorio", recordatorio);
                    command.Parameters.AddWithValue("@fechaLimite", fechaLimite ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@guardadoAutomatico", false);
                    command.Parameters.AddWithValue("@intervaloGuardado", 5);
                    command.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("¡Nota guardada con éxito!");
                            LimpiarCampos(); 
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar la nota.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTxtContenido.SelectedText))
            {
                Clipboard.SetText(richTxtContenido.SelectedText);
            }
        }
        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            richTxtContenido.Clear(); 
            comboBoxClasificacion.SelectedIndex = 0; // Reiniciar selección a "Seleccionar Clasificación"
            datefechaLimite.Value = DateTime.Now; 
            datefechaLimite.Checked = false; 
            checkRecordatorio.Checked = false; 
            pictureBoxImagen.Image = null; 
        }


        private void btnCortar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTxtContenido.SelectedText)) 
            {
                Clipboard.SetText(richTxtContenido.SelectedText);
                richTxtContenido.SelectedText = ""; 
            }
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                int selectionStart = richTxtContenido.SelectionStart;
                richTxtContenido.Text = richTxtContenido.Text.Insert(selectionStart, Clipboard.GetText());
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
