
namespace Tarea_de_curso_programacion
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
            this.btnservicios = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnservicios
            // 
            this.btnservicios.Location = new System.Drawing.Point(98, 162);
            this.btnservicios.Name = "btnservicios";
            this.btnservicios.Size = new System.Drawing.Size(75, 23);
            this.btnservicios.TabIndex = 0;
            this.btnservicios.Text = "servicios";
            this.btnservicios.UseVisualStyleBackColor = true;
            this.btnservicios.Click += new System.EventHandler(this.btnservicios_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Location = new System.Drawing.Point(69, 81);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(75, 23);
            this.btnclientes.TabIndex = 1;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclientes);
            this.groupBox1.Controls.Add(this.btnservicios);
            this.groupBox1.Location = new System.Drawing.Point(81, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 258);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 321);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnservicios;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

