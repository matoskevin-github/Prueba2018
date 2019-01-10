namespace DemoLinq01
{
    partial class frmFacturas
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
            this.btnMostrarMensaje = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarMensaje
            // 
            this.btnMostrarMensaje.Location = new System.Drawing.Point(349, 29);
            this.btnMostrarMensaje.Name = "btnMostrarMensaje";
            this.btnMostrarMensaje.Size = new System.Drawing.Size(137, 23);
            this.btnMostrarMensaje.TabIndex = 0;
            this.btnMostrarMensaje.Text = "Mostrar Mensaje";
            this.btnMostrarMensaje.UseVisualStyleBackColor = true;
            this.btnMostrarMensaje.Click += new System.EventHandler(this.btnMostrarMensaje_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(12, 58);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.Size = new System.Drawing.Size(811, 283);
            this.dgvFacturas.TabIndex = 1;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 357);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnMostrarMensaje);
            this.MaximizeBox = false;
            this.Name = "frmFacturas";
            this.Text = ".:::Facturas:::.";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarMensaje;
        private System.Windows.Forms.DataGridView dgvFacturas;
    }
}

