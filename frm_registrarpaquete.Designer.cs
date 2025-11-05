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
            this.btnRegistrarP = new System.Windows.Forms.Button();
            this.dgvRegistrarPaquetes = new System.Windows.Forms.DataGridView();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxTelefono = new System.Windows.Forms.TextBox();
            this.cmbTamaño = new System.Windows.Forms.ComboBox();
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
            this.lbl_nombreDestinatario.Location = new System.Drawing.Point(173, 105);
            this.lbl_nombreDestinatario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombreDestinatario.Name = "lbl_nombreDestinatario";
            this.lbl_nombreDestinatario.Size = new System.Drawing.Size(208, 25);
            this.lbl_nombreDestinatario.TabIndex = 0;
            this.lbl_nombreDestinatario.Text = "Nombre Destinatario";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero.Location = new System.Drawing.Point(818, 117);
            this.lbl_Numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(157, 22);
            this.lbl_Numero.TabIndex = 1;
            this.lbl_Numero.Text = "Numero telefono";
            // 
            // lbl_tamañoP
            // 
            this.lbl_tamañoP.AutoSize = true;
            this.lbl_tamañoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tamañoP.Location = new System.Drawing.Point(174, 200);
            this.lbl_tamañoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tamañoP.Name = "lbl_tamañoP";
            this.lbl_tamañoP.Size = new System.Drawing.Size(188, 22);
            this.lbl_tamañoP.TabIndex = 2;
            this.lbl_tamañoP.Text = "Tamaño de paquete";
            // 
            // btnRegistrarP
            // 
            this.btnRegistrarP.BackColor = System.Drawing.Color.GreenYellow;
            this.btnRegistrarP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarP.FlatAppearance.BorderSize = 0;
            this.btnRegistrarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarP.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarP.Location = new System.Drawing.Point(525, 296);
            this.btnRegistrarP.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrarP.Name = "btnRegistrarP";
            this.btnRegistrarP.Size = new System.Drawing.Size(364, 69);
            this.btnRegistrarP.TabIndex = 4;
            this.btnRegistrarP.Text = "Registrar Paquetes";
            this.btnRegistrarP.UseVisualStyleBackColor = false;
            this.btnRegistrarP.Click += new System.EventHandler(this.btnRegistrarP_Click);
            // 
            // dgvRegistrarPaquetes
            // 
            this.dgvRegistrarPaquetes.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvRegistrarPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrarPaquetes.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRegistrarPaquetes.Location = new System.Drawing.Point(90, 389);
            this.dgvRegistrarPaquetes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRegistrarPaquetes.Name = "dgvRegistrarPaquetes";
            this.dgvRegistrarPaquetes.RowHeadersWidth = 51;
            this.dgvRegistrarPaquetes.Size = new System.Drawing.Size(1180, 214);
            this.dgvRegistrarPaquetes.TabIndex = 6;
            this.dgvRegistrarPaquetes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrarPaquetes_CellClick);
            this.dgvRegistrarPaquetes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrarPaquetes_CellContentClick);
            this.dgvRegistrarPaquetes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRegistrarPaquetes_CellFormatting);
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(415, 106);
            this.tboxNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(253, 26);
            this.tboxNombre.TabIndex = 7;
            this.tboxNombre.TextChanged += new System.EventHandler(this.tboxNombre_TextChanged);
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Location = new System.Drawing.Point(993, 117);
            this.tboxTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(271, 26);
            this.tboxTelefono.TabIndex = 9;
            // 
            // cmbTamaño
            // 
            this.cmbTamaño.FormattingEnabled = true;
            this.cmbTamaño.Location = new System.Drawing.Point(415, 194);
            this.cmbTamaño.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTamaño.Name = "cmbTamaño";
            this.cmbTamaño.Size = new System.Drawing.Size(253, 28);
            this.cmbTamaño.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(90, 163);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(755, 93);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(993, 196);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 26);
            this.textBox1.TabIndex = 15;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.Location = new System.Drawing.Point(818, 200);
            this.lbl_dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(43, 22);
            this.lbl_dni.TabIndex = 16;
            this.lbl_dni.Text = "DNI";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(755, 184);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // frm_registrarpaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1379, 640);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbTamaño);
            this.Controls.Add(this.tboxTelefono);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.dgvRegistrarPaquetes);
            this.Controls.Add(this.btnRegistrarP);
            this.Controls.Add(this.lbl_tamañoP);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.lbl_nombreDestinatario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.DataGridView dgvRegistrarPaquetes;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.ComboBox cmbTamaño;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRegistrarP;
    }
}