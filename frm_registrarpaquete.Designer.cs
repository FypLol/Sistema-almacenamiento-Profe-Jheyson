namespace SistAlmacenamientoProfeJheyson
{
    partial class frm_registrarpaquete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registrarpaquete));
            this.lbl_nombreDestinatario = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_tamañoP = new System.Windows.Forms.Label();
            this.lbl_codigoLiberar = new System.Windows.Forms.Label();
            this.btnRegistrarP = new System.Windows.Forms.Button();
            this.btn_Liberar = new System.Windows.Forms.Button();
            this.dgvRegistrarPaquetes = new System.Windows.Forms.DataGridView();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxTelefono = new System.Windows.Forms.TextBox();
            this.cmbTamaño = new System.Windows.Forms.ComboBox();
            this.tboxCodigoLiberar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarPaquetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombreDestinatario
            // 
            this.lbl_nombreDestinatario.AutoSize = true;
            this.lbl_nombreDestinatario.Location = new System.Drawing.Point(162, 69);
            this.lbl_nombreDestinatario.Name = "lbl_nombreDestinatario";
            this.lbl_nombreDestinatario.Size = new System.Drawing.Size(103, 13);
            this.lbl_nombreDestinatario.TabIndex = 0;
            this.lbl_nombreDestinatario.Text = "Nombre Destinatario";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(663, 76);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(85, 13);
            this.lbl_Numero.TabIndex = 1;
            this.lbl_Numero.Text = "Numero telefono";
            // 
            // lbl_tamañoP
            // 
            this.lbl_tamañoP.AutoSize = true;
            this.lbl_tamañoP.Location = new System.Drawing.Point(172, 133);
            this.lbl_tamañoP.Name = "lbl_tamañoP";
            this.lbl_tamañoP.Size = new System.Drawing.Size(103, 13);
            this.lbl_tamañoP.TabIndex = 2;
            this.lbl_tamañoP.Text = "Tamaño de paquete";
            // 
            // lbl_codigoLiberar
            // 
            this.lbl_codigoLiberar.AutoSize = true;
            this.lbl_codigoLiberar.Location = new System.Drawing.Point(185, 204);
            this.lbl_codigoLiberar.Name = "lbl_codigoLiberar";
            this.lbl_codigoLiberar.Size = new System.Drawing.Size(80, 13);
            this.lbl_codigoLiberar.TabIndex = 3;
            this.lbl_codigoLiberar.Text = "Código a liberar";
            // 
            // btnRegistrarP
            // 
            this.btnRegistrarP.Location = new System.Drawing.Point(766, 115);
            this.btnRegistrarP.Name = "btnRegistrarP";
            this.btnRegistrarP.Size = new System.Drawing.Size(243, 45);
            this.btnRegistrarP.TabIndex = 4;
            this.btnRegistrarP.Text = "Registrar Paquetes";
            this.btnRegistrarP.UseVisualStyleBackColor = true;
            this.btnRegistrarP.Click += new System.EventHandler(this.btnRegistrarP_Click);
            // 
            // btn_Liberar
            // 
            this.btn_Liberar.Location = new System.Drawing.Point(766, 188);
            this.btn_Liberar.Name = "btn_Liberar";
            this.btn_Liberar.Size = new System.Drawing.Size(243, 45);
            this.btn_Liberar.TabIndex = 5;
            this.btn_Liberar.Text = "Liberar espacio";
            this.btn_Liberar.UseVisualStyleBackColor = true;
            this.btn_Liberar.Click += new System.EventHandler(this.btn_Liberar_Click);
            // 
            // dgvRegistrarPaquetes
            // 
            this.dgvRegistrarPaquetes.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvRegistrarPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrarPaquetes.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRegistrarPaquetes.Location = new System.Drawing.Point(54, 271);
            this.dgvRegistrarPaquetes.Name = "dgvRegistrarPaquetes";
            this.dgvRegistrarPaquetes.Size = new System.Drawing.Size(1040, 285);
            this.dgvRegistrarPaquetes.TabIndex = 6;
            this.dgvRegistrarPaquetes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrarPaquetes_CellClick);
            this.dgvRegistrarPaquetes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrarPaquetes_CellContentClick);
            this.dgvRegistrarPaquetes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRegistrarPaquetes_CellFormatting);
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(299, 69);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(250, 20);
            this.tboxNombre.TabIndex = 7;
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Location = new System.Drawing.Point(766, 73);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(243, 20);
            this.tboxTelefono.TabIndex = 9;
            // 
            // cmbTamaño
            // 
            this.cmbTamaño.FormattingEnabled = true;
            this.cmbTamaño.Location = new System.Drawing.Point(299, 130);
            this.cmbTamaño.Name = "cmbTamaño";
            this.cmbTamaño.Size = new System.Drawing.Size(250, 21);
            this.cmbTamaño.TabIndex = 10;
            // 
            // tboxCodigoLiberar
            // 
            this.tboxCodigoLiberar.Location = new System.Drawing.Point(299, 201);
            this.tboxCodigoLiberar.Name = "tboxCodigoLiberar";
            this.tboxCodigoLiberar.Size = new System.Drawing.Size(250, 20);
            this.tboxCodigoLiberar.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(118, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(627, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // frm_registrarpaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1129, 582);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tboxCodigoLiberar);
            this.Controls.Add(this.cmbTamaño);
            this.Controls.Add(this.tboxTelefono);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.dgvRegistrarPaquetes);
            this.Controls.Add(this.btn_Liberar);
            this.Controls.Add(this.btnRegistrarP);
            this.Controls.Add(this.lbl_codigoLiberar);
            this.Controls.Add(this.lbl_tamañoP);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.lbl_nombreDestinatario);
            this.Name = "frm_registrarpaquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_registrarpaquete";
            this.Load += new System.EventHandler(this.frm_registrarpaquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarPaquetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreDestinatario;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_tamañoP;
        private System.Windows.Forms.Label lbl_codigoLiberar;
        private System.Windows.Forms.Button btnRegistrarP;
        private System.Windows.Forms.Button btn_Liberar;
        private System.Windows.Forms.DataGridView dgvRegistrarPaquetes;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.ComboBox cmbTamaño;
        private System.Windows.Forms.TextBox tboxCodigoLiberar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}