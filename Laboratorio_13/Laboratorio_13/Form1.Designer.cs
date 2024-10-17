namespace Laboratorio_13
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
            this.btnHit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(242, 36);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(311, 124);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Conectar y Desconectar SQL server ";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(242, 227);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 180);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnHit);
            this.Name = "Form1";
            this.Text = "Conectar y desconectar  SQL server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

