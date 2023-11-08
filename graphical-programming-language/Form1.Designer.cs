namespace graphical_programming_language
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputBox = new System.Windows.Forms.PictureBox();
            this.multiLineInput = new System.Windows.Forms.RichTextBox();
            this.multiLineCommandLabel = new System.Windows.Forms.Label();
            this.oneLineInput = new System.Windows.Forms.TextBox();
            this.oneLineCommandLabel = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.outputAreaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.IndianRed;
            this.outputBox.Location = new System.Drawing.Point(12, 38);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(517, 424);
            this.outputBox.TabIndex = 0;
            this.outputBox.TabStop = false;
            this.outputBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // multiLineInput
            // 
            this.multiLineInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiLineInput.Location = new System.Drawing.Point(535, 38);
            this.multiLineInput.Name = "multiLineInput";
            this.multiLineInput.Size = new System.Drawing.Size(211, 204);
            this.multiLineInput.TabIndex = 1;
            this.multiLineInput.Text = "";
            this.multiLineInput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // multiLineCommandLabel
            // 
            this.multiLineCommandLabel.AutoSize = true;
            this.multiLineCommandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiLineCommandLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.multiLineCommandLabel.Location = new System.Drawing.Point(539, 9);
            this.multiLineCommandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.multiLineCommandLabel.Name = "multiLineCommandLabel";
            this.multiLineCommandLabel.Size = new System.Drawing.Size(207, 26);
            this.multiLineCommandLabel.TabIndex = 14;
            this.multiLineCommandLabel.Text = "MultiLine Command";
            // 
            // oneLineInput
            // 
            this.oneLineInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneLineInput.Location = new System.Drawing.Point(535, 290);
            this.oneLineInput.Name = "oneLineInput";
            this.oneLineInput.Size = new System.Drawing.Size(211, 26);
            this.oneLineInput.TabIndex = 15;
            // 
            // oneLineCommandLabel
            // 
            this.oneLineCommandLabel.AutoSize = true;
            this.oneLineCommandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneLineCommandLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.oneLineCommandLabel.Location = new System.Drawing.Point(539, 261);
            this.oneLineCommandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oneLineCommandLabel.Name = "oneLineCommandLabel";
            this.oneLineCommandLabel.Size = new System.Drawing.Size(202, 26);
            this.oneLineCommandLabel.TabIndex = 16;
            this.oneLineCommandLabel.Text = "OneLine Command";
            this.oneLineCommandLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(540, 333);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(99, 39);
            this.btnRun.TabIndex = 17;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(540, 378);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(99, 39);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(645, 333);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 39);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(645, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 39);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(540, 423);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(206, 39);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // outputAreaLabel
            // 
            this.outputAreaLabel.AutoSize = true;
            this.outputAreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputAreaLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.outputAreaLabel.Location = new System.Drawing.Point(11, 9);
            this.outputAreaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputAreaLabel.Name = "outputAreaLabel";
            this.outputAreaLabel.Size = new System.Drawing.Size(129, 26);
            this.outputAreaLabel.TabIndex = 22;
            this.outputAreaLabel.Text = "Output Area";
            this.outputAreaLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 474);
            this.Controls.Add(this.outputAreaLabel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.oneLineCommandLabel);
            this.Controls.Add(this.oneLineInput);
            this.Controls.Add(this.multiLineCommandLabel);
            this.Controls.Add(this.multiLineInput);
            this.Controls.Add(this.outputBox);
            this.Name = "Form1";
            this.Text = "Graphical Programming Language";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox outputBox;
        private System.Windows.Forms.RichTextBox multiLineInput;
        private System.Windows.Forms.Label multiLineCommandLabel;
        private System.Windows.Forms.TextBox oneLineInput;
        private System.Windows.Forms.Label oneLineCommandLabel;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label outputAreaLabel;
    }
}

