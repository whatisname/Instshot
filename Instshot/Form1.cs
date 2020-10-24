using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// hotkey register, customize hotkey,


namespace Instshot
{
    public partial class Form1 : Form
    {
        // Hotkey register
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hwnd, int id, uint fdModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int it);

        public Form1()
        {
            InitializeComponent();

            DefaultFolderAddress.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.MaximizeBox = false; // maxmize not allowed
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // center the window
            //this.TopMost = true; // set the window to top

            // register hotkey
            // register ALT + A
            RegisterHotKey(this.Handle, 1, (uint)FdModifiers.Alt, (uint)Keys.A);

            // display hoekey in HotkeyTextbox
            HotkeyTextbox.Text = "Alt + A"; // TODO
            HotkeyResultLabel.Text = "Press any key to change.";
        }

        private void label1_Click(object sender, EventArgs e) 
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            newScreenshot();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void SelectDefultFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Select the default path that the screenshots will be saved:";
            fbd.ShowNewFolderButton = false;

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                DefaultFolderAddress.Text = fbd.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the window is closed, unregister all hotkeys.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);
            //TODO: more hotkeys
        }

        // ===================================================
        private string getFileName(string filepath, ImageFormat imageFormat)
        {
            string filename = filepath + "\\";
            filename += MainLabelTextBox.Text;
            if (AttachDateCheckBox.Checked == true)
            {
                filename += LinkedByTextbox.Text;
                filename += DateTime.Now.ToString("yyyy-MM-dd-hh-mm");
            }
            if (GenerateRandomSequenceCheckBox.Checked == true)
            {
                filename += LinkedByTextbox.Text;
                string randomFileName = System.IO.Path.GetRandomFileName();
                randomFileName = randomFileName.Substring(0, randomFileName.Length - 4);
                filename += randomFileName;
                //filename += Guid.NewGuid().ToString("N"); // method N.2 (long string)

            }
            filename += "." + imageFormat.ToString();
            return filename;
        }

        public void newScreenshot()
        {
            this.Hide();
            System.Threading.Thread.Sleep(800);

            // call select area form
            FormState.PreviousPage = this;
            SelectArea selectArea = new SelectArea();
            if (selectArea.ShowDialog() == DialogResult.OK 
                && FormState.capturePosition.height != 0
                && FormState.capturePosition.width != 0)
            {
                // capture screen
                Bitmap bitmap = new Bitmap(FormState.capturePosition.width, FormState.capturePosition.height);
                Graphics graphics = Graphics.FromImage(bitmap as Image);
                graphics.CopyFromScreen(FormState.capturePosition.x, FormState.capturePosition.y, 0, 0, bitmap.Size);
                PreviewPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                PreviewPictureBox.Image = bitmap;
                this.Show();

                // TODO: auto save
                if (AutoSaveCheckBox.Checked == true)
                {
                    test.Text = getFileName(DefaultFolderAddress.Text, ImageFormat.Jpeg);
                    bitmap.Save(getFileName(DefaultFolderAddress.Text, ImageFormat.Jpeg));
                }
            }
            else
            {
                this.Show();
            }

            
        }

        /// <summary>
        /// The key pressed will be sent to here.
        /// </summary>
        /// <param name="keyPressed"></param>
        protected override void WndProc(ref Message keyPressed)
        {
            if (keyPressed.Msg == 0x0312)
            {
                newScreenshot();
            }
            base.WndProc(ref keyPressed);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HotkeyTextbox_Enter(object sender, EventArgs e)
        {
            // listen to hotkey
            // TODO
        }

        //=================================================
        /// <summary>
        /// Typical hotKey assignments.
        /// </summary>
        // https://www.youtube.com/watch?v=FL_y8GT1L7E
        public enum FdModifiers
        {
            Alt = 0X0001,
            Control = 0x0002,
            Shift = 0x0004,
            Window = 0x0008,
        }

        
    }
}
