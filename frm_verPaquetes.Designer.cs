namespace SistAlmacenamientoProfeJheyson
{
    partial class frm_verPaquetes
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
            this.dgvVerPaquetes = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVerPaquetes
            // 
            this.dgvVerPaquetes.AllowUserToAddRows = false;
            this.dgvVerPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerPaquetes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVerPaquetes.Location = new System.Drawing.Point(0, 0);
            this.dgvVerPaquetes.Name = "dgvVerPaquetes";
            this.dgvVerPaquetes.ReadOnly = true;
            this.dgvVerPaquetes.RowHeadersWidth = 62;
            this.dgvVerPaquetes.RowTemplate.Height = 28;
            this.dgvVerPaquetes.Size = new System.Drawing.Size(800, 351);
            this.dgvVerPaquetes.TabIndex = 0;
            this.dgvVerPaquetes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrar.Location = new System.Drawing.Point(0, 427);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(800, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMensaje.Location = new System.Drawing.Point(0, 351);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(800, 23);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "No hay paquetes registrados actualmente.";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMensaje.Visible = false;
            // 
            // frm_verPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvVerPaquetes);
            this.Name = "frm_verPaquetes";
            this.Text = "frm_verPaquetes";
            this.Load += new System.EventHandler(this.frm_verPaquetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerPaquetes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerPaquetes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblMensaje;
    }
}