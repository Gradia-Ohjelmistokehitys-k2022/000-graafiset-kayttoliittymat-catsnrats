using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projektipohja
{
    public partial class MainForm : Form
    {
        private String editorFileName = "Untitled";
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetFormTitleText() // asettaa pääformin otsikon
        {
            // tiedoston nimi formin otsikoksi
            FileInfo fileInfo = new FileInfo(editorFileName);
            Text = fileInfo.Name + " - Editor";
        }

        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) // Valikko: File / New toiminto
        {
            editorFileName = "Untitled";            
            richTextBox1.Clear();
            SetFormTitleText();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) // File / Open
        {
            // avausdialogiobjekti ja sen alustus
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open";
            openFileDialog.ShowReadOnly = true;
            openFileDialog.Filter = "Text documents (*.txt)|*.txt|All files|*.*";

            // avataan Windowsin standardi avausdialogi
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                // talletetaan tiedoston nimi ja polku lukemista varten
                editorFileName = openFileDialog.FileName;

                // luetaan tiedoston sisältö ja tuodaan se näytölle
                ReadFile(editorFileName);

                SetFormTitleText();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) // File / Save
        {
            if (editorFileName == "Untitled")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                SaveFile(editorFileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // standardi talletusdialogiobjekti ja sen alustus
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text documents (*.txt)|*.txt|All files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // talletetaan tiedoston nimi ja polku lukemista varten
                editorFileName = saveFileDialog.FileName;
                
                SaveFile(editorFileName); // SaveFile-metodin kutsu

                SetFormTitleText();
            }
        }

        // reads file into RichTextBox
        private void ReadFile(string filePath)
        {
            try
            {
                // create StreamReader object and read the file
                using (StreamReader strmReader = new StreamReader(filePath))
                {
                    // read
                    richTextBox1.Clear();
                    richTextBox1.Text = strmReader.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Open File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // apumetodi tiedoston tallennukseen
        private void SaveFile(string filePath)
        {
            try
            {
                // create StreamWriter object and write text into file
                using (StreamWriter strmWriter = new StreamWriter(filePath))
                {
                    // write
                    strmWriter.Write(richTextBox1.Text);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }        
    }
}
