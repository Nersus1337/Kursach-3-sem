using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_v1
{
    public partial class EditTicketForm : Form
    {
        public EditTicketForm()
        {
            InitializeComponent();
        }
        public int TicketPosition;
        public int TicketId;

        private void EditTicketForm_Load(object sender, EventArgs e)
        {
            var loadedallTickets = SaverLoader.Load<AllTickets>("Library/tickets.q");

            NameTicket.Text = loadedallTickets[TicketPosition].name;
            PhoneTicket.Text = loadedallTickets[TicketPosition].phone;
            EmailTicket.Text = loadedallTickets[TicketPosition].email;
            PassportTicket.Text = loadedallTickets[TicketPosition].passport;
            AddressTicket.Text = loadedallTickets[TicketPosition].address;
        }

        private void EditTicket_Click(object sender, EventArgs e)
        {
            if (NameTicket.Text != "" && PhoneTicket.Text != "")
            {
                AllTickets allTickets = new AllTickets();

                var loadedallTickets = SaverLoader.Load<AllTickets>("Library/tickets.q");

                foreach (var ticket in loadedallTickets)
                {
                    if (ticket.id == TicketId)
                    {
                        ticket.name = NameTicket.Text;
                        ticket.phone = PhoneTicket.Text;
                        ticket.email = EmailTicket.Text;
                        ticket.passport = PassportTicket.Text;
                        ticket.address = AddressTicket.Text;
                    }
                    allTickets.Add(ticket);
                }

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
