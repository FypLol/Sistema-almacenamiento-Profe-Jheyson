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
            CrearTablaUsuariosSiNoExiste();
        }

        //  Crea la tabla "usuarios" si no existe
        private void CrearTablaUsuariosSiNoExiste()
        {
            string rutaDB = "usuarios.db";

            try
            {
                // Si no existe el archivo, lo crea desde cero
                if (!File.Exists(rutaDB))
                {
                    SQLiteConnection.CreateFile(rutaDB);
                }

                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + rutaDB + ";Version=3;"))
                {
                    conn.Open();

                    string sql = @"CREATE TABLE IF NOT EXISTS usuarios (
                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                usuario TEXT NOT NULL,
                                contrasena TEXT NOT NULL
                           );";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Crear usuario admin si no existe
                    sql = "SELECT COUNT(*) FROM usuarios WHERE usuario = 'admin';";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            sql = "INSERT INTO usuarios (usuario, contrasena) VALUES ('admin', '1234');";
                            using (SQLiteCommand insertCmd = new SQLiteCommand(sql, conn))
                            {
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // 🔧 Si el archivo está corrupto, se elimina y se vuelve a crear
                if (ex.Message.Contains("file is not a database"))
                {
                    MessageBox.Show("⚠️ El archivo 'usuarios.db' estaba dañado. Se regenerará automáticamente.",
                                    "Reparación de Base de Datos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                    File.Delete(rutaDB); // borra el archivo dañado
                    SQLiteConnection.CreateFile(rutaDB); // crea uno nuevo limpio
                    CrearTablaUsuariosSiNoExiste(); // vuelve a generar estructura y admin
                }
                else
                {
                    MessageBox.Show("Error de base de datos:\n" + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                string cadenaConexion = "Data Source=usuarios.db;Version=3;";

                using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
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

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void btn_registrarUsuario_Click(object sender, EventArgs e)
        {
            frm_registroUsuario registro = new frm_registroUsuario();
            registro.ShowDialog();
        }
    }
}
