using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphical_programming_language
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        /*
         * this function is to save the multi command code into text file in your local system.
         * we can use the same code next time using open button.
         */
        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            //this will add file to .txt extension to save code in plain text
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var extension = System.IO.Path.GetExtension(saveFileDialog.FileName);
                //condition to check the above code create .txt file and work accordingly..
                if (extension.ToLower() == ".txt")
                    multiLineInput.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                else
                    multiLineInput.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //this function is to open saved command in multiLine Command input by the user
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opentext = new OpenFileDialog();
            if (opentext.ShowDialog() == DialogResult.OK)
            {
                //variable is created inside if condition. Hence, this variable is valid for this condition only.
                string selectedFileName = opentext.FileName;
                multiLineInput.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText); //this will load text file command to multi line command box..
            }
        }
    }
}
