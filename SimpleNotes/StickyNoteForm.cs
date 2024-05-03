using System;
using System.Runtime.InteropServices;

namespace SimpleNotes
{
    public partial class StickyNoteForm : Form
    {
        // Constants for window movement
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public StickyNoteForm(string title, string mainNote)
        {
            InitializeComponent();
            txt_title.Text = title;
            txt_mainNote.Text = mainNote;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnl_topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
