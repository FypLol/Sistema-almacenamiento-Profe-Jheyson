namespace SistAlmacenamientoProfeJheyson
{
    partial class frm_LiberarEntregarPaquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LiberarEntregarPaquete));
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.btn_DNI = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_VerTodos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnRegistrar.Location = new System.Drawing.Point(272, 382);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(275, 45);
            this.BtnRegistrar.TabIndex = 0;
            this.BtnRegistrar.Text = "Entregado / Liberar Espacio";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // btn_DNI
            // 
            this.btn_DNI.AutoSize = true;
            this.btn_DNI.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DNI.Location = new System.Drawing.Point(222, 33);
            this.btn_DNI.Name = "btn_DNI";
            this.btn_DNI.Size = new System.Drawing.Size(38, 17);
            this.btn_DNI.TabIndex = 2;
            this.btn_DNI.Text = "DNI";
            this.btn_DNI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_DNI.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 274);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_buscar.Location = new System.Drawing.Point(525, 32);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(91, 23);
            this.Btn_buscar.TabIndex = 6;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_VerTodos
            // 
            this.Btn_VerTodos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_VerTodos.Location = new System.Drawing.Point(656, 32);
            this.Btn_VerTodos.Name = "Btn_VerTodos";
            this.Btn_VerTodos.Size = new System.Drawing.Size(90, 23);
            this.Btn_VerTodos.TabIndex = 7;
            this.Btn_VerTodos.Text = "Ver todos";
            this.Btn_VerTodos.UseVisualStyleBackColor = false;
            this.Btn_VerTodos.Click += new System.EventHandler(this.Btn_VerTodos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_LiberarEntregarPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_VerTodos);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_DNI);
            this.Controls.Add(this.BtnRegistrar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_LiberarEntregarPaquete";
            this.Text = "frm_LiberarEntregarPaquete";
            this.TransparencyKey = System.Drawing.Color.Gray;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label btn_DNI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_VerTodos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}