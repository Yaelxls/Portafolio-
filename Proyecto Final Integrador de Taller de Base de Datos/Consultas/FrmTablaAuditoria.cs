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

namespace Proyecto_Final.Consultas
{
    public partial class FrmTablaAuditoria : Form
    {
        public FrmTablaAuditoria()
        {
            InitializeComponent();
        }
        private void CargarUsuariosEnDataGrid()
        {
            string connectionString = "server=LAPTOP-RVC8PUD8\\SQLEXPRESS; database=BD_Final; integrated security=true";
            string query = "SELECT * FROM Establecimiento_Audit";

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

        private void FrmTablaAuditoria_Load(object sender, EventArgs e)
        {
            CargarUsuariosEnDataGrid();
        }
    }
}
