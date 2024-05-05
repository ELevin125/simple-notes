using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace SimpleNotes
{
    public static class StickyNoteManager
    {
        public static List<StickyNoteForm> openStickyNotes = new List<StickyNoteForm>();

        public static void AddOpenStickyNoteForm(StickyNoteForm stickyNoteForm)
        {
            openStickyNotes.Add(stickyNoteForm);
        }
        
        public static void RemoveOpenStickyNoteForm(StickyNoteForm stickyNoteForm)
        {
            openStickyNotes.Remove(stickyNoteForm);

            // If there are no open sticky notes, close the application
            if (openStickyNotes.Count <= 1)
                Application.Exit();
        }

        public static void CloseAllOpenStickyNotes()
        {
            foreach (var stickyNoteForm in openStickyNotes)
            {
                stickyNoteForm.Close();
            }
        }

        public static void InitializeFirstStickyNote()
        {
            var firstStickyNoteForm = new StickyNoteForm();
            AddOpenStickyNoteForm(firstStickyNoteForm);
            firstStickyNoteForm.Show();
        }
    }
}