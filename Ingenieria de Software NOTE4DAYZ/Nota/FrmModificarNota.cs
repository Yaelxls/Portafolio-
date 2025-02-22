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

namespace NOTE4DAYZ.Nota
{
    public partial class FrmModificarNota : Form
    {
        public FrmModificarNota()
        {
            InitializeComponent();
            
        }

        private void dataGridMoficarNota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarNotas()
        {
            string connectionString = "server=LAPTOP-RVC8PUD8\\SQLEXPRESS; database=NOTE4DAYZ; integrated security=true";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT idNota, titulo, fechaCreacion, fechaModificacion FROM Nota";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridMoficarNota.DataSource = dt;  // Llenar el DataGridView con los datos de la tabla Nota
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar notas: " + ex.Message);
                }
            }
        }

        private void FrmModificarNota_Load(object sender, EventArgs e)
        {
            CargarNotas();
        }

        private void dataGridMoficarNota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridMoficarNota.Rows[e.RowIndex];

                // Extraer el ID de la nota de la fila seleccionada
                int idNota = Convert.ToInt32(filaSeleccionada.Cells["idNota"].Value);

                // Crear una nueva instancia del formulario FrmCrearNota y pasarle el ID de la nota seleccionada
                FrmCrearNota editarNota = new FrmCrearNota(idNota);

                // Configurar el formulario como hijo de FrmInicio
                editarNota.MdiParent = this;  // 'this' se refiere al formulario padre (FrmInicio)

                // Mostrar el formulario
                editarNota.Show();
            }


        }
       
    }
}
