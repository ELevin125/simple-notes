using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotes
{
    public partial class StickyNoteForm : Form
    {
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
    }
}
