using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_v1
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
            updateListTickets();
            //updateListIssues();
        }

        public void updateListTickets()
        {
            if (new FileInfo("Library/tickets.q").Length != 0)//Проверка, что файл не пустой
            {
                ListTickets.Items.Clear();
                var loadedallTickets3 = SaverLoader.Load<AllTickets>("Library/tickets.q");
                foreach (var ticket in loadedallTickets3)
                {
                    ListTickets.Items.Add(ticket.name + ", " + ticket.id);
                }
                ListTickets.SelectedIndex = 0;
            }
        }

        //public void updateListIssues()
        //{
        //    if (new FileInfo("tickets.q").Length != 0)//Проверка, что файл не пустой
        //    {
        //        ListIssues.Items.Clear();
        //        var loadedallTickets3 = SaverLoader.Load<AllTickets>("tickets.q");
        //        foreach (var ticket in loadedallTickets3)
        //        {
        //            ListIssues.Items.Add(ticket.IssueBookTitle);
        //        }
        //    }
        //}


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            AddTicketForm ATF = new AddTicketForm();
            ATF.ShowDialog();
            updateListTickets();
        }

        private void ListTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (new FileInfo("Library/tickets.q").Length != 0)//Проверка, что файл не пустой
            {
                ListIssues.Items.Clear();
                var loadedallTickets3 = SaverLoader.Load<AllTickets>("Library/tickets.q");

                for (int i = 0; i < 10; i++)
                {
                    if (loadedallTickets3[ListTickets.SelectedIndex].IssueBookTitle[i] != null)
                    {
                        ListIssues.Items.Add(Convert.ToString(loadedallTickets3[ListTickets.SelectedIndex].IssueBookTitle[i]));
                    }
                }
                //ListIssues.Items.Add(loadedallTickets3[ListTickets.SelectedIndex].DateIssue[1]);
                //ListIssues.Items.Add(loadedallTickets3[ListTickets.SelectedIndex].DateIssue[2]);
                //ListIssues.Items.Add(loadedallTickets3[ListTickets.SelectedIndex].DateReturn[0]);
                //ListIssues.Items.Add(Convert.ToString(loadedallTickets3[ListTickets.SelectedIndex].IssueBookId[0]));
                //ListIssues.Items.Add(ticket.IssueBookTitle);


                labelFio.Text = loadedallTickets3[ListTickets.SelectedIndex].name;
                labelPassport.Text = loadedallTickets3[ListTickets.SelectedIndex].passport;
                labelPhone.Text = loadedallTickets3[ListTickets.SelectedIndex].phone;
                labelAdress.Text = loadedallTickets3[ListTickets.SelectedIndex].address;
                labelEmail.Text = loadedallTickets3[ListTickets.SelectedIndex].email;
                IdTicket.Text = Convert.ToString(loadedallTickets3[ListTickets.SelectedIndex].id);


                //loadedallTickets3
            }
            
        }

        private void ListIssues_SelectedIndexChanged(object sender, EventArgs e)
        {
            var loadedallTickets3 = SaverLoader.Load<AllTickets>("Library/tickets.q");

            NameBook.Text = loadedallTickets3[ListTickets.SelectedIndex].IssueBookTitle[ListIssues.SelectedIndex];
            IssueDateBook.Text = loadedallTickets3[ListTickets.SelectedIndex].DateIssue[ListIssues.SelectedIndex];
            ReturnDateBook.Text = loadedallTickets3[ListTickets.SelectedIndex].DateReturn[ListIssues.SelectedIndex];

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            if (ListIssues.SelectedItems.Count != 0)
            {
                var loadedallTickets3 = SaverLoader.Load<AllTickets>("Library/tickets.q");

                //available -> 0
                AllBooks allBooks = new AllBooks();//Изменение параметра книги availability с 1 на 0 (книга возвращена)

                var loadedallBooks = SaverLoader.Load<AllBooks>("Library/books.q");
                foreach (var book in loadedallBooks)
                {
                    if (book.id == loadedallTickets3[ListTickets.SelectedIndex].IssueBookId[ListIssues.SelectedIndex])
                    {
                        book.availability = 0;
                    }
                    allBooks.Add(book);
                }
                SaverLoader.Save(allBooks, "Library/books.q");


                int lastEl_listIssues = 0;
                for (int i = 0; i < 9; i++)
                {
                    if (loadedallTickets3[ListTickets.SelectedIndex].DateIssue[i] == null)
                    {
                        lastEl_listIssues = i - 1;
                        break;
                    }
                }


                loadedallTickets3[ListTickets.SelectedIndex].IssueBookTitle[ListIssues.SelectedIndex] = loadedallTickets3[ListTickets.SelectedIndex].IssueBookTitle[9];
                loadedallTickets3[ListTickets.SelectedIndex].IssueBookId[ListIssues.SelectedIndex] = loadedallTickets3[ListTickets.SelectedIndex].IssueBookId[9];
                loadedallTickets3[ListTickets.SelectedIndex].DateIssue[ListIssues.SelectedIndex] = loadedallTickets3[ListTickets.SelectedIndex].DateIssue[9];
                loadedallTickets3[ListTickets.SelectedIndex].DateReturn[ListIssues.SelectedIndex] = loadedallTickets3[ListTickets.SelectedIndex].DateReturn[9];
                //if (loadedallTickets3[ListTickets.SelectedIndex].DateIssue[ListIssues.SelectedItems.Count-1] != null )
                //{
                loadedallTickets3[ListTickets.SelectedIndex].IssueBookTitle[ListIssues.SelectedIndex] = loadedallTickets3[ListTickets.SelectedIndex].IssueBookTitle[lastEl_listIssues];
                loadedallTickets3[ListTickets.SelectedIndex].IssueBookId[ListIssues.SelectedIndex] = loadedallTickets3[ListTickets.SelectedIndex].IssueBookId[lastEl_listIssues];
                loadedallTickets3[ListTickets.SelectedIndex].DateIssue[ListIssues.SelectedIndex] = loadedallTickets3[ListTickets.SelectedIndex].DateIssue[lastEl_listIssues];
                loadedallTickets3[ListTickets.SelectedIndex].DateReturn[ListIssues.SelectedIndex] = loadedallTickets3[ListTickets.SelectedIndex].DateReturn[lastEl_listIssues];
                //}
                loadedallTickets3[ListTickets.SelectedIndex].IssueBookTitle[lastEl_listIssues] = loadedallTickets3[ListTickets.SelectedIndex].IssueBookTitle[9];
                loadedallTickets3[ListTickets.SelectedIndex].IssueBookId[lastEl_listIssues] = loadedallTickets3[ListTickets.SelectedIndex].IssueBookId[9];
                loadedallTickets3[ListTickets.SelectedIndex].DateIssue[lastEl_listIssues] = loadedallTickets3[ListTickets.SelectedIndex].DateIssue[9];
                loadedallTickets3[ListTickets.SelectedIndex].DateReturn[lastEl_listIssues] = loadedallTickets3[ListTickets.SelectedIndex].DateReturn[9];

                AllTickets allTickets = new AllTickets();

                if (new FileInfo("Library/tickets.q").Length != 0)//Проверка, что файл не пустой
                {
                    //var loadedallTickets3 = SaverLoader.Load<AllTickets>("tickets.q");

                    foreach (var ticket in loadedallTickets3)
                    {
                        allTickets.Add(ticket);
                    }
                }

                SaverLoader.Save(allTickets, "Library/tickets.q");

                ////////////////////////////////////////////////////////
                ListIssues.Items.Clear();
                var loadedallTickets = SaverLoader.Load<AllTickets>("Library/tickets.q");

                for (int i = 0; i < 10; i++)
                {
                    if (loadedallTickets[ListTickets.SelectedIndex].IssueBookTitle[i] != null)
                    {
                        ListIssues.Items.Add(Convert.ToString(loadedallTickets[ListTickets.SelectedIndex].IssueBookTitle[i]));
                    }
                }
                label6.Text = "Текущее состояние:";
            }
            else
            {
                label6.Text = "Выберите книгу!";
            }

            

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditTicketForm ETF = new EditTicketForm();
            ETF.TicketPosition = ListTickets.SelectedIndex;
            ETF.TicketId = Convert.ToInt32(IdTicket.Text);
            ETF.ShowDialog();
            updateListTickets();
        }

        private void ExtendButton_Click(object sender, EventArgs e)
        {
            label17.Visible = true;
            newDateReturn.Visible = true;
            AcceptExtendButton.Visible = true;
        }

        private void AcceptExtendButton_Click(object sender, EventArgs e)
        {
            if (newDateReturn.Text != "")
            {
                var loadedallTickets = SaverLoader.Load<AllTickets>("Library/tickets.q");

                loadedallTickets[ListTickets.SelectedIndex].DateReturn[ListIssues.SelectedIndex] = newDateReturn.Text;

                newDateReturn.Text = DateTime.Now.ToString("dd/MM/yyyy");

                AllTickets allTickets = new AllTickets();

                if (new FileInfo("Library/tickets.q").Length != 0)//Проверка, что файл не пустой
                {
                    //var loadedallTickets = SaverLoader.Load<AllTickets>("tickets.q");

                    foreach (var ticket in loadedallTickets)
                    {
                        allTickets.Add(ticket);
                    }
                }
                SaverLoader.Save(allTickets, "Library/tickets.q");

                label17.Visible = false;
                newDateReturn.Visible = false;
                AcceptExtendButton.Visible = false;

                ListIssues.SelectedIndex = 0;
                //ListIssues.SelectedItem = 1;
                //ListIssues.SelectedItem = 0;
            }
            else
            {
                newDateReturn.Text = "Введите дату возврата!";
            }


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


            /*
            var loadedallTickets = SaverLoader.Load<AllTickets>("tickets.q");

            if (new FileInfo("tickets.q").Length != 0)//Проверка, что файл не пустой
            {
                ListTickets.Items.Clear();

                foreach (var ticket in loadedallTickets)
                {
                    if (ticket.name.Contains(textBox1.Text))
                    {
                        ListTickets.Items.Add(ticket.name + ", " + ticket.id);
                    }
                }
            }
            */
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var loadedallTickets = SaverLoader.Load<AllTickets>("Library/tickets.q");
            AllTickets allTickets = new AllTickets();

            if (new FileInfo("Library/tickets.q").Length != 0)//Проверка, что файл не пустой
            {
                foreach (var ticket in loadedallTickets)
                {
                    if (Convert.ToInt32(IdTicket.Text) != ticket.id)
                    {
                        allTickets.Add(ticket);
                    }
                    else
                    {

                    }

                }

            }
            SaverLoader.Save(allTickets, "Library/tickets.q");
            updateListTickets();
        }
    }
}
