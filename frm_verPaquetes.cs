using System;
using System.Windows.Forms;

namespace SistAlmacenamientoProfeJheyson
{
    public partial class frm_verPaquetes : Form
    {
        // 📦 Referencia a la cola actual (recibida desde frm_panelAdmin)
        private ColaPaquetes cola;

        public frm_verPaquetes(ColaPaquetes colaPaquetes)
        {
            InitializeComponent();
            cola = colaPaquetes;
        }

        private void frm_verPaquetes_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            MostrarPaquetes();
        }

        // 🟦 Configuración visual del DataGridView
        private void ConfigurarDataGridView()
        {
            dgvVerPaquetes.Columns.Clear();
            dgvVerPaquetes.Columns.Add("colNombre", "Nombre Destinatario");
            dgvVerPaquetes.Columns.Add("colTelefono", "Teléfono");
            dgvVerPaquetes.Columns.Add("colTamaño", "Tamaño");
            dgvVerPaquetes.Columns.Add("colFecha", "Fecha Registro");

            dgvVerPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVerPaquetes.AllowUserToAddRows = false;
            dgvVerPaquetes.ReadOnly = true;
            dgvVerPaquetes.RowHeadersVisible = false;
            dgvVerPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVerPaquetes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVerPaquetes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // 🔄 Mostrar los paquetes actuales en la cola
        private void MostrarPaquetes()
        {
            if (cola != null)
            {
                cola.MostrarEnGrid(dgvVerPaquetes);

                if (dgvVerPaquetes.Rows.Count == 0)
                {
                    lblMensaje.Visible = true;
                }
                else
                {
                    lblMensaje.Visible = false;
                }
            }
        }

        // 🔙 Cerrar ventana
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Oculta esta ventana
            frm_panelAdmin menu = new frm_panelAdmin();
            menu.Show(); // Abre el menú principal
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
