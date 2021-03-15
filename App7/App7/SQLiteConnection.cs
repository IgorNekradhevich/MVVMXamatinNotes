using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace App7
{
    class SQLiteConnection
    {

        public SQLiteAsyncConnection connection { get; private set; }

        public SQLiteConnection()
        {
            connection = new SQLiteAsyncConnection(Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData) + "//MyNotes.db3");

            connection.CreateTableAsync<Note>();
        }
        public List<Note> GetNoteList()
        {
            Task<List<Note>> result = connection.Table<Note>().ToListAsync();
            return result.Result;
        }
    }
}
