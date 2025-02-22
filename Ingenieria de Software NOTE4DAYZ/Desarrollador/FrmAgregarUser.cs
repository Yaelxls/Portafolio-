using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTE4DAYZ.Desarrollador
{
    public partial class FrmAgregarUser : Form
    {
        public FrmAgregarUser()
        {
            InitializeComponent();
        }
        private void CargarUsuariosEnDataGrid()
        {
            string connectionString = SesionUsuario.CadenaConexion;
            string query = "SELECT * FROM Usuario";
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

                        dataGridViewNotas.DataSource = dataTable; // Asignar la tabla al DataGridView

                        // Opcional: Configuración adicional del DataGridView
                        ConfigurarDataGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
                    }
                }
            }
        }

        private void ConfigurarDataGrid()
        {
            // Ajustar el diseño del DataGridView (opcional)
            dataGridViewNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNotas.AllowUserToAddRows = false;
            dataGridViewNotas.ReadOnly = true; // Desactivar edición
            dataGridViewNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FrmAgregarUser_Load(object sender, EventArgs e)
        {
            CargarUsuariosEnDataGrid();

        }
    }
}
