﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Collections.Generic;

namespace editorfile
{
    public partial class Form1 : Form
    {


        string sFileName;

        public Form1()
        {
            InitializeComponent();
        }

        public void salvaFile() {
            if (File.Exists(sFileName))
            {
                using (StreamWriter sw = new StreamWriter(sFileName))
                {
                    sw.Write(numberedRTB1.RichTextBox.Text);
                }
            }
        }

        private void newFile(bool fileEsistente) {

            String textSave;

            if (fileEsistente == false)
                textSave = "Salvare le modifiche in un nuovo file?";
            else
                textSave = "Salvare le modifiche a " + sFileName + "?";

            DialogResult result = MessageBox.Show(textSave, "C# Editor FIle", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (fileEsistente == true)
                {
                    salvaFile();
                    numberedRTB1.RichTextBox.Clear();
                    labelNomeFile.Text = null;
                }
                else {
                    this.salvaFileConNome();
                    numberedRTB1.RichTextBox.Clear();
                    labelNomeFile.Text = null;
                }
            }
            else if (result == DialogResult.No)
            {
                numberedRTB1.RichTextBox.Clear();
                labelNomeFile.Text = null;
            }
            else if (result == DialogResult.Cancel)
            {
                //code for Cancel
            }
        }

        private void salvaFileConNome()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "(*.cs*)|*.cs*";
            saveFile.FilterIndex = 1;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                sFileName = saveFile.FileName;
                labelNomeFile.Text = sFileName.ToString();
            }

            if (sFileName != null)
            {
                StreamWriter newFile = new StreamWriter(sFileName);
                newFile.Write(numberedRTB1.RichTextBox.Text);
            }
        }


        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "(*.cs*)|*.cs*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;
                labelNomeFile.Text = sFileName.ToString();
            }

            if (sFileName != null)
            {
                string line = null;
                string text = null;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader(sFileName);

                while ((line = reader.ReadLine()) != null)
                {
                    text = text + line + "\r\n";
                }

                reader.Close();
                numberedRTB1.RichTextBox.Text = text;
                numberedRTB1.RichTextBox.Enabled = true;
            }
            
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salvaFile();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void indentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = null;
            string text = null;
            byte indentLevel = 0;
            bool parentesiAperta = false;
            List<string> lines = new List<string>();
            StreamReader reader = new StreamReader(sFileName);

            // read all the lines in the file and store them in the List 
            while ((line = reader.ReadLine()) != null)
            {
                line = line.Trim();
                if (line.Contains("{"))
                {
                    if (parentesiAperta == true) {
                        for (int i = 0; i < indentLevel; i++)
                        {
                            text = text + " ";
                        }
                    }
                    indentLevel += 4;
                    text = text + line + "\r\n";
                    parentesiAperta = true;
                }
                else if (line.Contains("}"))
                {
                    indentLevel -= 4;
                    for (int i = 0; i < indentLevel; i++)
                    {
                        text = text + " ";
                    }
                    text = text + line + "\r\n";
                }
                else {
                    for (int i = 0; i < indentLevel; i++)
                    {
                        text = text + " ";
                    }
                    text = text + line + "\r\n";
                }

                if (indentLevel == 0)
                    parentesiAperta = false;
            }

            reader.Close();
            numberedRTB1.RichTextBox.Text = text;
            numberedRTB1.RichTextBox.Enabled = true;
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numberedRTB1.RichTextBox.Text != "" && sFileName != null)
            {
                newFile(true);
            }
            else {
                newFile(false);
            }
        }

        private void informazioniSuCFileEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versione 1.0 - 2018\r\nMattia Marilli, Niccolò Ciuffi, Elio Kanizsa, Stefano Bianchini");
        }

        private void salvaConNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salvaFileConNome();
        }
    }
}