using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Instshot
{
    static class Hotkeys
    {
        // Hotkey register
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hwnd, int id, uint fdModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int it);


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
