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
            this.labelNomeFile = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonIndenta
            // 
            this.buttonIndenta.Location = new System.Drawing.Point(74, 7);
            this.buttonIndenta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonIndenta.Name = "buttonIndenta";
            this.buttonIndenta.Size = new System.Drawing.Size(130, 32);
            this.buttonIndenta.TabIndex = 0;
            this.buttonIndenta.Text = "Indenta";
            this.buttonIndenta.UseVisualStyleBackColor = true;
            // 
            // labelNomeFile
            // 
            this.labelNomeFile.AutoSize = true;
            this.labelNomeFile.Location = new System.Drawing.Point(534, 17);
            this.labelNomeFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeFile.Name = "labelNomeFile";
            this.labelNomeFile.Size = new System.Drawing.Size(51, 13);
            this.labelNomeFile.TabIndex = 2;
            this.labelNomeFile.Text = "Nome file";
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(270, 7);
            this.buttonFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(136, 32);
            this.buttonFile.TabIndex = 3;
            this.buttonFile.Text = "File";
            this.buttonFile.UseVisualStyleBackColor = true;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(12, 45);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(661, 367);
            this.textBoxFile.TabIndex = 4;
            this.textBoxFile.Text = "";
            this.textBoxFile.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 424);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.labelNomeFile);
            this.Controls.Add(this.buttonIndenta);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "File editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIndenta;
        private System.Windows.Forms.Label labelNomeFile;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.RichTextBox textBoxFile;
    }
}

