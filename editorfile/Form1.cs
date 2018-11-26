using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace editorfile
{
    public partial class Form1 : Form
    {
        TextLeggiScrivi tls; // classe con metodi per gestire file.
        bool changed = false; // controllo se l'area di lavoro è stata modificata.

        // costruttore
        public Form1()
        {
            InitializeComponent();
            this.numberedRTB.RichTextBox.TextChanged += new System.EventHandler(this.rTxtbox_textChanged);
            tls = new TextLeggiScrivi();
        }

        // Aprire file
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (changed) // SE è stata appilacata una modifica alla area di lavoro: chiedi.
            {
                if (MessageBox.Show("Vuoi uscire senza salvare?", "Attenzione:", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var temp = tls.ApriFile();
                    if (temp != "")
                    {
                        numberedRTB.RichTextBox.Text = tls.ReadFile();
                        txtPercorso.Text = temp;
                    }
                    changed = false;
                }
            }
            else // altrimenti apri.
            {
                var temp = tls.ApriFile();
                if (temp != "")
                {
                    numberedRTB.RichTextBox.Text = tls.ReadFile();
                    txtPercorso.Text = temp;
                }
                changed = false;
            }
        }

        // Chiudere file
        private void btnChiudiFile_Click(object sender, EventArgs e)
        {
            tls.ChiudiFile();
            if (changed)  // SE è stata appilacata una modifica alla area di lavoro: chiedi.
            {
                if (MessageBox.Show("Vuoi uscire senza salvare?", "Attenzione:", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    numberedRTB.RichTextBox.Text = "";
                    txtPercorso.Text = "";
                    changed = false;
                }
            }
            else // altrimenti chiudi.
            {
                numberedRTB.RichTextBox.Text = "";
                txtPercorso.Text = "";
                changed = false;
            }
        }

        // Salva
        private void btnSalva_Click(object sender, EventArgs e)
        {
            var temp = tls.Save(numberedRTB.RichTextBox.Text);
            if (temp != "Error")
            {
                txtPercorso.Text = temp;
                changed = false;
            }
        }

        // Salva con nome
        private void btnSalvaConNome_Click(object sender, EventArgs e)
        {
            var temp = tls.SaveAs(numberedRTB.RichTextBox.Text);
            if (temp != "Error")
            {
                txtPercorso.Text = temp;
                changed = false;
            }
        }

        // Se l'area di lavoro ha ricevuto una modifica per una 2-step chiusura del file
        // Si aggiunge un segnetto al percorso per indicare la presenza di un cambiamento (*)
        private void rTxtbox_textChanged(object sender, EventArgs e)
        {
            if (!changed) { txtPercorso.Text += "*"; }
            changed = true;
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informazioniSuCFileEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                                   Forked from: Versione 1.0 - 2018\r\nMattia Marilli, Niccolò Ciuffi, Elio Kanizsa, Stefano Bianchini");
        }

        // Feature indenta w/ regex
        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string patternStart = @"({)";
            string patternEnd = @"(})";
            var y = numberedRTB.RichTextBox.Text.Split('\n');
            List<string> table = new List<string>();
            int countTab = 0;
            foreach (string x in y)
            {
                var row = x.Trim();
                //both
                if (Regex.Match(row, patternStart).Success && Regex.Match(row, patternEnd).Success)
                {
                    table.Add(string.Concat(Enumerable.Repeat("       ", countTab)) + row);
                }
                //end
                else if (Regex.Match(row, patternEnd).Success)
                {
                    countTab = countTab == 0 ? 0 : (countTab - 1);
                    table.Add(string.Concat(Enumerable.Repeat("       ", countTab)) + row);
                }
                //start
                else if (Regex.Match(row, patternStart).Success)
                {
                    table.Add(string.Concat(Enumerable.Repeat("       ", countTab)) + row);
                    countTab++;
                }
                //normale
                else
                {
                    table.Add(string.Concat(Enumerable.Repeat("       ", countTab)) + row);
                }

                table.Add("\n");
            }
            var text = string.Join("", table.ToArray());
            text = text.Remove(text.Length - 1);
            numberedRTB.RichTextBox.Text = text;
        }
    }

    // Classe gestione file
    class TextLeggiScrivi
    {
        private OpenFileDialog ofd; // Contiene informazioni sul file aperto come perscorso e dati.

        // Costruttore
        public TextLeggiScrivi()
        {
            ofd = new OpenFileDialog();
        }

        // OPEN
        public string ApriFile()
        {
            // aprirà un dialogo che chiede di indicare il file desiderato.
            ofd.Filter = ".cs type | *.cs";
            if (ofd.ShowDialog() != DialogResult.OK) { return ""; }
            return ofd.FileName;
        }

        // CLOSE
        public void ChiudiFile()
        {
            // Deselezione del file scelto in precedenza
            ofd = new OpenFileDialog();
        }

        // READ
        // return: 
        //		i byte del file in una stringa leggibile.
        public string ReadFile()
        {
            StreamReader sr = new StreamReader(ofd.FileName);
            var text = sr.ReadToEnd();
            sr.Close();
            return text;
        }

        // SAVE
        // return:
        //		ritorna o nulla (per indicare che l'operazione è andata a buon fine)
        //		oppure il risultato di saveAs in caso non cera nessun file selezionato in precedenza.
        public string Save(string text)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ofd.FileName);
                sw.Write(text);
                sw.Close();
                return ofd.FileName;
            }
            catch (Exception ex)
            {
                return SaveAs(text);
            }
        }

        // SAVE AS
        // return:
        //		Il nuovo percorso del file creato.
        public string SaveAs(string text)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "cs";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() != DialogResult.OK) { return "Error"; }
            var path = File.Create(sfd.FileName);
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(text);
            sw.Close();
            ofd.FileName = sfd.FileName;
            return sfd.FileName;
        }
    }
}