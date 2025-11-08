using System;
using System.Windows.Forms;

namespace SistAlmacenamientoProfeJheyson
{
    public partial class frm_LiberarEntregarPaquete : Form
    {
        private ColaPaquetes cola;
        private PilaHistorial pila;
        private ListaHistorial lista;

        // 🔹 Constructor principal
        public frm_LiberarEntregarPaquete(ColaPaquetes colaCompartida, PilaHistorial pilaCompartida, ListaHistorial listaCompartida)
        {
            InitializeComponent();
            cola = colaCompartida;
            pila = pilaCompartida;
            lista = listaCompartida;
        }

        // 🚀 Al cargar la ventana
        private void frm_LiberarEntregarPaquete_Load(object sender, EventArgs e)
        {
            // ⚙️ Reconstruir la cola con los paquetes pendientes desde la BD
            cola = new ColaPaquetes();

            ConfigurarTabla();
            MostrarCola();
        }

        // ⚙️ Configurar la tabla
        private void ConfigurarTabla()
        {
            dgvPaquetes.Columns.Clear();
            dgvPaquetes.Columns.Add("colNombre", "Nombre");
            dgvPaquetes.Columns.Add("colTelefono", "Teléfono");
            dgvPaquetes.Columns.Add("colTamaño", "Tamaño");
            dgvPaquetes.Columns.Add("colDNI", "DNI");
            dgvPaquetes.Columns.Add("colFecha", "Fecha Ingreso");
            dgvPaquetes.Columns.Add("colEstado", "Estado");

            dgvPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaquetes.AllowUserToAddRows = false;
            dgvPaquetes.ReadOnly = true;
            dgvPaquetes.RowHeadersVisible = false;
            dgvPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // 🔁 Mostrar cola actual (solo pendientes)
        private void MostrarCola()
        {
            if (cola != null)
            {
                cola.MostrarEnGrid(dgvPaquetes);
                lblMsgVacio.Visible = dgvPaquetes.Rows.Count == 0;
            }
        }

        // 🔍 Buscar
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

        // 🔄 Mostrar todos
        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            MostrarCola();
        }

        // 🟩 Entregar paquete
        // 🟩 Entregar paquete
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (cola == null || pila == null)
            {
                MessageBox.Show("⚠️ Las estructuras no están inicializadas correctamente.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Nodo paquete = cola.Desencolar(); // Elimina el primero de la cola

            if (paquete != null)
            {
                // Guardar en pila y lista (historial)
                pila.Apilar(paquete);
                lista.InsertarFinal(paquete.NombreDestinatario, paquete.Telefono, paquete.Tamaño, paquete.DNI, paquete.FechaIngreso);

                MessageBox.Show($"✅ Paquete de {paquete.NombreDestinatario} entregado correctamente.",
                                "Entrega Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la tabla
                MostrarCola();
            }
            else
            {
                MessageBox.Show("⚠️ No hay paquetes pendientes.",
                                "Cola Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // 🔙 Volver al menú
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            
            if (this.Owner != null)
            {
                this.Owner.Show();
            }

            
        }

    }
}
