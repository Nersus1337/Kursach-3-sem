using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_v1
{
    [Serializable]
    public class AllBooks : List<BookClass>
    { }



    [Serializable]
    public class BookClass// : List<BookClass>
    {
        public string title;
        public string author;
        public string year;
        public string style;
        public string publish;
        public string place;
        public string condition;
        public string notes;
        public int availability;
        public int id;

        public BookClass (string title, string author, string year, string style, string publish, string place, string condition, string notes, int id)//Конструктор
        {
            this.title= title;
            this.author = author;
            this.title = title;
            this.year = year;
            this.style = style;
            this.publish = publish;
            this.place = place;
            this.condition = condition;
            this.notes = notes;
            this.id = id;
            availability = 0;
        }
        //public List<BookClass> Books = new List<BookClass>();
        //List<BookClass> Books = new List<BookClass> ();
        //List<string> qwes = new List<string>();
        //qwes
    }

    
}
