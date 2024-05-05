using System.Diagnostics;
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
                if (value)
                {
                    btn_save.Show();
                    pnl_highlight.Hide();
                    pnl_topBar.Show();
                }
                else
                {
                    btn_save.Hide();
                    pnl_topBar.Hide();
                    pnl_highlight.Show();
                }
            }
        }
        private bool IsPinned
        {
            get { return TopMost; }
            set
            {
                TopMost = !TopMost;
                btn_pin.ImageKey = value ? "unpin.png" : "pin.png";
            }
        }


        public StickyNoteForm(string noteContent = "", bool canEdit = true)
        {
            InitializeComponent();

            txt_mainNote.Text = noteContent;
            IsEditable = canEdit;
        }

        private void pnl_topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !IsPinned)
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
            IsPinned = !IsPinned;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mainNote.Text)) return;

            var stickyNoteForm = new StickyNoteForm();
            stickyNoteForm.Show();

            saveNote();
        }

        private void txt_mainNote_DoubleClick(object sender, EventArgs e)
        {
            IsEditable = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveNote();
        }
        
        private void saveNote()
        {
            IsEditable = false;
        }


        private void pnl_topBar_MouseLeave(object? sender, EventArgs e)
        {
            if (!IsEditable)
            {
                pnl_topBar.Hide();
                pnl_highlight.Show();
            }
        }


        private void pnl_highlight_MouseEnter(object sender, EventArgs e)
        {
            pnl_highlight.Hide();
            pnl_topBar.Show();
        }
    }
}
