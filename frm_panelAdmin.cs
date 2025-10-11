using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistAlmacenamientoProfeJheyson
{
    public partial class frm_panelAdmin : Form
    {
        public frm_panelAdmin()
        {
            InitializeComponent();
        }

        private void btn_VRegistrar_Click(object sender, EventArgs e)
        {
            frm_registrarpaquete frm = new frm_registrarpaquete();
            frm.ShowDialog();
        }
    }
}
