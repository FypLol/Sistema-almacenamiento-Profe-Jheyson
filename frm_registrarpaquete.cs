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
        
        public frm_registrarpaquete()
        {
            InitializeComponent();
        }

        private void frm_registrarpaquete_Load(object sender, EventArgs e)
        {
                       
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
        }

        private void btnRegistrarP_Click(object sender, EventArgs e)
        { 
           
        }

        private void btn_Liberar_Click(object sender, EventArgs e)
        {
           
        }

        private void actualizarTabla()
        {
            
        }

        private void LimpiarCamposRegistro()
        {
            
        }

        private void dgvRegistrarPaquetes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void dgvRegistrarPaquetes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRegistrarPaquetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tboxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}      

