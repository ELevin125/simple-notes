using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SimpleNotes
{
    public partial class StickyNoteForm : Form
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern bool ShowCaret(IntPtr hWnd);

        // Custom window draggin variables
        private bool isDragging = false;
        private int offsetX, offsetY;

        // Variables related to form
        private bool IsEditable
        {
            get { return !rtxt_mainText.ReadOnly; }
            set
            {
                rtxt_mainText.ReadOnly = !value;
                if (value)
                {
                    btn_save.Show();
                    showTopBar();
                }
                else
                {
                    btn_save.Hide();
                    hideTopBar();
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

            rtxt_mainText.Text = noteContent;
            IsEditable = canEdit;

            StickyNoteManager.AddOpenStickyNoteForm(this);
        }

        private void pnl_topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-offsetX, -offsetY);
                Location = newLocation;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            StickyNoteManager.RemoveOpenStickyNoteForm(this);
            Close();
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {
            IsPinned = !IsPinned;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxt_mainText.Text)) return;

            var stickyNoteForm = new StickyNoteForm();
            stickyNoteForm.Show();

            saveNote();
        }

        private void rtxt_mainText_DoubleClick(object sender, EventArgs e)
        {
            IsEditable = true;
            ShowCaret(rtxt_mainText.Handle);
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
                hideTopBar();
        }


        private void pnl_highlight_MouseEnter(object sender, EventArgs e)
        {
            showTopBar();
        }

        private void showTopBar()
        {
            pnl_highlight.Hide();
            pnl_topBar.Show();
        }

        private void hideTopBar()
        {
            pnl_topBar.Hide();
            pnl_highlight.Show();
        }

        private void pnl_topBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void txt_mainNote_GotFocused(object sender, EventArgs e)
        {
            if (!IsEditable)
                HideCaret(rtxt_mainText.Handle);
                
        }

        private void pnl_topBar_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && !IsPinned)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }
    }
}
