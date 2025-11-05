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
        //  Cola de paquetes sin listas ni arrays
        ColaPaquetes colaPaquetes = new ColaPaquetes();
        PilaHistorial pilaHistorial = new PilaHistorial();

        public frm_registrarpaquete()
        {
            InitializeComponent();
        }

        private void frm_registrarpaquete_Load(object sender, EventArgs e)
        {
            //  Crear columnas del DataGridView antes de usarlo
            CrearColumnasGrid();

            //  Cargar opciones del ComboBox
            cmbTamaño.Items.AddRange(new string[] { "Pequeño", "Mediano", "Grande" });

            actualizarTabla();
        }

        //  Método que crea las columnas del DataGridView
        private void CrearColumnasGrid()
        {
            dgvRegistrarPaquetes.Columns.Clear();
            dgvRegistrarPaquetes.Columns.Add("colNombre", "Nombre Destinatario");
            dgvRegistrarPaquetes.Columns.Add("colTelefono", "Teléfono");
            dgvRegistrarPaquetes.Columns.Add("colTamaño", "Tamaño");
            dgvRegistrarPaquetes.Columns.Add("colFecha", "Fecha Registro");

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

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(tamaño))
            {
                MessageBox.Show("⚠️ Por favor completa todos los campos antes de registrar.",
                                "Campos Vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Agregar paquete a la cola
            colaPaquetes.Encolar(nombre, telefono, tamaño, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));

            MessageBox.Show("📦 Paquete registrado correctamente y agregado a la cola.",
                            "Registro exitoso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            LimpiarCamposRegistro();
            actualizarTabla();
        }

        // Liberar  Entregar el primer paquete
        private void btn_Liberar_Click(object sender, EventArgs e)
        {
            Nodo paquete = colaPaquetes.Desencolar();

            if (paquete != null)
            {
                pilaHistorial.Apilar(paquete);
                MessageBox.Show($"✅ Paquete de {paquete.NombreDestinatario} ha sido entregado.",
                                "Entrega Exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                actualizarTabla();
            }
            else
            {
                MessageBox.Show("⚠️ No hay paquetes en espera.",
                                "Cola vacía",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        // 🧹 Limpiar los campos del formulario
        private void LimpiarCamposRegistro()
        {
            tboxNombre.Clear();
            tboxTelefono.Clear();
            cmbTamaño.SelectedIndex = -1;
        }

        // 🔄 Actualiza la tabla con los paquetes actuales
        private void actualizarTabla()
        {
            if (dgvRegistrarPaquetes != null)
            {
                colaPaquetes.MostrarEnGrid(dgvRegistrarPaquetes);
            }
        }

        //
        private void dgvRegistrarPaquetes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) { }
        private void dgvRegistrarPaquetes_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvRegistrarPaquetes_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void tboxNombre_TextChanged(object sender, EventArgs e) { }
    }
}
