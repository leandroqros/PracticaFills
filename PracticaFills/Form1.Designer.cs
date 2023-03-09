
namespace PracticaFills
{
    partial class Form1
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
            this.lblArchivos = new System.Windows.Forms.Label();
            this.lblLetras = new System.Windows.Forms.Label();
            this.txbArchivo = new System.Windows.Forms.TextBox();
            this.txbLetras = new System.Windows.Forms.TextBox();
            this.bntGenerarCodigo = new System.Windows.Forms.Button();
            this.bntGenerarArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.Location = new System.Drawing.Point(35, 41);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(105, 13);
            this.lblArchivos.TabIndex = 0;
            this.lblArchivos.Text = "Numero de archivos:";
            // 
            // lblLetras
            // 
            this.lblLetras.AutoSize = true;
            this.lblLetras.Location = new System.Drawing.Point(50, 72);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(90, 13);
            this.lblLetras.TabIndex = 1;
            this.lblLetras.Text = "Numero de letras:";
            // 
            // txbArchivo
            // 
            this.txbArchivo.Location = new System.Drawing.Point(146, 38);
            this.txbArchivo.Name = "txbArchivo";
            this.txbArchivo.Size = new System.Drawing.Size(68, 20);
            this.txbArchivo.TabIndex = 2;
            // 
            // txbLetras
            // 
            this.txbLetras.Location = new System.Drawing.Point(146, 69);
            this.txbLetras.Name = "txbLetras";
            this.txbLetras.Size = new System.Drawing.Size(68, 20);
            this.txbLetras.TabIndex = 3;
            // 
            // bntGenerarCodigo
            // 
            this.bntGenerarCodigo.Location = new System.Drawing.Point(38, 114);
            this.bntGenerarCodigo.Name = "bntGenerarCodigo";
            this.bntGenerarCodigo.Size = new System.Drawing.Size(85, 59);
            this.bntGenerarCodigo.TabIndex = 4;
            this.bntGenerarCodigo.Text = "Generar Codificación";
            this.bntGenerarCodigo.UseVisualStyleBackColor = true;
            this.bntGenerarCodigo.Click += new System.EventHandler(this.bntGenerarCodigo_Click);
            // 
            // bntGenerarArchivo
            // 
            this.bntGenerarArchivo.Location = new System.Drawing.Point(129, 114);
            this.bntGenerarArchivo.Name = "bntGenerarArchivo";
            this.bntGenerarArchivo.Size = new System.Drawing.Size(85, 59);
            this.bntGenerarArchivo.TabIndex = 5;
            this.bntGenerarArchivo.Text = "Generar Archivos";
            this.bntGenerarArchivo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 213);
            this.Controls.Add(this.bntGenerarArchivo);
            this.Controls.Add(this.bntGenerarCodigo);
            this.Controls.Add(this.txbLetras);
            this.Controls.Add(this.txbArchivo);
            this.Controls.Add(this.lblLetras);
            this.Controls.Add(this.lblArchivos);
            this.Name = "Form1";
            this.Text = "Procesar archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArchivos;
        private System.Windows.Forms.Label lblLetras;
        private System.Windows.Forms.TextBox txbArchivo;
        private System.Windows.Forms.TextBox txbLetras;
        private System.Windows.Forms.Button bntGenerarCodigo;
        private System.Windows.Forms.Button bntGenerarArchivo;
    }
}

