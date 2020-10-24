namespace Instshot
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
            this.New = new System.Windows.Forms.Button();
            this.DefaultFolderAddress = new System.Windows.Forms.TextBox();
            this.SelectDefultFolderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.TextBox();
            this.AutoSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.GenerateRandomSequenceCheckBox = new System.Windows.Forms.CheckBox();
            this.AttachDateCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkedByTextbox = new System.Windows.Forms.TextBox();
            this.MainLabelTextBox = new System.Windows.Forms.TextBox();
            this.CustomizeFilenameLabel = new System.Windows.Forms.Label();
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.HotkeyTextbox = new System.Windows.Forms.TextBox();
            this.HotkeyResultLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(-1, -1);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 1;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // DefaultFolderAddress
            // 
            this.DefaultFolderAddress.Location = new System.Drawing.Point(211, 1);
            this.DefaultFolderAddress.Name = "DefaultFolderAddress";
            this.DefaultFolderAddress.Size = new System.Drawing.Size(347, 20);
            this.DefaultFolderAddress.TabIndex = 2;
            // 
            // SelectDefultFolderButton
            // 
            this.SelectDefultFolderButton.Location = new System.Drawing.Point(82, -1);
            this.SelectDefultFolderButton.Name = "SelectDefultFolderButton";
            this.SelectDefultFolderButton.Size = new System.Drawing.Size(129, 23);
            this.SelectDefultFolderButton.TabIndex = 3;
            this.SelectDefultFolderButton.Text = "Select Default Folder";
            this.SelectDefultFolderButton.UseVisualStyleBackColor = true;
            this.SelectDefultFolderButton.Click += new System.EventHandler(this.SelectDefultFolderButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HotkeyResultLabel);
            this.panel1.Controls.Add(this.HotkeyTextbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.test);
            this.panel1.Controls.Add(this.AutoSaveCheckBox);
            this.panel1.Controls.Add(this.GenerateRandomSequenceCheckBox);
            this.panel1.Controls.Add(this.AttachDateCheckBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LinkedByTextbox);
            this.panel1.Controls.Add(this.MainLabelTextBox);
            this.panel1.Controls.Add(this.CustomizeFilenameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 119);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "File Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(268, 22);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(372, 20);
            this.test.TabIndex = 10;
            // 
            // AutoSaveCheckBox
            // 
            this.AutoSaveCheckBox.AutoSize = true;
            this.AutoSaveCheckBox.Checked = true;
            this.AutoSaveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoSaveCheckBox.Location = new System.Drawing.Point(564, 3);
            this.AutoSaveCheckBox.Name = "AutoSaveCheckBox";
            this.AutoSaveCheckBox.Size = new System.Drawing.Size(76, 17);
            this.AutoSaveCheckBox.TabIndex = 9;
            this.AutoSaveCheckBox.Text = "Auto Save";
            this.AutoSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateRandomSequenceCheckBox
            // 
            this.GenerateRandomSequenceCheckBox.AutoSize = true;
            this.GenerateRandomSequenceCheckBox.Checked = true;
            this.GenerateRandomSequenceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GenerateRandomSequenceCheckBox.Location = new System.Drawing.Point(13, 98);
            this.GenerateRandomSequenceCheckBox.Name = "GenerateRandomSequenceCheckBox";
            this.GenerateRandomSequenceCheckBox.Size = new System.Drawing.Size(165, 17);
            this.GenerateRandomSequenceCheckBox.TabIndex = 8;
            this.GenerateRandomSequenceCheckBox.Text = "Generate Random Sequence";
            this.GenerateRandomSequenceCheckBox.UseVisualStyleBackColor = true;
            // 
            // AttachDateCheckBox
            // 
            this.AttachDateCheckBox.AutoSize = true;
            this.AttachDateCheckBox.Checked = true;
            this.AttachDateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AttachDateCheckBox.Location = new System.Drawing.Point(13, 76);
            this.AttachDateCheckBox.Name = "AttachDateCheckBox";
            this.AttachDateCheckBox.Size = new System.Drawing.Size(83, 17);
            this.AttachDateCheckBox.TabIndex = 7;
            this.AttachDateCheckBox.Text = "Attach Date";
            this.AttachDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lnked By";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main Label";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LinkedByTextbox
            // 
            this.LinkedByTextbox.Location = new System.Drawing.Point(70, 50);
            this.LinkedByTextbox.Name = "LinkedByTextbox";
            this.LinkedByTextbox.Size = new System.Drawing.Size(100, 20);
            this.LinkedByTextbox.TabIndex = 2;
            this.LinkedByTextbox.Text = "-";
            // 
            // MainLabelTextBox
            // 
            this.MainLabelTextBox.Location = new System.Drawing.Point(70, 23);
            this.MainLabelTextBox.Name = "MainLabelTextBox";
            this.MainLabelTextBox.Size = new System.Drawing.Size(100, 20);
            this.MainLabelTextBox.TabIndex = 1;
            this.MainLabelTextBox.Text = "screenshot";
            this.MainLabelTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CustomizeFilenameLabel
            // 
            this.CustomizeFilenameLabel.AutoSize = true;
            this.CustomizeFilenameLabel.Location = new System.Drawing.Point(3, 3);
            this.CustomizeFilenameLabel.Name = "CustomizeFilenameLabel";
            this.CustomizeFilenameLabel.Size = new System.Drawing.Size(118, 13);
            this.CustomizeFilenameLabel.TabIndex = 0;
            this.CustomizeFilenameLabel.Text = "Customize the Filename";
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewPictureBox.Location = new System.Drawing.Point(12, 159);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(643, 271);
            this.PreviewPictureBox.TabIndex = 5;
            this.PreviewPictureBox.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(592, -1);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hotkey";
            // 
            // HotkeyTextbox
            // 
            this.HotkeyTextbox.Location = new System.Drawing.Point(268, 49);
            this.HotkeyTextbox.Name = "HotkeyTextbox";
            this.HotkeyTextbox.Size = new System.Drawing.Size(100, 20);
            this.HotkeyTextbox.TabIndex = 13;
            this.HotkeyTextbox.Enter += new System.EventHandler(this.HotkeyTextbox_Enter);
            // 
            // HotkeyResultLabel
            // 
            this.HotkeyResultLabel.AutoSize = true;
            this.HotkeyResultLabel.Location = new System.Drawing.Point(375, 54);
            this.HotkeyResultLabel.Name = "HotkeyResultLabel";
            this.HotkeyResultLabel.Size = new System.Drawing.Size(22, 13);
            this.HotkeyResultLabel.TabIndex = 14;
            this.HotkeyResultLabel.Text = "     ";
            this.HotkeyResultLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 442);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PreviewPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SelectDefultFolderButton);
            this.Controls.Add(this.DefaultFolderAddress);
            this.Controls.Add(this.New);
            this.Name = "Form1";
            this.Text = "Instshot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.TextBox DefaultFolderAddress;
        private System.Windows.Forms.Button SelectDefultFolderButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CustomizeFilenameLabel;
        private System.Windows.Forms.TextBox MainLabelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LinkedByTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AttachDateCheckBox;
        private System.Windows.Forms.CheckBox GenerateRandomSequenceCheckBox;
        private System.Windows.Forms.PictureBox PreviewPictureBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox AutoSaveCheckBox;
        private System.Windows.Forms.TextBox test;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label HotkeyResultLabel;
        private System.Windows.Forms.TextBox HotkeyTextbox;
        private System.Windows.Forms.Label label4;
    }
}

