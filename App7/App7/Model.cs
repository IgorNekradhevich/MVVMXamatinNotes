using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App7
{
    class Model
    {
        SQLiteConnection connection;
        MainPage mp;
        public Model (MainPage mp)
        {
            this.mp = mp;
            connection = new SQLiteConnection();

            //Note firstNote = new Note();
            //firstNote.Date = "01.01.2001";
            //firstNote.Name = "TestNote";
            //firstNote.Text = "Text of FIrst Note";

            //Note firstNote2 = new Note();
            //firstNote.ID = 0;
            //firstNote2.ID = 0;
            //firstNote2.Date = "01.02.2021";
            //firstNote2.Name = "TestNote2";
            //firstNote2.Text = "Text of FIrst Note 2";
            //connection.connection.InsertAsync(firstNote).Wait();
            //connection.connection.InsertAsync(firstNote2).Wait();
        }
      public NoteCommand ShowItem(Note note)
        {

        return new NoteCommand((o)=> { mp.DisplayAlert(note.Date + " " + note.Name, note.Text, "Ok"); });

        }

        public ObservableCollection <Note> GetNotes()
        {
            ObservableCollection<Note> notes = new ObservableCollection<Note>(connection.GetNoteList());
            return notes;
        }
    }
}
