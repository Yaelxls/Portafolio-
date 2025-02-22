using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTE4DAYZ
{
    public partial class PanelInicio : Form
    {
        public PanelInicio()
        {
            InitializeComponent();
        }
        private void IniciarRelojDigital()
        {
            Timer relojTimer = new Timer();
            relojTimer.Interval = 1000;
            relojTimer.Tick += new EventHandler(ActualizarReloj);
            relojTimer.Start();
        }

        private void ActualizarReloj(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void PanelInicio_Load(object sender, EventArgs e)
        {
            IniciarRelojDigital();
        }
    }
}
