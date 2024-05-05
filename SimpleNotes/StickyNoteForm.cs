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

        // Variables related to form
        private bool IsEditable
        {
            get { return !txt_mainNote.ReadOnly; }
            set
            {
                txt_mainNote.ReadOnly = !value;
            }
        }


        public StickyNoteForm(string noteContent = "", bool canEdit = true)
        {
            InitializeComponent();
            ActiveControl = txt_mainNote;
            txt_mainNote.Text = noteContent;
            IsEditable = canEdit;
        }

        private void pnl_topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            btn_pin.BackgroundImage = TopMost ? global::SimpleNotes.Properties.Resources.unpin : global::SimpleNotes.Properties.Resources.pin;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mainNote.Text)) return;

            var stickyNoteForm = new StickyNoteForm(txt_mainNote.Text, false);
            stickyNoteForm.Show();

            txt_mainNote.Text = "";
        }
    }
}
