using System;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;         
            }

            string line = null;
            string text = null;
            List<string> lines = new List<string>();
            StreamReader reader = new StreamReader(sFileName);

            // read all the lines in the file and store them in the List 
            while ((line = reader.ReadLine()) != null)
            {
                text = text + line + "\r\n";
            }

            reader.Close();
            textBoxFile.Text = text;

        }
        

        private void buttonIndenta_Click(object sender, EventArgs e)
        {

        }
    }
}
