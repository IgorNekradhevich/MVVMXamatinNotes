using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;


namespace App7
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void Update(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        ObservableCollection<Note> notes;
        Note index;
        Model model;


        public NoteCommand ShowCommand
            {
            get {  return model.ShowItem(notes[0]); }
            }
        public Note Index
        {
            get { return index; }
            set { index = value;
                Update("Index");
            }
        }

        public ObservableCollection<Note> Notes
        {
            get { return notes; }
            set
            {
                notes = value;
                Update("Notes");
            }
        }
        public ViewModel(MainPage page )
        {
           

          model  = new Model(page);
            Notes = model.GetNotes();
         
        }
    }
}
