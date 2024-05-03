using System.Data;

namespace SimpleNotes
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
       
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void btn_addNote_Click(object sender, EventArgs e)
        {
            var stickyNoteForm = new StickyNoteForm(txt_title.Text, txt_mainNote.Text);
            stickyNoteForm.Show();
        }
    }
}