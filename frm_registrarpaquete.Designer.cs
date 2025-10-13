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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarPaquetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombreDestinatario
            // 
            this.lbl_nombreDestinatario.AutoSize = true;
            this.lbl_nombreDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreDestinatario.Location = new System.Drawing.Point(191, 85);
            this.lbl_nombreDestinatario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombreDestinatario.Name = "lbl_nombreDestinatario";
            this.lbl_nombreDestinatario.Size = new System.Drawing.Size(183, 20);
            this.lbl_nombreDestinatario.TabIndex = 0;
            this.lbl_nombreDestinatario.Text = "Nombre Destinatario";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero.Location = new System.Drawing.Point(861, 91);
            this.lbl_Numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(134, 18);
            this.lbl_Numero.TabIndex = 1;
            this.lbl_Numero.Text = "Numero telefono";
            // 
            // lbl_tamañoP
            // 
            this.lbl_tamañoP.AutoSize = true;
            this.lbl_tamañoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tamañoP.Location = new System.Drawing.Point(191, 164);
            this.lbl_tamañoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tamañoP.Name = "lbl_tamañoP";
            this.lbl_tamañoP.Size = new System.Drawing.Size(156, 18);
            this.lbl_tamañoP.TabIndex = 2;
            this.lbl_tamañoP.Text = "Tamaño de paquete";
            // 
            // lbl_codigoLiberar
            // 
            this.lbl_codigoLiberar.AutoSize = true;
            this.lbl_codigoLiberar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoLiberar.Location = new System.Drawing.Point(208, 249);
            this.lbl_codigoLiberar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigoLiberar.Name = "lbl_codigoLiberar";
            this.lbl_codigoLiberar.Size = new System.Drawing.Size(128, 18);
            this.lbl_codigoLiberar.TabIndex = 3;
            this.lbl_codigoLiberar.Text = "Código a liberar";
            // 
            // btnRegistrarP
            // 
            this.btnRegistrarP.BackColor = System.Drawing.Color.GreenYellow;
            this.btnRegistrarP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarP.FlatAppearance.BorderSize = 0;
            this.btnRegistrarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarP.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarP.Location = new System.Drawing.Point(784, 231);
            this.btnRegistrarP.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrarP.Name = "btnRegistrarP";
            this.btnRegistrarP.Size = new System.Drawing.Size(324, 55);
            this.btnRegistrarP.TabIndex = 4;
            this.btnRegistrarP.Text = "Registrar Paquetes";
            this.btnRegistrarP.UseVisualStyleBackColor = false;
            this.btnRegistrarP.Click += new System.EventHandler(this.btnRegistrarP_Click);
            // 
            // btn_Liberar
            // 
            this.btn_Liberar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Liberar.FlatAppearance.BorderSize = 0;
            this.btn_Liberar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Liberar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Liberar.Location = new System.Drawing.Point(1116, 231);
            this.btn_Liberar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Liberar.Name = "btn_Liberar";
            this.btn_Liberar.Size = new System.Drawing.Size(324, 55);
            this.btn_Liberar.TabIndex = 5;
            this.btn_Liberar.Text = "Liberar espacio";
            this.btn_Liberar.UseVisualStyleBackColor = false;
            this.btn_Liberar.Click += new System.EventHandler(this.btn_Liberar_Click);
            // 
            // dgvRegistrarPaquetes
            // 
            this.dgvRegistrarPaquetes.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvRegistrarPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrarPaquetes.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRegistrarPaquetes.Location = new System.Drawing.Point(72, 334);
            this.dgvRegistrarPaquetes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRegistrarPaquetes.Name = "dgvRegistrarPaquetes";
            this.dgvRegistrarPaquetes.RowHeadersWidth = 51;
            this.dgvRegistrarPaquetes.Size = new System.Drawing.Size(1387, 351);
            this.dgvRegistrarPaquetes.TabIndex = 6;
            this.dgvRegistrarPaquetes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrarPaquetes_CellClick);
            this.dgvRegistrarPaquetes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrarPaquetes_CellContentClick);
            this.dgvRegistrarPaquetes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRegistrarPaquetes_CellFormatting);
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(399, 85);
            this.tboxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(332, 22);
            this.tboxNombre.TabIndex = 7;
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Location = new System.Drawing.Point(1021, 90);
            this.tboxTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(323, 22);
            this.tboxTelefono.TabIndex = 9;
            // 
            // cmbTamaño
            // 
            this.cmbTamaño.FormattingEnabled = true;
            this.cmbTamaño.Location = new System.Drawing.Point(399, 160);
            this.cmbTamaño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTamaño.Name = "cmbTamaño";
            this.cmbTamaño.Size = new System.Drawing.Size(332, 24);
            this.cmbTamaño.TabIndex = 10;
            // 
            // tboxCodigoLiberar
            // 
            this.tboxCodigoLiberar.Location = new System.Drawing.Point(399, 247);
            this.tboxCodigoLiberar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxCodigoLiberar.Name = "tboxCodigoLiberar";
            this.tboxCodigoLiberar.Size = new System.Drawing.Size(332, 22);
            this.tboxCodigoLiberar.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(116, 134);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(800, 85);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1021, 160);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 22);
            this.textBox1.TabIndex = 15;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.Location = new System.Drawing.Point(917, 164);
            this.lbl_dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(36, 18);
            this.lbl_dni.TabIndex = 16;
            this.lbl_dni.Text = "DNI";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(800, 155);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // frm_registrarpaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1471, 691);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.textBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_registrarpaquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_registrarpaquete";
            this.Load += new System.EventHandler(this.frm_registrarpaquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarPaquetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreDestinatario;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_tamañoP;
        private System.Windows.Forms.Label lbl_codigoLiberar;
        private System.Windows.Forms.Button btn_Liberar;
        private System.Windows.Forms.DataGridView dgvRegistrarPaquetes;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.ComboBox cmbTamaño;
        private System.Windows.Forms.TextBox tboxCodigoLiberar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRegistrarP;
    }
}