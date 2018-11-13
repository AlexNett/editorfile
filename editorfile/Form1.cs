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
<<<<<<< HEAD
        string filepath;
=======
        string sFileName;
>>>>>>> 61a10a32b3365dbe36e26388d8414753dd36d6d7
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
<<<<<<< HEAD
                this.filepath = choofdlog.FileName;
                labelNomeFile.Text = filepath.ToString();
            }

            
        }
        
=======
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
        

>>>>>>> 61a10a32b3365dbe36e26388d8414753dd36d6d7
        private void buttonIndenta_Click(object sender, EventArgs e)
        {

        }
    }
}
