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
    public partial class AddTicketForm : Form
    {
        public AddTicketForm()
        {
            InitializeComponent();
        }

        private void AddTicket_Click(object sender, EventArgs e)
        {
            if (NameTicket.Text != "" && PhoneTicket.Text != "")
            {
                AllTickets allTickets = new AllTickets();

                if (new FileInfo("Library/tickets.q").Length != 0)//Проверка, что файл не пустой
                {
                    var loadedallTickets = SaverLoader.Load<AllTickets>("Library/tickets.q");

                    foreach (var ticket in loadedallTickets)
                    {
                        allTickets.Add(ticket);
                    }
                }


                int temp_var = 0;
                //File myFile = new File;
                if (File.Exists("Library/ticketid.txt") == false)
                {
                    var myFile = File.Create("Library/ticketid.txt");
                    myFile.Close();
                    File.WriteAllText("Library/ticketid.txt", "0");

                }
                else
                {
                    var myFile1 = File.ReadAllText("Library/ticketid.txt");
                    temp_var = Convert.ToInt32(myFile1) + 1;
                    File.WriteAllText("Library/ticketid.txt", Convert.ToString(temp_var));
                }



                allTickets.Add(new TicketClass(NameTicket.Text, PassportTicket.Text, AddressTicket.Text, EmailTicket.Text, PhoneTicket.Text, temp_var));


                SaverLoader.Save(allTickets, "Library/tickets.q");

                this.Close();
            }
            else
            {
                NameTicket.Text = "Заполните поля! *";
            }



            
        }
    }
}
