using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Consultas
{
    public partial class FrmTablaEstablecimiento : Form
    {
        private string rolUsuario;
        public FrmTablaEstablecimiento(string rolUsuario)
        {
            InitializeComponent();
            this.rolUsuario = rolUsuario;
        }
        private Panel panelInicio; 

        public Panel PanelInicio
        {
            set { this.panelInicio = value; } 
        }

        private void FrmTablaEstablecimiento_Load(object sender, EventArgs e)
        {
            CargarUsuariosEnDataGrid();
        }
        private void CargarUsuariosEnDataGrid()
        {
            string connectionString = "server=LAPTOP-RVC8PUD8\\SQLEXPRESS; database=BD_Final; integrated security=true";
            string query = "SELECT * FROM Establecimiento ORDER BY id"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewTabla.DataSource = dataTable;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
                    }
                }
            }
        }

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            foreach (Control control in this.panelInicio.Controls)
            {
                if (control is Form formulario)
                {
                    formulario.Close();
                }
            }

            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            this.panelInicio.Controls.Add(formularioHijo);
            this.panelInicio.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void dataGridViewTabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (rolUsuario == "Admin")
                {
                    DataGridViewRow row = dataGridViewTabla.Rows[e.RowIndex];
                    float id = Convert.ToSingle(row.Cells["id"].Value);

                    FrmActualizar frmActualizar = new FrmActualizar(id);
                    AbrirFormularioHijo(frmActualizar);
                }
                else
                {
                    MessageBox.Show("No tienes permiso para actualizar este registro.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection("server=LAPTOP-RVC8PUD8\\SQLEXPRESS; database=BD_Final; integrated security=true"))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT * FROM Establecimiento WHERE 1=1";

                    List<SqlParameter> parametros = new List<SqlParameter>();

                    if (!string.IsNullOrWhiteSpace(txtId.Text))
                    {
                        query += " AND id = @id";
                        parametros.Add(new SqlParameter("@id", Convert.ToSingle(txtId.Text)));
                    }
                    if (!string.IsNullOrWhiteSpace(txtClee.Text))
                    {
                        query += " AND clee LIKE @clee";
                        parametros.Add(new SqlParameter("@clee", "%" + txtClee.Text + "%"));
                    }
                    if (!string.IsNullOrWhiteSpace(txtNom_estab.Text))
                    {
                        query += " AND nom_estab LIKE @nom_estab";
                        parametros.Add(new SqlParameter("@nom_estab", "%" + txtNom_estab.Text + "%"));
                    }
                    if (!string.IsNullOrWhiteSpace(txRaz_social.Text))
                    {
                        query += " AND raz_social LIKE @raz_social";
                        parametros.Add(new SqlParameter("@raz_social", "%" + txRaz_social.Text + "%"));
                    }
                    if (!string.IsNullOrWhiteSpace(txtTelefono.Text))
                    {
                        query += " AND telefono = @telefono";
                        parametros.Add(new SqlParameter("@telefono", Convert.ToSingle(txtTelefono.Text)));
                    }
                    if (!string.IsNullOrWhiteSpace(txtWww.Text))
                    {
                        query += " AND www LIKE @www";
                        parametros.Add(new SqlParameter("@www", "%" + txtWww.Text + "%"));
                    }
                    if (!string.IsNullOrWhiteSpace(txtCorreoelec.Text))
                    {
                        query += " AND correoelec LIKE @correoelec";
                        parametros.Add(new SqlParameter("@correoelec", "%" + txtCorreoelec.Text + "%"));
                    }
                    if (!string.IsNullOrWhiteSpace(txtTipoUniEco.Text))
                    {
                        query += " AND tipoUniEco LIKE @tipoUniEco";
                        parametros.Add(new SqlParameter("@tipoUniEco", "%" + txtTipoUniEco.Text + "%"));
                    }
                    if (!string.IsNullOrWhiteSpace(texFecha_alta.Text))
                    {
                        query += " AND fecha_alta LIKE @fecha_alta";
                        parametros.Add(new SqlParameter("@fecha_alta", "%" + texFecha_alta.Text + "%"));
                    }
                    if (!string.IsNullOrWhiteSpace(txtCodigo_act.Text))
                    {
                        query += " AND codigo_act = @codigo_act";
                        parametros.Add(new SqlParameter("@codigo_act", Convert.ToSingle(txtCodigo_act.Text)));
                    }
                    if (!string.IsNullOrWhiteSpace(txtPer_ocu.Text))
                    {
                        query += " AND per_ocu LIKE @per_ocu";
                        parametros.Add(new SqlParameter("@per_ocu", "%" + txtPer_ocu.Text + "%"));
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddRange(parametros.ToArray());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewTabla.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
