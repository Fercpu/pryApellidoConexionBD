namespace pryApellidoConexionBD
{
    partial class frmMenuPrincipal
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
            this.lblConexion = new System.Windows.Forms.Label();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Location = new System.Drawing.Point(87, 93);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(35, 13);
            this.lblConexion.TabIndex = 0;
            this.lblConexion.Text = "label1";
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(70, 141);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 1;
            this.btnPrueba.Text = "Probar";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gestion de Inventario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(177, 321);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(102, 50);
            this.btnBuscarProducto.TabIndex = 4;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.lblConexion);
            this.Name = "frmMenuPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscarProducto;
    }
}

