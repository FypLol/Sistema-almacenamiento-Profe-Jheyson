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
        // 🧩 Estructuras compartidas (cola y pila globales)
        private ColaPaquetes colaPaquetes = new ColaPaquetes();
        private PilaHistorial pilaHistorial = new PilaHistorial();

        public frm_panelAdmin()
        {
            InitializeComponent();
        }

        // 🚀 Método que se ejecuta al cargar el formulario
        private void frm_panelAdmin_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar configuraciones generales del panel
            // Ejemplo: mostrar nombre de usuario o mensaje de bienvenida
            this.Text = "Panel de Administración - Sistema de Almacenamiento";
        }

        // 🟦 BOTÓN: Registrar Paquete
        private void btn_VRegistrar_Click(object sender, EventArgs e)
        {
            // Abre el formulario de registro de paquetes
            var frm = new frm_registrarpaquete();
            frm.ShowDialog();
        }

        // 🟩 BOTÓN: Ver Paquetes (mostrar cola actual)
        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frm_verPaquetes(colaPaquetes);
            frm.ShowDialog();
        }

        // 🟨 BOTÓN: Liberar / Entregar Paquete (desencolar)
        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new frm_LiberarEntregarPaquete(colaPaquetes, pilaHistorial);
            frm.ShowDialog();
        }

        // 🟪 BOTÓN: Historial de Paquetes (mostrar pila de entregados)
        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frm_historial(pilaHistorial);
            frm.ShowDialog();
        }
    }
}