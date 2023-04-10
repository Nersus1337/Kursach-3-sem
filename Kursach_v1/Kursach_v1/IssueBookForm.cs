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
    public partial class IssueBookForm : Form
    {
        public int BookId;
        public string BookTitle;

        public IssueBookForm()
        {
            InitializeComponent();
            updateList();
            textBoxIssue.Text = DateTime.Today.ToString("dd/MM/yyyy");
            textBoxReturn.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void updateList()
        {
 
            if (new FileInfo("Library/tickets.q").Length != 0)//Проверка, что файл не пустой
            {
                ListTickets.Items.Clear();
                var loadedallTickets3 = SaverLoader.Load<AllTickets>("Library/tickets.q");
                foreach (var ticket in loadedallTickets3)
                {
                    ListTickets.Items.Add(ticket.name + ", " + ticket.id);
                }

            }

            
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxIssue.Text != "" && ListTickets.SelectedItems.Count != 0 && textBoxReturn.Text != "")
            {
                AllBooks allBooks = new AllBooks();//Изменение параметра книги availability с 0 на 1 (книга выдана)
                var loadedallBooks = SaverLoader.Load<AllBooks>("Library/books.q");
                foreach (var book in loadedallBooks)
                {
                    if (book.id == BookId)
                    {
                        book.availability = 1;
                    }
                    allBooks.Add(book);
                }
                SaverLoader.Save(allBooks, "Library/books.q");


                var loadedallTickets = SaverLoader.Load<AllTickets>("Library/tickets.q");

                int ending = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (loadedallTickets[ListTickets.SelectedIndex].DateIssue[i] == null)
                    {
                        loadedallTickets[ListTickets.SelectedIndex].IssueBookId[i] = BookId;
                        loadedallTickets[ListTickets.SelectedIndex].IssueBookTitle[i] = BookTitle;
                        loadedallTickets[ListTickets.SelectedIndex].DateIssue[i] = textBoxIssue.Text;
                        loadedallTickets[ListTickets.SelectedIndex].DateReturn[i] = textBoxReturn.Text;
                        ending = 1;
                        //textBoxIssue.Text = Convert.ToString(ListTickets.SelectedIndex);

                    }
                    if (ending == 1)
                    {
                        break;
                    }
                }

                SaverLoader.Save(loadedallTickets, "Library/tickets.q");

                this.Close();
            }
            else
            {
                if (textBoxIssue.Text == "")
                {
                    textBoxIssue.Text = "Введите дату выдачи!";
                }
                else
                {
                    textBoxIssue.Text = "Выберите билет!";
                }
                
            }


            
            

        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            NameBook.Text = BookTitle;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ListTickets.Items.Count; i++)
            {
                string NameTicket = ListTickets.Items[i].ToString();
                //YearBook.Text = NameBook;
                if (NameTicket.Contains(textBox1.Text))
                {
                    ListTickets.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
