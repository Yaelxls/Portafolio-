using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace NOTE4DAYZ
{
    public partial class NOTE4DAYZ : Form
    {

        public NOTE4DAYZ()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkLabelAqui_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro Registro = new FrmRegistro();
            Registro.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {


            SqlConnection conexion = new SqlConnection(SesionUsuario.CadenaConexion);
            try
            {
                conexion.Open();

                // Verifica el nombre correcto de la columna 'id' o 'idUsuario' en tu tabla
                String cadena = "SELECT id, nombre FROM Usuario WHERE usuario = @usuario AND contraseña = @contraseña";

                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@contraseña", txtContra.Text);

                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    SesionUsuario.IdUsuario = Convert.ToInt32(registro["id"]);
                    SesionUsuario.NombreUsuario = registro["nombre"].ToString();
                    RegistrarInicioSesion(SesionUsuario.IdUsuario);
                    BarraTitulo inicio = new BarraTitulo();
                    inicio.Show();
                    this.Hide();

                }
                else
                {
                    FrmError Error = new FrmError();
                    Error.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        private void RegistrarInicioSesion(int idUsuario)
        {
            DateTime fechaInicio = DateTime.Now;

            string query = "INSERT INTO Reporte (id, fechaInicio) VALUES (@id, @fechaInicio)";

            using (SqlConnection conexion = new SqlConnection(SesionUsuario.CadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idUsuario);
                    comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar el inicio de sesión: " + ex.Message);
                    }
                }
            }
        }


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }

        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.White;
                txtContra.PasswordChar = '•';
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.White;
                txtContra.PasswordChar = '\0';
            }
        }

        private void NOTE4DAYZ_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.paypal.me/yaelanda",
                UseShellExecute = true
            });
        }

        private void NOTE4DAYZ_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
