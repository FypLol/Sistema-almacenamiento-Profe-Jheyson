using System;
using System.Windows.Forms;

namespace SistAlmacenamientoProfeJheyson
{
    public partial class frm_historial : Form
    {
        private ListaHistorial lista;

        public frm_historial(ListaHistorial listaHistorial)
        {
            InitializeComponent();
            lista = listaHistorial;
        }

        private void frm_historial_Load(object sender, EventArgs e)
        {
            ConfigurarTabla();
            MostrarHistorial();
        }

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

        private void MostrarHistorial()
        {
            if (lista != null)
            {
                lista.MostrarEnGrid(dgvHistorial);
                lblMensaje.Visible = dgvHistorial.Rows.Count == 0;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_panelAdmin menu = new frm_panelAdmin();
            menu.Show();
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No hace nada, solo evita el error del diseñador
        }

    }
}
