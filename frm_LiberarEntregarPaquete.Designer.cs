namespace SistAlmacenamientoProfeJheyson
{
    partial class frm_LiberarEntregarPaquete
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPaquetes;
        private System.Windows.Forms.Label lblMsgVacio;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnVerTodos;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.lblMsgVacio = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnVerTodos = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaquetes.ColumnHeadersHeight = 34;
            this.dgvPaquetes.Location = new System.Drawing.Point(15, 93);
            this.dgvPaquetes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.RowHeadersWidth = 62;
            this.dgvPaquetes.Size = new System.Drawing.Size(942, 333);
            this.dgvPaquetes.TabIndex = 0;
            
            // 
            // lblMsgVacio
            // 
            this.lblMsgVacio.AutoSize = true;
            this.lblMsgVacio.ForeColor = System.Drawing.Color.Gray;
            this.lblMsgVacio.Location = new System.Drawing.Point(13, 69);
            this.lblMsgVacio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsgVacio.Name = "lblMsgVacio";
            this.lblMsgVacio.Size = new System.Drawing.Size(247, 20);
            this.lblMsgVacio.TabIndex = 1;
            this.lblMsgVacio.Text = "No hay paquetes registrados aún.";
            this.lblMsgVacio.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(15, 33);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(256, 26);
            this.txtBuscar.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(283, 32);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(96, 33);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnVerTodos
            // 
            this.BtnVerTodos.Location = new System.Drawing.Point(392, 32);
            this.BtnVerTodos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVerTodos.Name = "BtnVerTodos";
            this.BtnVerTodos.Size = new System.Drawing.Size(116, 33);
            this.BtnVerTodos.TabIndex = 4;
            this.BtnVerTodos.Text = "Ver todos";
            this.BtnVerTodos.UseVisualStyleBackColor = true;
            this.BtnVerTodos.Click += new System.EventHandler(this.BtnVerTodos_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.LightGreen;
            this.BtnRegistrar.Location = new System.Drawing.Point(521, 32);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(129, 33);
            this.BtnRegistrar.TabIndex = 5;
            this.BtnRegistrar.Text = "Entregar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnCerrar.Location = new System.Drawing.Point(662, 32);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(96, 33);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // frm_LiberarEntregarPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 491);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnVerTodos);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblMsgVacio);
            this.Controls.Add(this.dgvPaquetes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_LiberarEntregarPaquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberar / Entregar Paquetes";
            this.Load += new System.EventHandler(this.frm_LiberarEntregarPaquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
