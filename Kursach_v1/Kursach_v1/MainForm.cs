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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            updateList();
        }

        

        private void add_book_Click(object sender, EventArgs e)
        {
            AddBookForm ABF = new AddBookForm();
            ABF.ShowDialog();
            updateList();
        }

        public void updateList ()
        {
            if (new FileInfo("Library/books.q").Length!=0)//Проверка, что файл не пустой
            {
                ListBooks.Items.Clear();
                var loadedallBooks3 = SaverLoader.Load<AllBooks>("Library/books.q");
                foreach (var book in loadedallBooks3)
                {
                    if (book.availability==1)
                    {
                        ListBooks.Items.Add(book.title + " " + book.author + " $");
                    }
                    else
                    {
                        ListBooks.Items.Add(book.title + " " + book.author);
                    }
                    
                }
                ListBooks.SelectedIndex = 0;
            }
            
            //ListBooks.colo
        }

        private void ListBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var loadedallBooks4 = SaverLoader.Load<AllBooks>("Library/books.q");

            
            //textBox_search.Text = loadedallBooks4[ListBooks.SelectedIndex].title;
            TitleBook.Text = loadedallBooks4[ListBooks.SelectedIndex].title;
            AuthorBook.Text = loadedallBooks4[ListBooks.SelectedIndex].author;
            YearBook.Text = loadedallBooks4[ListBooks.SelectedIndex].year;
            StyleBook.Text = loadedallBooks4[ListBooks.SelectedIndex].style;
            PublishBook.Text = loadedallBooks4[ListBooks.SelectedIndex].publish;
            PlaceBook.Text = loadedallBooks4[ListBooks.SelectedIndex].place;
            ConditionBook.Text = loadedallBooks4[ListBooks.SelectedIndex].condition;
            NotesBook.Text = loadedallBooks4[ListBooks.SelectedIndex].notes;
            IdBook.Text = Convert.ToString(loadedallBooks4[ListBooks.SelectedIndex].id);
            if (loadedallBooks4[ListBooks.SelectedIndex].availability == 1)
            {
                AvailableBook.Text = "Выдана";
            }
            else
            {
                AvailableBook.Text = "В наличии";
            }
            

            //updateList();
            //ListBooks.SelectedIndex
        }

        private void IssueBookButton_Click(object sender, EventArgs e)//Выдать книгу кнопка
        {
            IssueBookForm IBF = new IssueBookForm();
            IBF.BookId = Convert.ToInt32(IdBook.Text);
            IBF.BookTitle = TitleBook.Text;
            IBF.ShowDialog();
            updateList();


            //Так
            /*
            var loadedallBooks5 = SaverLoader.Load<AllBooks>("books.q");
            loadedallBooks5[ListBooks.SelectedIndex].availability = 1;

            TicketClass.AllIssues allIssues = new TicketClass.AllIssues();

            allIssues[1].DateIssue = "qwe";*/

            //TicketClass.IssueClass TESTOR = new TicketClass.IssueClass();



            //loa
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)//Удалить книгу
        {
            var loadedallBooks5 = SaverLoader.Load<AllBooks>("Library/books.q");
            loadedallBooks5.RemoveAt(ListBooks.SelectedIndex);
            SaverLoader.Save(loadedallBooks5, "Library/books.q");
            updateList();
        }

        private void EditBookButton_Click(object sender, EventArgs e)//Редактировать книгу
        {
            EditBookForm EBF = new EditBookForm();
            
            EBF.NameBook.Text = TitleBook.Text;
            EBF.AuthorBook.Text = AuthorBook.Text;
            EBF.YearBook.Text = YearBook.Text;
            EBF.StyleBook.Text = StyleBook.Text;
            EBF.PublishBook.Text = PublishBook.Text;
            EBF.PlaceBook.Text = PlaceBook.Text;
            EBF.ConditionBook.Text = ConditionBook.Text;
            EBF.NotesBook.Text = NotesBook.Text;

            EBF.BookId = Convert.ToInt32(IdBook.Text);
            //EBF.textBox_test_id.Text = Convert.ToString(ListBooks.SelectedIndex);
            EBF.ShowDialog();
            updateList();
        }

        private void button3_Click(object sender, EventArgs e)//Форма читательских билетов
        {
            TicketsForm TF = new TicketsForm();
            TF.ShowDialog();
            updateList();
        }


      

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            //var loadedallBooks6 = SaverLoader.Load<AllBooks>("books.q");

            for (int i = 0; i < ListBooks.Items.Count; i++)
            {
                string NameBook = ListBooks.Items[i].ToString();
                //YearBook.Text = NameBook;
                if (NameBook.Contains(textBox_search.Text))
                {
                    ListBooks.SelectedIndex = i;
                    break;
                }
            }





            /*
            if (new FileInfo("books.q").Length != 0)//Проверка, что файл не пустой
            {
                ListBooks.Items.Clear();
                
                foreach (var book in loadedallBooks6)
                {
                    if (book.title.Contains(textBox_search.Text))
                    {
                        ListBooks.Items.Add(book.title + " " + book.author);
                    }
                }
            }
            */

        }

        

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            updateList();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm SF = new SettingsForm();
            SF.ShowDialog();
        }
    }
}
