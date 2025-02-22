using Proyecto_Final.Consultas;
using Proyecto_Final.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FrmInicio : Form
    {
        private string userRole;

        public FrmInicio(string userRole)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.userRole = userRole;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
        "¿Estás seguro de que deseas cerrar la aplicación?",
        "Salir",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
               Application.Exit();
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
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

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
  
                btnInsertar.Visible = true;
                btnActualizar.Visible = true;
                btnEliminar.Visible = true;
                btnModificar.Visible = true;
                btnConsultar.Visible = true; 
            }
            else if (userRole == "ReadOnly")
            {
                btnInsertar.Enabled = false;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnConsultar.Enabled = true;
            }
            else
            {
                btnInsertar.Enabled = false;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                btnConsultar.Enabled = false;
            }
            FrmPanelInicio fromularioHijo = new FrmPanelInicio();
            AbrirFormularioHijo(fromularioHijo);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
"¿Estás seguro de que deseas cerrar sesión?",
"Cerrar Sesión",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                this.Hide();
                login.Show();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmInsertar insertarr = new FrmInsertar();
            AbrirFormularioHijo(insertarr);
            insertarr.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmPanelInicio formulario = new FrmPanelInicio();
            AbrirFormularioHijo(formulario);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmActualizar actualizar = new FrmActualizar();
            AbrirFormularioHijo(actualizar);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificar modificar = new FrmModificar();
            AbrirFormularioHijo(modificar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminar eliminar = new FrmEliminar();
            AbrirFormularioHijo(eliminar);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            PanelConsultar.Visible = !PanelConsultar.Visible;
        }

        private void btnTablaEstablecimiento_Click(object sender, EventArgs e)
        {
            PanelConsultar.Visible = false;
            FrmTablaEstablecimiento consultarTabla = new FrmTablaEstablecimiento(userRole);
            consultarTabla.PanelInicio = this.PanelInicio;
            AbrirFormularioHijo(consultarTabla);
            consultarTabla.Show();
        }

        private void btnTablaAuditoria_Click(object sender, EventArgs e)
        {
            PanelConsultar.Visible =false;
            FrmTablaAuditoria consultar = new FrmTablaAuditoria();
            AbrirFormularioHijo(consultar);
            consultar.Show();
        }
    }
}
