using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace graphical_programming_language
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// giving GPL_shapes class as g
        /// </summary>
        GPL_Shapes g;

        /// <summary>
        /// form construct function
        /// </summary>
      
        public Form1()
        {
            InitializeComponent();
            GPL_Shap_properties.x = GPL_Shap_properties.y = 0;
            g = new GPL_Shapes();
            g.CurrPoint(false);
            Refresh();
        }

        /// <summary>
        /// this function use refresh the outputBox.Image refresh.
        /// </summary>
        public override void Refresh()
        {
            outputBox.Image = GPL_Shap_properties.NewPicture;
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

        /// <summary>
        /// this is to exicute the command and display the shape on outputbox.
        /// </summary>
        /// <param name="sender">Object which raised to the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            Boolean inputFlag = false;
            //condition to check if inputCommands are multi line command or not.
            if (multiLineInput.Text.Trim() != string.Empty)
            {
                inputFlag = true;
                //passing data to runCommand function 
                g.runCommand(multiLineInput.Text.Trim());
                multiLineInput.Focus();
                //once commands is pass to runCommand function MultiLine Input textbox will be empty..
                multiLineInput.Text = string.Empty;
            }

            //condition to check if InputCommands is single Line or Not?.
            if (oneLineInput.Text.Trim() != string.Empty)
            {
                inputFlag = true;
                //passing data to runCommand function 
                g.runCommand(oneLineInput.Text.Trim());
                oneLineInput.Focus();
                //once commands is pass to runCommand function SingleLine Input textbox will be empty..
                oneLineInput.Text = string.Empty;
            }

            //condtion if the input user command is null or empty.
            if (!inputFlag)
            {
                g.PrintMessage("Please enter any command!");
                oneLineInput.Focus();
            }
            
            //refresh the form
            Refresh();
            GPL_Shap_properties.isFill = false;

        }

        /// <summary>
        /// this function is to save the multi command code into text file in your local system. we can use the same code next time using open button
        /// </summary>
        /// <param name="sender">The sender os event of save button</param>
        /// <param name="e">e is the information contain about the event save button</param>
        
        
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

        /// <summary>
        /// this function is to open saved command in multiLine Command input by the user
        /// </summary>
        /// <param name="sender">The sender os event of Open button</param>
        /// <param name="e">e is the information contain about the event epen button</param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opentext = new OpenFileDialog();
            if (opentext.ShowDialog() == DialogResult.OK)
            {
                //variable is created inside if condition. Hence, this variable is valid for this condition only.
                string selectedFileName = opentext.FileName;
                //this will load text file command to multi line command box.
                multiLineInput.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText); 
            }
        }

        /// <summary>
        ///utton to clear screen without resetting the picture box 
        /// </summary> /// 
        /// <param name="sender">The sender os event of Open reset the screen</param>
        /// <param name="e">e is the information contain about the event epen button</param>
        //
        private void btnClear_Click(object sender, EventArgs e)
        {
            GPL_Shap_properties.NewPicture = new Bitmap(640, 480);
            g = new GPL_Shapes();
            g.CurrPoint(true);
            Refresh();
        }

        //button to reset whole process and clear the screen
        private void btnReset_Click(object sender, EventArgs e)
        {
            GPL_Shap_properties.NewPicture = new Bitmap(640, 480);
            g = new GPL_Shapes();
            g.CurrPoint(false);
            Refresh();
        }
    }
}
