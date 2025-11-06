using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SistAlmacenamientoProfeJheyson
{
    public partial class frm_registroUsuario : Form
    {
        public frm_registroUsuario()
        {
            InitializeComponent();
        }

        private void frm_registroUsuario_Load(object sender, EventArgs e)
        {
            this.Text = "Registro de Usuario - Sistema de Almacenamiento";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            string confirmar = txtConfirmar.Text.Trim();

            if (usuario == "" || contrasena == "" || confirmar == "")
            {
                MessageBox.Show("Por favor, completa todos los campos.",
                                "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contrasena != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string cadenaConexion = BDHelper.CadenaConexion;

                using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Verificar si el usuario ya existe
                    string checkQuery = "SELECT COUNT(*) FROM usuarios WHERE usuario=@usuario";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conexion))
                    {
                        checkCmd.Parameters.AddWithValue("@usuario", usuario);
                        int existe = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show("⚠️ Este usuario ya existe.",
                                            "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insertar nuevo usuario
                    string insertQuery = "INSERT INTO usuarios (usuario, contrasena) VALUES (@usuario, @contrasena)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("✅ Usuario registrado correctamente.",
                                        "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
