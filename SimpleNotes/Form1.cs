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

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            previousNotes.DataSource = notes;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Not a valid Note"); }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            boxTitle.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            boxNote.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            boxTitle.Text = "";
            boxNote.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = boxTitle.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = boxNote.Text;
            }
            else
            {
                notes.Rows.Add(boxTitle.Text, boxNote.Text);
            }
            boxTitle.Text = "";
            boxNote.Text = "";
            editing = false;
        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            boxTitle.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            boxNote.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}