using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistAlmacenamientoProfeJheyson
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_loginLoad(object sender, EventArgs e)
        {
            BDHelper.Inicializar(); // Se encarga de todo (usuarios + paquetes)
        }

        // Botón de inicio de sesión
        private void btn_iniciarsesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(BDHelper.CadenaConexion))
                {
                    conexion.Open();

                    string query = "SELECT COUNT(*) FROM usuarios WHERE usuario=@usuario AND contrasena=@contrasena";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("✅ Inicio de sesión exitoso",
                                            "Bienvenido",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            frm_panelAdmin panel = new frm_panelAdmin();
                            panel.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("❌ Usuario o contraseña incorrectos.",
                                            "Error de inicio de sesión",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error al conectar con la base de datos:\n" + ex.Message,
                                "Error de conexión",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn_registrarUsuario_Click(object sender, EventArgs e)
        {
            frm_registroUsuario registro = new frm_registroUsuario();
            registro.ShowDialog();
        }

        // Otros eventos opcionales
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
    }
}
