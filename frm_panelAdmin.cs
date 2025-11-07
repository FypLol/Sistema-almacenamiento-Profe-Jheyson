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
    // 🧩 Estructuras compartidas (pila, cola y lista)
    private PilaHistorial pilaHistorial = new PilaHistorial(); // registrar (pila)
    private ColaPaquetes colaPaquetes = new ColaPaquetes();     // ver (cola)
    private ListaHistorial listaHistorial = new ListaHistorial(); // historial (lista)

    public frm_panelAdmin()
    {
        InitializeComponent();
    }

    // 🚀 Se ejecuta al cargar el formulario
    private void frm_panelAdmin_Load(object sender, EventArgs e)
    {
        this.Text = "Panel de Administración - Sistema de Almacenamiento";
    }

    // 🟦 BOTÓN: Registrar Paquete (usa PILA)
    private void btn_VRegistrar_Click(object sender, EventArgs e)
    {
        var frm = new frm_registrarpaquete();
        frm.ShowDialog();
    }

    // 🟩 BOTÓN: Ver Paquetes (usa COLA)
    private void button2_Click(object sender, EventArgs e)
    {
        var frm = new frm_verPaquetes(colaPaquetes);
        frm.ShowDialog();
    }

        // 🟨 BOTÓN: Liberar / Entregar Paquete (desencolar de COLA)
        private void button3_Click(object sender, EventArgs e)
        {
            // Desencola el primer paquete de la cola
            Nodo entregado = colaPaquetes.Desencolar();

            if (entregado != null)
            {
                // Agregar el paquete entregado al historial (LISTA)
                listaHistorial.Agregar(entregado);

                MessageBox.Show(
                    $"✅ Paquete de {entregado.NombreDestinatario} entregado correctamente.",
                    "Entrega Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "⚠️ No hay paquetes en espera.",
                    "Cola Vacía",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // 🟪 BOTÓN: Historial de Paquetes (usa LISTA enlazada)
        private void button1_Click(object sender, EventArgs e)
        {
            // Muestra los paquetes entregados (LISTA)
            var frm = new frm_historial(listaHistorial);
            frm.ShowDialog();
        }

    }
}