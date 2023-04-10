using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kursach_v1
{
    public partial class LoginForm : Form
    {
        private int start;

        public LoginForm()
        {
            InitializeComponent();

            if (Directory.Exists("Library") == false)//Основная папка всей программы
            {
                Directory.CreateDirectory("Library");
            }

            if (File.Exists("Library/books.q")==false)
            {
                var myFile = File.Create("Library/books.q");
                myFile.Close();
            }

            if (File.Exists("Library/tickets.q") == false)
            {
                var myFilee = File.Create("Library/tickets.q");
                myFilee.Close();
            }

            if (File.Exists("Library/password.txt") == false)
            {
                label4.Visible = false;
                textBox3.Visible = false;
                start = 0;
            }
            else
            {
                start = 1;
                label2.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //string path = "Accounts.txt";
            //File.Create(path);
        }

        private void button1_Click(object sender, EventArgs e)//Кнопка войти
        {
            if (start == 0)
            {

            }
            if (File.Exists("Library/password.txt") == false)
            {

                if ((textBox1.Text == textBox2.Text) && (textBox1.Text.Length > 4))
                {
                    var myFilee = File.Create("Library/password.txt");
                    myFilee.Close();
                    File.WriteAllText("Library/password.txt", textBox1.Text);

                    MainForm MF = new MainForm();
                    Hide();
                    MF.ShowDialog();
                    this.Close();
                }
                else
                {
                    textBox2.Text = "Пароли не совпадают!";
                }


            }
            else
            {
                if (textBox3.Text == File.ReadAllText("Library/password.txt"))
                {
                    MainForm MF = new MainForm();
                    Hide();
                    MF.ShowDialog();
                    this.Close();
                }
                else
                {
                    textBox3.Text = "Пароль неверный!";
                }
            }










        }
    }
}
