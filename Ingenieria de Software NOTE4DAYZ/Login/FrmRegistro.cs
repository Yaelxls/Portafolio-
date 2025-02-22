using NOTE4DAYZ.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NOTE4DAYZ
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!LinklblAceptar.Checked)
            {
                FrmTerminosError terminosError  = new FrmTerminosError();
                terminosError.Show();
                return; 
            }

            SqlConnection conexion = new SqlConnection(SesionUsuario.CadenaConexion);

            try
            {
                conexion.Open();

                if (string.IsNullOrWhiteSpace(txtRegNombre.Text) || string.IsNullOrWhiteSpace(txtRegApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtRegUsuario.Text) || string.IsNullOrWhiteSpace(txtRegContra.Text) ||
                    string.IsNullOrWhiteSpace(txtRegEmail.Text))
                {
                    FrmRegistroError registroError = new FrmRegistroError();
                    registroError.Show();
                    return;
                }

                if (!EsEmailValido(txtRegEmail.Text))
                {
                    FrmEmailError emailError = new FrmEmailError();
                    emailError.Show();
                    return;
                }

                String cadena = "INSERT INTO Usuario (nombre, apellido, usuario, contraseña, email) " +
                                "VALUES (@nombre, @apellido, @usuario, @contraseña, @email)";

                SqlCommand comando = new SqlCommand(cadena, conexion);

                comando.Parameters.AddWithValue("@nombre", txtRegNombre.Text);
                comando.Parameters.AddWithValue("@apellido", txtRegApellido.Text);
                comando.Parameters.AddWithValue("@usuario", txtRegUsuario.Text);
                comando.Parameters.AddWithValue("@contraseña", txtRegContra.Text);
                comando.Parameters.AddWithValue("@email", txtRegEmail.Text);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    FrmCompletado completado = new FrmCompletado();
                    completado.Show();

                    txtRegNombre.Clear();
                    txtRegApellido.Clear();
                    txtRegUsuario.Clear();
                    txtRegContra.Clear();
                    txtRegEmail.Clear();
                }
                else
                {
                    FrmError error = new FrmError();
                    error.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }
        private bool EsEmailValido(string email)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnRegistrarse.Enabled = LinklblAceptar.Checked;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textRegBox3Enter_TextChanged(object sender, EventArgs e)
        {
            if (txtRegNombre.Text == "Nombre")
            {
                txtRegNombre.Text = "";
                txtRegNombre.ForeColor = Color.White;
            }
        }
        private void textRegBox3Leave_TextChanged(object sender, EventArgs e)
        {
            if (txtRegNombre.Text == "")
            {
                txtRegNombre.Text = "Nombre";
                txtRegNombre.ForeColor = Color.White;
            }

        }

        private void txtRegApellido_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtRegApellidoEnter_TextChanged(object sender, EventArgs e)
        {
            if (txtRegApellido.Text == "Apellido")
            {
                txtRegApellido.Text = "";
                txtRegApellido.ForeColor = Color.White;
            }
        }
        private void txtRegApellidoLeave_TextChanged(object sender, EventArgs e)
        {
            if (txtRegApellido.Text == "")
            {
                txtRegApellido.Text = "Apellido";
                txtRegApellido.ForeColor = Color.White;
            }

        }

        private void txtRegUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtRegUsuarioEnter_TextChanged(object sender, EventArgs e)
        {
            if (txtRegUsuario.Text == "Usuario")
            {
                txtRegUsuario.Text = "";
                txtRegUsuario.ForeColor = Color.White;
            }
        }
        private void txtRegUsuarioLeave_TextChanged(object sender, EventArgs e)
        {
            if (txtRegUsuario.Text == "")
            {
                txtRegUsuario.Text = "Usuario";
                txtRegUsuario.ForeColor = Color.White;
            }

        }

        private void txtRegContra_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtRegContraseña_Enter(object sender, EventArgs e)
        {
            if (txtRegContra.Text == "Contraseña")
            {
                txtRegContra.Text = "";
                txtRegContra.ForeColor = Color.White;
                txtRegContra.PasswordChar = '•'; 
            }
        }

      
        private void txtRegContraseña_Leave(object sender, EventArgs e)
        {
            if (txtRegContra.Text == "")
            {
                txtRegContra.Text = "Contraseña";
                txtRegContra.ForeColor = Color.White; 
                txtRegContra.PasswordChar = '\0'; 
            }
        }

        private void txtRegEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtRegEmailEnter_TextChanged(object sender, EventArgs e)
        {
            if (txtRegEmail.Text == "Email")
            {
                txtRegEmail.Text = "";
                txtRegEmail.ForeColor = Color.White;
            }

        }
        private void txtRegEmailLeave_TextChanged(object sender, EventArgs e)
        {
            if (txtRegEmail.Text == "")
            {
                txtRegEmail.Text = "Email";
                txtRegEmail.ForeColor = Color.White;
            }
        }

        private void pbExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkLabelAqui_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://accounts.google.com/lifecycle/steps/signup/name?continue=https://myaccount.google.com?utm_source%3Daccount-marketing-page%26utm_medium%3Dcreate-account-button&ddm=1&dsh=S17181098:1732562857048811&flowEntry=SignUp&flowName=GlifWebSignIn&TL=AKOx4s2lHNbHIU9C-J2Yh531VwNOCdbRlwLot2OCPua-GAbCNWBLzxyapgM5K3s5",
                UseShellExecute = true
            });
        }

        private void FrmRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
