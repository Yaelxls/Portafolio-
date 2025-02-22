using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace Proyecto_Final
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtPdw_Enter(object sender, EventArgs e)
        {
            if (txtPdw.Text == "CONTRASEÑA")
            {
                txtPdw.Text = "";
                txtPdw.ForeColor = Color.Black;
                txtPdw.UseSystemPasswordChar = true;
            }
        }

        private void txtPdw_Leave(object sender, EventArgs e)
        {
            if (txtPdw.Text == "")
            {
                txtPdw.Text = "CONTRASEÑA";
                txtPdw.ForeColor = Color.Black;
                txtPdw.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtPdw.Text.Trim();

            if (usuario == "" || usuario == "USUARIO")
            {
                msgError("Ingresa un usuario válido.");
                return;
            }

            if (contrasena == "" || contrasena == "CONTRASEÑA")
            {
                msgError("Ingresa una contraseña válida.");
                return;
            }

            string connectionString = $"server=LAPTOP-RVC8PUD8\\SQLEXPRESS; database=BD_Final; User ID={usuario}; Password={contrasena};";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryRol = @"
            SELECT 
                CASE 
                    WHEN IS_MEMBER('db_owner') = 1 THEN 'Admin'
                    WHEN IS_MEMBER('db_datareader') = 1 THEN 'ReadOnly'
                    ELSE 'None'
                END AS RolUsuario";

                    using (SqlCommand cmd = new SqlCommand(queryRol, connection))
                    {
                        string rolUsuario = cmd.ExecuteScalar()?.ToString();

                        if (rolUsuario == "Admin" || rolUsuario == "ReadOnly")
                        {
                            FrmInicio formInicio = new FrmInicio(rolUsuario);
                            this.Hide();
                            formInicio.Show();
                        }
                        else
                        {
                            msgError("No tienes permisos válidos para acceder al sistema.");
                        }
                    }
                }
            }
            catch (SqlException)
            {
                msgError("Usuario o contraseña incorrectos. \n      Por favor intentalo de nuevo.");
                txtPdw.Text = "CONTRASEÑA";
                txtPdw.UseSystemPasswordChar = false;
                txtUsuario.Focus();
            }
            catch (InvalidOperationException)
            {
                msgError($"Error en la operación");
            }
            catch (Exception)
            {
                msgError($"Error inesperado");
            }
        }
    }
} 
