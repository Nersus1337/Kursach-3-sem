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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == textBox2.Text) && (textBox1.Text.Length > 4))
            {
                File.WriteAllText("Library/password.txt", textBox1.Text);
                this.Close();
            }
            else
            {
                textBox1.Text = "Пароли не совпадают!";
            }
        }
    }
}
