using NOTE4DAYZ.CheckList;
using NOTE4DAYZ.Desarrollador;
using NOTE4DAYZ.Nota;
using NOTE4DAYZ.Recordatorio;
using NOTE4DAYZ.Reportes;
using NOTE4DAYZ.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace NOTE4DAYZ
{
    public partial class BarraTitulo : Form
    {
        private List<Form> formulariosHijos = new List<Form>();

        public BarraTitulo()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FrmInicio_Load);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NOTE4DAYZ cerrarSesion = new NOTE4DAYZ();
            cerrarSesion.Show();
            this.Hide();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Hola, " + SesionUsuario.NombreUsuario;
            PanelInicio formularioHijo= new PanelInicio();
            AbrirFormularioHijo(formularioHijo);


        }
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            foreach (Control control in PanelInicio.Controls)
            {
                if (control is Form formulario)
                {
                    formulario.Close();
                }
            }

            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            PanelInicio.Controls.Add(formularioHijo);
            PanelInicio.Tag = formularioHijo;
            formularioHijo.Show();
        }


        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            RegistrarFinSesion(SesionUsuario.IdUsuario);
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            RegistrarFinSesion(SesionUsuario.IdUsuario);
            NOTE4DAYZ Login = new NOTE4DAYZ();
            Login.Show();
            this.Close();
        }
        private void btnTaCrear_Click(object sender, EventArgs e)
        {
            SubMenuNotas.Visible = false;
            FrmCrearNota crearNota = new FrmCrearNota();
            AbrirFormMotas(crearNota);
            crearNota.Show();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            SubMenuNotas.Visible = !SubMenuNotas.Visible;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFormMotas(Form FrmHijaNota)
        {
            if (this.PanelInicio.Controls.Count > 0)
            {
                this.PanelInicio.Controls.RemoveAt(0);  // Elimina el formulario anterior
                foreach (var form in formulariosHijos)   // Cierra los formularios anteriores
                {
                    form.Close();
                }
                formulariosHijos.Clear();  // Limpiar la lista de formularios
            }

            if (this.PanelInicio.Controls.Count > 0)
                this.PanelInicio.Controls.RemoveAt(0);
            Form fh = FrmHijaNota as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelInicio.Controls.Add(fh);
            this.PanelInicio.Tag = fh;
            fh.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            panelRecordatorio.Visible = !panelRecordatorio.Visible;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelInicio formulario = new PanelInicio();
            AbrirFormularioHijo(formulario);

        }

        private void SubMenuNotas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditarNota_Click(object sender, EventArgs e)
        {

            SubMenuNotas.Visible = false;
            FrmConsultarNota ConsultarNota = new FrmConsultarNota();
            AbrirFormConsultarNota(ConsultarNota);
            ConsultarNota.Show();

        }
        private void AbrirFormConsultarNota(object FrmHijaConsultar)
        {
            if (this.PanelInicio.Controls.Count > 0)
            {
                this.PanelInicio.Controls.RemoveAt(0);  // Elimina el formulario anterior
                foreach (var form in formulariosHijos)   // Cierra los formularios anteriores
                {
                    form.Close();
                }
                formulariosHijos.Clear();  // Limpiar la lista de formularios
            }

            if (this.PanelInicio.Controls.Count > 0)
                this.PanelInicio.Controls.RemoveAt(0);
            Form fh = FrmHijaConsultar as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelInicio.Controls.Add(fh);
            this.PanelInicio.Tag = fh;
            fh.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SubmenuAdmin.Visible = !SubmenuAdmin.Visible;
        }

        private void AbrirFormAdmin(object FrmHijaAdmin)
        {
            if (this.PanelInicio.Controls.Count > 0)
            {
                this.PanelInicio.Controls.RemoveAt(0);  // Elimina el formulario anterior
                foreach (var form in formulariosHijos)   // Cierra los formularios anteriores
                {
                    form.Close();
                }
                formulariosHijos.Clear();  // Limpiar la lista de formularios
            }


            if (this.PanelInicio.Controls.Count > 0)
                this.PanelInicio.Controls.RemoveAt(0);
            Form fh = FrmHijaAdmin as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelInicio.Controls.Add(fh);
            this.PanelInicio.Tag = fh;
            fh.Show();
        }

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            SubmenuAdmin.Visible = false;
            FrmAgregarUser agregarUser = new FrmAgregarUser();
            AbrirFormMotas(agregarUser);
            agregarUser.Show();

        }

        private void btnEditarUser_Click(object sender, EventArgs e)
        {
            SubmenuAdmin.Visible = false;
            FrmEditarUser editarUser = new FrmEditarUser();
            AbrirFormAdmin(editarUser);
            editarUser.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            PanelMenuConfig.Visible = !PanelMenuConfig.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelMenuConfig.Visible = false;
            FrmReporteActividades reporteActividades = new FrmReporteActividades();
            AbrirFormMotas(reporteActividades);
            reporteActividades.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnModificarFecha_Click(object sender, EventArgs e)
        {
            SubMenuNotas.Visible = false;
            FrmModiFecha ModificarFechaNota = new FrmModiFecha();
            AbrirFormConsultarNota(ModificarFechaNota);
            ModificarFechaNota.Show();
        }

        private void btnEliminarNota_Click(object sender, EventArgs e)
        {
            SubMenuNotas.Visible = false;
            FrmEliminarNota EliminarNota = new FrmEliminarNota();
            AbrirFormConsultarNota(EliminarNota);
            EliminarNota.Show();

        }

        private void btnCrearRecordatorio_Click(object sender, EventArgs e)
        {
            panelRecordatorio.Visible = false;
            FrmCrearRecordatorio crearRecordatorio = new FrmCrearRecordatorio();
            AbrirFormMotas(crearRecordatorio);
            crearRecordatorio.Show();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void btnTiempoUso_Click(object sender, EventArgs e)
        {
            PanelMenuConfig.Visible = false;
            FrmReporteTiempoUso ReporteTiempoUso = new FrmReporteTiempoUso();
            AbrirFormMotas(ReporteTiempoUso);
            ReporteTiempoUso.Show();
        }
        private void RegistrarFinSesion(int idUsuario)
        {
            DateTime fechaFin = DateTime.Now;

            string query = @"
        UPDATE Reporte
        SET fechaFin = @fechaFin, tiempoTotal = DATEDIFF(MINUTE, fechaInicio, @fechaFin)
        WHERE id = @id AND fechaFin IS NULL";

            using (SqlConnection conexion = new SqlConnection(SesionUsuario.CadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idUsuario);
                    comando.Parameters.AddWithValue("@fechaFin", fechaFin);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar el fin de sesión: " + ex.Message);
                    }
                }
            }
        }

        private void BarraTitulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistrarFinSesion(SesionUsuario.IdUsuario);    
        }

        private void btnCheckList_Click(object sender, EventArgs e)
        {
            panelCheck.Visible = !panelCheck.Visible;

        }

        private void btnRegistroNotas_Click(object sender, EventArgs e)
        {
            panelCheck.Visible = false;
            FrmChecList Checar = new FrmChecList();
            AbrirFormMotas(Checar);
            Checar.Show();
        }

        private void PanelMenuConfig_Paint(object sender, PaintEventArgs e)
        {
   
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            SubmenuAdmin.Visible = false;
            FrmEliminarUser eliminarUser = new FrmEliminarUser();
            AbrirFormAdmin(eliminarUser);
            eliminarUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel20.Visible = false;
            FrmCarpetasProtegidas carpetasProtegidas = new FrmCarpetasProtegidas();
            AbrirFormAdmin(carpetasProtegidas);
            carpetasProtegidas.Show();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            panel20.Visible = !panel20.Visible;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            PanelMenuConfig.Visible = false;
            FrmPersonalizar personalizar = new FrmPersonalizar();
            AbrirFormAdmin(personalizar);
            personalizar.Show();
        }
    }
}
