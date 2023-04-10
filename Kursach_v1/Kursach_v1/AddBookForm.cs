using System;
using System.CodeDom.Compiler;
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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {

            /*
            List<BookClass> Books = new List<BookClass>();

            Books.AddRange(new BookClass[] {
                new BookClass(NameBook.Text, AuthorBook.Text),

            });*/





            //BookClass bookClass = new BookClass(NameBook.Text + " qwe", AuthorBook.Text);
            //SaverLoader.Save(bookClass, "temp.q");
            //var loadedbookClass = SaverLoader.Load<BookClass>("temp.q");
            //NameBook.Text = loadedbookClass.title;

            //BookClass bookClass = new BookClass(NameBook.Text + " qwe", AuthorBook.Text);
            //allBooks.Add(new BookClass(NameBook.Text + " book2", AuthorBook.Text));


            //allBooks.Add(new BookClass(NameBook.Text + " book1", AuthorBook.Text));


            //SaverLoader.Save(allBooks, "books.q");

            //int i = 0;

            if (NameBook.Text != "")
            {
                AllBooks allBooks = new AllBooks();

                if (new FileInfo("Library/books.q").Length != 0)//Проверка, что файл не пустой
                {
                    var loadedallBooks = SaverLoader.Load<AllBooks>("Library/books.q");

                    foreach (var book in loadedallBooks)
                    {
                        //i++;
                        allBooks.Add(book);
                        //book.id = i;
                    }
                }
                int temp_var = 0;
                //File myFile = new File;
                if (File.Exists("Library/bookid.txt") == false)
                {
                    var myFile = File.Create("Library/bookid.txt");
                    myFile.Close();
                    File.WriteAllText("Library/bookid.txt", "0");

                }
                else
                {
                    var myFile1 = File.ReadAllText("Library/bookid.txt");
                    temp_var = Convert.ToInt32(myFile1) + 1;
                    File.WriteAllText("Library/bookid.txt", Convert.ToString(temp_var));
                }


                allBooks.Add(new BookClass(NameBook.Text, AuthorBook.Text, YearBook.Text, StyleBook.Text, PublishBook.Text, PlaceBook.Text, ConditionBook.Text, NotesBook.Text, temp_var));

                SaverLoader.Save(allBooks, "Library/books.q");

                this.Close();
            }
            else
            {
                NameBook.Text = "Введите название книги!";
            }

            

            //UpdateList();
            //

            /*
            var loadedallBooks = SaverLoader.Load<AllBooks>("books.q");
            allBooks.Add(new BookClass(NameBook.Text + " book2", AuthorBook.Text));
            SaverLoader.Save(allBooks, "books.q");
            var loadedallBooks2 = SaverLoader.Load<AllBooks>("books.q");

            
            //foreach (var book in loadedallBooks) {
            string temp = Convert.ToString(loadedallBooks2[0].title);
            NameBook.Text = temp;
            string temp2 = Convert.ToString(loadedallBooks2[1].title);
            AuthorBook.Text = temp2;
            */


            //loadedallBooks[0].title


            //loadedbookClass.title

            //NameBook.Text
            /*
            List<BookClass> Books = new List<BookClass>();
            Books.Add(bookClass);*/
        }
    }
}