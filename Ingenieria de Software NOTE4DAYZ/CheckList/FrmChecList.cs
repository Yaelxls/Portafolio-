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

namespace NOTE4DAYZ.CheckList
{
    public partial class FrmChecList : Form
    {
        public FrmChecList()
        {
            InitializeComponent();
        }

        private void CargarNotas()
        {
            string connectionString = SesionUsuario.CadenaConexion;
            string query = @"
    SELECT N.idNota, N.titulo, N.fechaLimite, C.No_Completado, C.Completado
    FROM Nota N
    LEFT JOIN CheckList C ON N.idNota = C.idNota
    WHERE N.id = @id";

            DataTable dtNotas = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", SesionUsuario.IdUsuario);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtNotas);
                }
            }

            dgvNotas.DataSource = dtNotas;
            dgvNotas.ClearSelection(); 
        }
        private void CompletarNota()
        {
            if (dgvNotas.SelectedRows.Count > 0)
            {
                int idNota = Convert.ToInt32(dgvNotas.SelectedRows[0].Cells["idNota"].Value);

                // Verifica si el valor es DBNull antes de convertir
                bool esCompletado = dgvNotas.SelectedRows[0].Cells["Completado"].Value != DBNull.Value
                                    && Convert.ToBoolean(dgvNotas.SelectedRows[0].Cells["Completado"].Value);

                string connectionString = SesionUsuario.CadenaConexion;
                string query = @"
            IF EXISTS (SELECT 1 FROM CheckList WHERE idNota = @idNota)
                UPDATE CheckList 
                SET No_Completado = @No_Completado, 
                    Completado = @Completado, 
                    fechaCompletado = @fechaCompletado 
                WHERE idNota = @idNota;
            ELSE
                INSERT INTO CheckList (No_Completado, Completado, fechaCompletado, idNota) 
                VALUES (@No_Completado, @Completado, @fechaCompletado, @idNota);";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idNota", idNota);
                        command.Parameters.AddWithValue("@Completado", esCompletado ? 1 : 0);
                        command.Parameters.AddWithValue("@No_Completado", esCompletado ? 0 : 1);
                        command.Parameters.AddWithValue("@fechaCompletado", DateTime.Now);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cambios guardados.");
                CargarNotas();
            }
            else
            {
                MessageBox.Show("Selecciona una nota para completar.");
            }
        }

        private void btnCargarNotas_Click(object sender, EventArgs e)
        {

        }

        private void btnCompletarNota_Click(object sender, EventArgs e)
        {
            CompletarNota();
        }
        private void PersonalizarDataGridView()
        {
            dgvNotas.Columns["idNota"].Visible = false; // Ocultar columna ID
        }

        private void FrmChecList_Load(object sender, EventArgs e)
        {
            CargarNotas();
            PersonalizarDataGridView();
        }
    }

}
