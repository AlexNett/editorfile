namespace editorfile
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonIndenta = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelNomeFile = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIndenta
            // 
            this.buttonIndenta.Location = new System.Drawing.Point(93, 12);
            this.buttonIndenta.Name = "buttonIndenta";
            this.buttonIndenta.Size = new System.Drawing.Size(75, 23);
            this.buttonIndenta.TabIndex = 0;
            this.buttonIndenta.Text = "button1";
            this.buttonIndenta.UseVisualStyleBackColor = true;
            this.buttonIndenta.Click += new System.EventHandler(this.buttonIndenta_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(12, 50);
            this.textBoxFile.Multiline = true;
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(260, 200);
            this.textBoxFile.TabIndex = 1;
            this.textBoxFile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelNomeFile
            // 
            this.labelNomeFile.AutoSize = true;
            this.labelNomeFile.Location = new System.Drawing.Point(191, 17);
            this.labelNomeFile.Name = "labelNomeFile";
            this.labelNomeFile.Size = new System.Drawing.Size(35, 13);
            this.labelNomeFile.TabIndex = 2;
            this.labelNomeFile.Text = "label1";
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(12, 12);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(75, 23);
            this.buttonFile.TabIndex = 3;
            this.buttonFile.Text = "button2";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.labelNomeFile);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.buttonIndenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIndenta;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelNomeFile;
        private System.Windows.Forms.Button buttonFile;
    }
}

