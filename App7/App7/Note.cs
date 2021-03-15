using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace App7
{
    class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
    }
}
