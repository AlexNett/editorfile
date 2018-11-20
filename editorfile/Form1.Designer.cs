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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.labelNomeFile = new System.Windows.Forms.Label();
			this.textBoxFile = new System.Windows.Forms.RichTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salvaConNomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.indentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.informazioniSuCFileEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txt_nLine = new System.Windows.Forms.RichTextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelNomeFile
			// 
			this.labelNomeFile.AutoSize = true;
			this.labelNomeFile.Location = new System.Drawing.Point(13, 402);
			this.labelNomeFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelNomeFile.Name = "labelNomeFile";
			this.labelNomeFile.Size = new System.Drawing.Size(0, 13);
			this.labelNomeFile.TabIndex = 2;
			// 
			// textBoxFile
			// 
			this.textBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxFile.Location = new System.Drawing.Point(57, 26);
			this.textBoxFile.Name = "textBoxFile";
			this.textBoxFile.Size = new System.Drawing.Size(616, 374);
			this.textBoxFile.TabIndex = 4;
			this.textBoxFile.Text = "";
			this.textBoxFile.SelectionChanged += new System.EventHandler(this.textBoxFile_SelectionChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(685, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem,
            this.apriToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.salvaConNomeToolStripMenuItem,
            this.toolStripSeparator1,
            this.esciToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// nuovoToolStripMenuItem
			// 
			this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
			this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.nuovoToolStripMenuItem.Text = "Nuovo";
			this.nuovoToolStripMenuItem.Click += new System.EventHandler(this.nuovoToolStripMenuItem_Click);
			// 
			// apriToolStripMenuItem
			// 
			this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
			this.apriToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.apriToolStripMenuItem.Text = "Apri...";
			this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
			// 
			// salvaToolStripMenuItem
			// 
			this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
			this.salvaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.salvaToolStripMenuItem.Text = "Salva";
			this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
			// 
			// salvaConNomeToolStripMenuItem
			// 
			this.salvaConNomeToolStripMenuItem.Name = "salvaConNomeToolStripMenuItem";
			this.salvaConNomeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.salvaConNomeToolStripMenuItem.Text = "Salva con nome...";
			this.salvaConNomeToolStripMenuItem.Click += new System.EventHandler(this.salvaConNomeToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
			// 
			// esciToolStripMenuItem
			// 
			this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
			this.esciToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.esciToolStripMenuItem.Text = "Esci";
			this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
			// 
			// modificaToolStripMenuItem
			// 
			this.modificaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indentaToolStripMenuItem});
			this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
			this.modificaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.modificaToolStripMenuItem.Text = "Modifica";
			// 
			// indentaToolStripMenuItem
			// 
			this.indentaToolStripMenuItem.Name = "indentaToolStripMenuItem";
			this.indentaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.indentaToolStripMenuItem.Text = "Indenta ";
			this.indentaToolStripMenuItem.Click += new System.EventHandler(this.indentaToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informazioniSuCFileEditorToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
			this.toolStripMenuItem1.Text = "?";
			// 
			// informazioniSuCFileEditorToolStripMenuItem
			// 
			this.informazioniSuCFileEditorToolStripMenuItem.Name = "informazioniSuCFileEditorToolStripMenuItem";
			this.informazioniSuCFileEditorToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.informazioniSuCFileEditorToolStripMenuItem.Text = "Informazioni su C# File Editor";
			this.informazioniSuCFileEditorToolStripMenuItem.Click += new System.EventHandler(this.informazioniSuCFileEditorToolStripMenuItem_Click);
			// 
			// txt_nLine
			// 
			this.txt_nLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_nLine.Location = new System.Drawing.Point(16, 26);
			this.txt_nLine.Name = "txt_nLine";
			this.txt_nLine.ReadOnly = true;
			this.txt_nLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_nLine.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.txt_nLine.Size = new System.Drawing.Size(35, 374);
			this.txt_nLine.TabIndex = 7;
			this.txt_nLine.Text = "1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 424);
			this.Controls.Add(this.txt_nLine);
			this.Controls.Add(this.textBoxFile);
			this.Controls.Add(this.labelNomeFile);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "Form1";
			this.Text = "C# File Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNomeFile;
        private System.Windows.Forms.RichTextBox textBoxFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaConNomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informazioniSuCFileEditorToolStripMenuItem;
		private System.Windows.Forms.RichTextBox txt_nLine;
	}
}

