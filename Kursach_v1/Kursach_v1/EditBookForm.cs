using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Kursach_v1
{

    

    public partial class EditBookForm : Form
    {
        public int BookId; //Id книги для редактирования


        public EditBookForm()
        {
            InitializeComponent();

            //BookId = BookId;
            //int BookId1 = int.Parse(test_label_id.Text);

            //int BookId2 = Convert.ToInt32(BookId1);

            //var loadedallBooks = SaverLoader.Load<AllBooks>("books.q");

            //NameBook.Text = loadedallBooks[BookId].title;
            /*
            NameBook.Text = textBox_test_id.Text;
            AuthorBook.Text = loadedallBooks[BookId].author;
            YearBook.Text = loadedallBooks[BookId].year;
            StyleBook.Text = loadedallBooks[BookId].style;
            PublishBook.Text = loadedallBooks[BookId].publish;
            PlaceBook.Text = textBox_test_id.Text;
            ConditionBook.Text = "qweqweqwe";
            NotesBook.Text = loadedallBooks[BookId].notes;
            */

            /*
            

            foreach (var book in loadedallBooks)
            {
                if (book.id == BookId)
                {
                    NameBook.Text = book.title;
                    AuthorBook.Text = book.author;
                    YearBook.Text = book.year;
                    StyleBook.Text = book.style;
                    PublishBook.Text = book.publish;
                    PlaceBook.Text = book.place;
                    ConditionBook.Text = "qweqweqwe";
                    NotesBook.Text = loadedallBooks[BookId].notes;
                }
            }
            */
        }



        private void EditBook_Click(object sender, EventArgs e)
        {
            if (NameBook.Text != "")
            {
                AllBooks allBooks = new AllBooks();

                var loadedallBooks = SaverLoader.Load<AllBooks>("Library/books.q");

                foreach (var book in loadedallBooks)
                {
                    if (book.id == BookId)
                    {
                        book.title = NameBook.Text;
                        book.author = AuthorBook.Text;
                        book.year = YearBook.Text;
                        book.style = StyleBook.Text;
                        book.publish = PublishBook.Text;
                        book.place = PlaceBook.Text;
                        book.condition = ConditionBook.Text;
                        book.notes = NotesBook.Text;
                    }
                    allBooks.Add(book);
                }

                SaverLoader.Save(allBooks, "Library/books.q");


                this.Close();
            }
            else
            {
                NameBook.Text = "Введите название книги!";
            }

                


        }
    }
}
