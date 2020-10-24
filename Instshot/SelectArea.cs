using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// select area and capture ref: https://medium.com/@nishancw/c-screenshot-utility-to-capture-a-portion-of-the-screen-489ddceeee49
// draw rectangle ref: https://www.youtube.com/watch?v=Vpao8QNytzg
// TODO: enhanced slecting tool ref: https://www.xin3721.com/ArticlePrograme/C_biancheng/15767.html

// TODO: preview, confirm, cancel, and resize
// packaging and publish

namespace Instshot
{
    public partial class SelectArea : Form
    {
        public SelectArea()
        {
            InitializeComponent();

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;

            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.Opacity = .3D; // make trasparent
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                // get screen position and reutrn to main form
                this.Hide();
                CapturePosition capturePosition = new CapturePosition(this.Location.X, this.Location.Y, this.Width, this.Height);
                FormState.capturePosition = capturePosition;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        //TODO: program does not reach to this point because of mousedown and mouseup listener
        private void SelectArea_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool isLeftMouseDown = false; // is left mouse is down
        private Point startLocation;
        private Point endLocation;
        private Rectangle rect;

        /// <summary>
        /// When mouse pressed down, capture the starting point of x and y.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseDown = true;
                ReleaseCapture();
                startLocation = e.Location;
            }
        }

        private void SelectArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isLeftMouseDown == true)
            {
                isLeftMouseDown = false;
                ReleaseCapture();

                this.endLocation = e.Location;
                // get screen position and reutrn to main form
                this.Hide();
                CapturePosition capturePosition = new CapturePosition(
                    Math.Min(startLocation.X, endLocation.X), 
                    Math.Min(startLocation.Y, endLocation.Y),
                    Math.Abs(startLocation.X - endLocation.X), 
                    Math.Abs(startLocation.Y - endLocation.Y));
                FormState.capturePosition = capturePosition;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SelectArea_Load(object sender, EventArgs e)
        {

        }

        private void SelectArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isLeftMouseDown == true)
            {
                ReleaseCapture();
                endLocation = e.Location;
                Refresh(); // refreash the form
            }
        }

        private void SelectArea_Paint(object sender, PaintEventArgs e)
        {
            if (this.rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Red, getRect());
            }
        }

        private Rectangle getRect()
        {
            this.rect = new Rectangle();
            rect.X = Math.Min(startLocation.X, endLocation.X);
            rect.Y = Math.Min(startLocation.Y, endLocation.Y);
            rect.Width = Math.Abs(startLocation.X - endLocation.X);
            rect.Height =  Math.Abs(startLocation.Y - endLocation.Y);
            return rect;
        }

    }
}

//How to resize a form without a border? https://stackoverflow.com/a/32261547/5260872
