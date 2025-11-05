namespace SistAlmacenamientoProfeJheyson
{
    partial class frm_registroUsuario
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(60, 20);
            this.lblTitulo.Text = "Registrar Nuevo Usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(30, 70);
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            this.lblContrasena.Location = new System.Drawing.Point(30, 110);
            this.lblContrasena.Text = "Contraseña:";
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.Location = new System.Drawing.Point(30, 150);
            this.lblConfirmar.Text = "Confirmar contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(180, 67);
            this.txtUsuario.Width = 150;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(180, 107);
            this.txtContrasena.Width = 150;
            this.txtContrasena.PasswordChar = '*';
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(180, 147);
            this.txtConfirmar.Width = 150;
            this.txtConfirmar.PasswordChar = '*';
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(60, 200);
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(180, 200);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frm_registroUsuario
            // 
            this.ClientSize = new System.Drawing.Size(370, 260);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
