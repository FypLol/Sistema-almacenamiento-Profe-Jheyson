using System;
using System.Windows.Forms;

namespace SistAlmacenamientoProfeJheyson
{
    public partial class frm_historial : Form
    {
        private PilaHistorial pila;

        public frm_historial(PilaHistorial pilaHistorial)
        {
            InitializeComponent();
            pila = pilaHistorial;
        }

        private void frm_historial_Load(object sender, EventArgs e)
        {
            ConfigurarTabla();
            MostrarHistorial();
        }

        // ⚙️ Configura las columnas del DataGridView
        private void ConfigurarTabla()
        {
            dgvHistorial.Columns.Clear();
            dgvHistorial.Columns.Add("colNombre", "Nombre Destinatario");
            dgvHistorial.Columns.Add("colTelefono", "Teléfono");
            dgvHistorial.Columns.Add("colTamaño", "Tamaño");
            dgvHistorial.Columns.Add("colFecha", "Fecha Entrega");

            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHistorial.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // 📦 Muestra el contenido actual de la pila
        private void MostrarHistorial()
        {
            if (pila != null)
            {
                pila.MostrarEnGrid(dgvHistorial);

                lblMensaje.Visible = dgvHistorial.Rows.Count == 0;
            }
        }

        // 🔙 Cerrar ventana
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta esta ventana
            frm_panelAdmin menu = new frm_panelAdmin();
            menu.Show(); // Muestra el menú principal
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}

