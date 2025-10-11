using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistAlmacenamientoProfeJheyson
{
    public partial class frm_registrarpaquete : Form
    {
        private List<Espacio> listaEspacios = new List<Espacio>();
        public frm_registrarpaquete()
        {
            InitializeComponent();
        }

        private void frm_registrarpaquete_Load(object sender, EventArgs e)
        {
            InicializarEspacios();
            actualizarTabla();
            cmbTamaño.Items.AddRange(new string[] { "Pequeño", "Mediano", "Grande" });
        }

        class Espacio
        {
            public string Codigo { get; set; }  // Ej: A1
            public bool Ocupado { get; set; }
            public string NombreDestinatario { get; set; }
            public string Telefono { get; set; }
            public string Tamaño { get; set; }
            public DateTime? FechaIngreso { get; set; }
        }

        // ---- INICIALIZA LOS ESPACIOS (A1–E5) ----
        private void InicializarEspacios()
        {
            char[] filas = { 'A', 'B', 'C', 'D', 'E' };
            int columnas = 5;

            foreach (char fila in filas)
            {
                for (int col = 1; col <= columnas; col++)
                {
                    string codigo = $"{fila}{col}";
                    listaEspacios.Add(new Espacio
                    {
                        Codigo = codigo,
                        Ocupado = false
                    });
                }
            }
        }

        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            string nombre = tboxNombre.Text.Trim();
            string telefono = tboxTelefono.Text.Trim();
            string tamaño = cmbTamaño.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || tamaño == null)
            {
                MessageBox.Show("Completa todos los campos antes de registrar.");
                return;
            }

            var espacioLibre = listaEspacios.FirstOrDefault(esp => !esp.Ocupado);

            if (espacioLibre != null)
            {
                espacioLibre.Ocupado = true;
                espacioLibre.NombreDestinatario = nombre;
                espacioLibre.Telefono = telefono;
                espacioLibre.Tamaño = tamaño;
                espacioLibre.FechaIngreso = DateTime.Now;

                MessageBox.Show($"✅ Paquete registrado en el espacio {espacioLibre.Codigo}");
                actualizarTabla();
                LimpiarCamposRegistro();
            }
            else
            {
                MessageBox.Show("🚫 No hay espacios disponibles en el almacén.");
            }
        }

        private void btn_Liberar_Click(object sender, EventArgs e)
        {
            string codigo = tboxCodigoLiberar.Text.Trim().ToUpper();
            var espacio = listaEspacios.FirstOrDefault(esp => esp.Codigo == codigo);
            if (espacio != null && espacio.Ocupado)
            {
                espacio.Ocupado = false;
                espacio.NombreDestinatario = null;
                espacio.Telefono = null;
                espacio.Tamaño = null;
                espacio.FechaIngreso = null;

                MessageBox.Show($"✅ Espacio {codigo} liberado correctamente.");
                actualizarTabla();
                tboxCodigoLiberar.Clear();
            }
            else
            {
                MessageBox.Show("🚫 Código inválido o espacio ya está libre.");
            }


        }

        private void actualizarTabla()
        {
            dgvRegistrarPaquetes.DataSource = listaEspacios.Select(e => new
            {
                e.Codigo,
                Estado = e.Ocupado ? "Ocupado" : "Libre",
                e.NombreDestinatario,
                e.Telefono,
                e.Tamaño,
                FechaIngreso = e.FechaIngreso?.ToString("g") ?? ""
            }).ToList();

            dgvRegistrarPaquetes.ClearSelection();
        }

        private void LimpiarCamposRegistro()
        {
            tboxNombre.Clear();
            tboxTelefono.Clear();
            cmbTamaño.SelectedIndex = -1;
        }

        private void dgvRegistrarPaquetes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRegistrarPaquetes.Columns[e.ColumnIndex].Name == "Estado" && e.Value != null)
            {
                if (e.Value.ToString() == "Ocupado")
                    e.CellStyle.BackColor = Color.LightCoral;
                else
                    e.CellStyle.BackColor = Color.LightGreen;
            }
        }

        private void dgvRegistrarPaquetes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRegistrarPaquetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow fila = dgvRegistrarPaquetes.Rows[e.RowIndex];

                // Coloca el código del espacio en el TextBox
                tboxCodigoLiberar.Text = fila.Cells["Codigo"].Value?.ToString();
            }
        }

    }
    
}      

