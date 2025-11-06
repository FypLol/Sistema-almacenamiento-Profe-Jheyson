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
    public partial class frm_registrarpaquete : Form
    {
        // 🔹 Cola y Pila globales
        ColaPaquetes colaPaquetes = new ColaPaquetes();
        PilaHistorial pilaHistorial = new PilaHistorial();

        public frm_registrarpaquete()
        {
            InitializeComponent();
        }

        private void frm_registrarpaquete_Load(object sender, EventArgs e)
        {
            // Crear columnas en el DataGridView
            CrearColumnasGrid();

            // Cargar tamaños disponibles
            cmbTamaño.Items.AddRange(new string[] { "Pequeño", "Mediano", "Grande" });

            // Actualizar tabla con datos desde la base
            actualizarTabla();
        }

        // 🧱 Crear columnas del DataGridView
        private void CrearColumnasGrid()
        {
            dgvRegistrarPaquetes.Columns.Clear();
            dgvRegistrarPaquetes.Columns.Add("colNombre", "Nombre Destinatario");
            dgvRegistrarPaquetes.Columns.Add("colTelefono", "Teléfono");
            dgvRegistrarPaquetes.Columns.Add("colTamaño", "Tamaño");
            dgvRegistrarPaquetes.Columns.Add("colDNI", "DNI");
            dgvRegistrarPaquetes.Columns.Add("colFecha", "Fecha Registro");
            dgvRegistrarPaquetes.Columns.Add("colEstado", "Estado");

            dgvRegistrarPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistrarPaquetes.AllowUserToAddRows = false;
            dgvRegistrarPaquetes.ReadOnly = true;
        }

        // 📦 Registrar (encolar) paquete
        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            string nombre = tboxNombre.Text.Trim();
            string telefono = tboxTelefono.Text.Trim();
            string tamaño = cmbTamaño.Text.Trim();
            string dni = tboxDNI.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) ||
                string.IsNullOrEmpty(tamaño) || string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("⚠️ Por favor completa todos los campos antes de registrar.",
                                "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Encolar y guardar en BD
            colaPaquetes.Encolar(nombre, telefono, tamaño, dni, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            MessageBox.Show("📦 Paquete registrado correctamente y guardado en la base de datos.",
                            "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCamposRegistro();
            actualizarTabla();
        }

        // 🧾 Liberar (entregar) el primer paquete de la cola
        private void btn_Liberar_Click(object sender, EventArgs e)
        {
            Nodo paquete = colaPaquetes.Desencolar();

            if (paquete != null)
            {
                pilaHistorial.Apilar(paquete);
                MessageBox.Show($"✅ Paquete de {paquete.NombreDestinatario} (DNI: {paquete.DNI}) ha sido entregado.",
                                "Entrega Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarTabla();
            }
            else
            {
                MessageBox.Show("⚠️ No hay paquetes pendientes.",
                                "Cola vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 🧹 Limpiar campos del formulario
        private void LimpiarCamposRegistro()
        {
            tboxNombre.Clear();
            tboxTelefono.Clear();
            tboxDNI.Clear();
            cmbTamaño.SelectedIndex = -1;
        }

        // 🔄 Actualizar tabla con datos de la base
        private void actualizarTabla()
        {
            if (dgvRegistrarPaquetes != null)
            {
                colaPaquetes.MostrarEnGrid(dgvRegistrarPaquetes);
            }
        }

        // Eventos del DataGridView (opcionales)
        private void dgvRegistrarPaquetes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) { }
        private void dgvRegistrarPaquetes_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvRegistrarPaquetes_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void tboxNombre_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}