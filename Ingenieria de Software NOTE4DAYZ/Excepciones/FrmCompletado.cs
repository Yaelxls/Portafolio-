using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTE4DAYZ
{
    public partial class FrmCompletado : Form
    {
        public FrmCompletado()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            NOTE4DAYZ inicioLogin = new NOTE4DAYZ();
            inicioLogin.Show();
            this.Close();

        }
    }
}
