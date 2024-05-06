using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SimpleNotes
{
    public class CustomRichTextBox : RichTextBox
    {
        private const int WM_NCPAINT = 0x85;
        private const int SB_VERT = 1;
        private const int SB_HORZ = 0;

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll")]
        private static extern int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("user32.dll")]
        private static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_NCPAINT:
                    {
                        IntPtr hDC = GetWindowDC(m.HWnd);
                        if (hDC != IntPtr.Zero)
                        {
                            Graphics g = Graphics.FromHdc(hDC);
                            RECT rect;
                            GetClientRect(m.HWnd, out rect);

                            int vertPos = GetScrollPos(m.HWnd, SB_VERT);
                            int horzPos = GetScrollPos(m.HWnd, SB_HORZ);

                            int vertWidth = SystemInformation.VerticalScrollBarWidth;
                            int horzHeight = SystemInformation.HorizontalScrollBarHeight;

                            Rectangle vertRect = new Rectangle(rect.Right - vertWidth, rect.Top, vertWidth, rect.Bottom - rect.Top - (horzHeight > 0 ? horzHeight : vertWidth));
                            Rectangle horzRect = new Rectangle(rect.Left, rect.Bottom - horzHeight, rect.Right - rect.Left - (vertWidth > 0 ? vertWidth : horzHeight), horzHeight);

                            g.FillRectangle(Brushes.Red, vertRect);
                            g.FillRectangle(Brushes.Red, horzRect);

                            g.Dispose();
                            ReleaseDC(m.HWnd, hDC);
                        }
                    }
                    break;
            }
        }
    }

}
