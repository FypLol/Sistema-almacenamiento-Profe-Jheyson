namespace SistAlmacenamientoProfeJheyson
{
    partial class frm_panelAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_VRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_VRegistrar
            // 
            this.btn_VRegistrar.Location = new System.Drawing.Point(275, 193);
            this.btn_VRegistrar.Name = "btn_VRegistrar";
            this.btn_VRegistrar.Size = new System.Drawing.Size(206, 60);
            this.btn_VRegistrar.TabIndex = 0;
            this.btn_VRegistrar.Text = "ABRIR VENTANA";
            this.btn_VRegistrar.UseVisualStyleBackColor = true;
            this.btn_VRegistrar.Click += new System.EventHandler(this.btn_VRegistrar_Click);
            // 
            // frm_panelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_VRegistrar);
            this.Name = "frm_panelAdmin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_panelAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_VRegistrar;
    }
}

