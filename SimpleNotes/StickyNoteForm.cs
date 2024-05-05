using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SimpleNotes
{
    public partial class StickyNoteForm : Form
    {
        // Custom window draggin variables
        private bool isDragging = false;
        private int offsetX, offsetY;

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

            txt_mainNote.Text = noteContent;
            IsEditable = canEdit;
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
