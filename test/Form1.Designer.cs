namespace test
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
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bEncryptar = new System.Windows.Forms.Button();
            this.txtEncryptado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bDesencryptar = new System.Windows.Forms.Button();
            this.txtDesencrytado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(148, 47);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(260, 20);
            this.txtOrigen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto a Encrytar";
            // 
            // bEncryptar
            // 
            this.bEncryptar.Location = new System.Drawing.Point(148, 84);
            this.bEncryptar.Name = "bEncryptar";
            this.bEncryptar.Size = new System.Drawing.Size(75, 23);
            this.bEncryptar.TabIndex = 1;
            this.bEncryptar.Text = "Encryptar";
            this.bEncryptar.UseVisualStyleBackColor = true;
            this.bEncryptar.Click += new System.EventHandler(this.bEncryptar_Click);
            // 
            // txtEncryptado
            // 
            this.txtEncryptado.Location = new System.Drawing.Point(148, 113);
            this.txtEncryptado.Multiline = true;
            this.txtEncryptado.Name = "txtEncryptado";
            this.txtEncryptado.Size = new System.Drawing.Size(405, 91);
            this.txtEncryptado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Texto Encrytado";
            // 
            // bDesencryptar
            // 
            this.bDesencryptar.Location = new System.Drawing.Point(148, 218);
            this.bDesencryptar.Name = "bDesencryptar";
            this.bDesencryptar.Size = new System.Drawing.Size(75, 23);
            this.bDesencryptar.TabIndex = 3;
            this.bDesencryptar.Text = "Desencryptar";
            this.bDesencryptar.UseVisualStyleBackColor = true;
            this.bDesencryptar.Click += new System.EventHandler(this.bDesencryptar_Click);
            // 
            // txtDesencrytado
            // 
            this.txtDesencrytado.Location = new System.Drawing.Point(148, 247);
            this.txtDesencrytado.Name = "txtDesencrytado";
            this.txtDesencrytado.Size = new System.Drawing.Size(260, 20);
            this.txtDesencrytado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Texto Desencrytado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 319);
            this.Controls.Add(this.txtEncryptado);
            this.Controls.Add(this.bDesencryptar);
            this.Controls.Add(this.bEncryptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesencrytado);
            this.Controls.Add(this.txtOrigen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEncryptar;
        private System.Windows.Forms.TextBox txtEncryptado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDesencryptar;
        private System.Windows.Forms.TextBox txtDesencrytado;
        private System.Windows.Forms.Label label3;
    }
}

