using System;
using System.Drawing;
using System.Windows.Forms;

namespace Instshot
{
    public static class FormState
    {
        public static Form PreviousPage;
        public static CapturePosition capturePosition;
    }

    public class CapturePosition
    {
        public Int32 x;
        public Int32 y;
        public Int32 width;
        public Int32 height;
        //public Size size;

        public CapturePosition(Int32 x, Int32 y, Int32 width, Int32 height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}
