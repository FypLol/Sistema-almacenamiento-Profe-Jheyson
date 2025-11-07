using System;
using System.Windows.Forms;

namespace SistAlmacenamientoProfeJheyson
{
    public partial class frm_LiberarEntregarPaquete : Form
    {
        private ColaPaquetes cola;
        private PilaHistorial pila;

        // 🔹 Constructor principal (sin parámetros)
        public frm_LiberarEntregarPaquete()
        {
            InitializeComponent();
        }

        // 🔹 Constructor que recibe las estructuras compartidas
        public frm_LiberarEntregarPaquete(ColaPaquetes colaCompartida, PilaHistorial pilaCompartida)
        {
            InitializeComponent();
            cola = colaCompartida;
            pila = pilaCompartida;
        }

        // 🚀 Carga inicial del formulario
        private void frm_LiberarEntregarPaquete_Load(object sender, EventArgs e)
        {
            ConfigurarTabla();
            MostrarCola();
        }

        // ⚙️ Configuración del DataGridView
        private void ConfigurarTabla()
        {
            dgvPaquetes.Columns.Clear();
            dgvPaquetes.Columns.Add("colNombre", "Nombre Destinatario");
            dgvPaquetes.Columns.Add("colTelefono", "Teléfono");
            dgvPaquetes.Columns.Add("colTamaño", "Tamaño");
            dgvPaquetes.Columns.Add("colDNI", "DNI");
            dgvPaquetes.Columns.Add("colFecha", "Fecha Registro");
            dgvPaquetes.Columns.Add("colEstado", "Estado");

            dgvPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaquetes.AllowUserToAddRows = false;
            dgvPaquetes.ReadOnly = true;
            dgvPaquetes.RowHeadersVisible = false;
            dgvPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // 📦 Mostrar los paquetes pendientes
        private void MostrarCola()
        {
            if (cola != null)
            {
                cola.MostrarEnGrid(dgvPaquetes);
                lblMsgVacio.Visible = dgvPaquetes.Rows.Count == 0;
            }
        }

        // 🔍 Buscar por nombre o teléfono
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Ingrese un nombre o teléfono para buscar.",
                                "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvPaquetes.ClearSelection();
            bool encontrado = false;

            foreach (DataGridViewRow fila in dgvPaquetes.Rows)
            {
                bool coincide = false;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value != null &&
                        celda.Value.ToString().IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        coincide = true;
                        break;
                    }
                }

                fila.Visible = coincide;
                if (coincide) encontrado = true;
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún paquete con esos datos.",
                                "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 🔄 Ver todos los paquetes nuevamente
        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            MostrarCola();
        }

        // 🟩 Entregar paquete (desencolar)
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (cola == null || pila == null)
            {
                MessageBox.Show("⚠️ Las estructuras no están inicializadas correctamente.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Nodo paquete = cola.Desencolar();

            if (paquete != null)
            {
                pila.Apilar(paquete);
                MessageBox.Show($"✅ Paquete de {paquete.NombreDestinatario} ha sido entregado correctamente.",
                                "Entrega Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarCola();
            }
            else
            {
                MessageBox.Show("⚠️ No hay paquetes en espera.",
                                "Cola Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //  Volver al menú principal
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_panelAdmin menu = new frm_panelAdmin();
            menu.Show();
        }

        private void dgvPaquetes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
