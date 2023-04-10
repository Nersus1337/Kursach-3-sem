namespace Kursach_v1
{
    partial class TicketsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ListTickets = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFio = new System.Windows.Forms.Label();
            this.labelPassport = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.NameBook = new System.Windows.Forms.Label();
            this.IssueDateBook = new System.Windows.Forms.Label();
            this.ReturnDateBook = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ListIssues = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ExtendButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.IdTicket = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.AcceptExtendButton = new System.Windows.Forms.Button();
            this.newDateReturn = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список читательских билетов:";
            // 
            // ListTickets
            // 
            this.ListTickets.FormattingEnabled = true;
            this.ListTickets.ItemHeight = 15;
            this.ListTickets.Location = new System.Drawing.Point(13, 84);
            this.ListTickets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListTickets.Name = "ListTickets";
            this.ListTickets.Size = new System.Drawing.Size(272, 319);
            this.ListTickets.TabIndex = 1;
            this.ListTickets.SelectedIndexChanged += new System.EventHandler(this.ListTickets_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поиск:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(302, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Информация:";
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Location = new System.Drawing.Point(349, 98);
            this.labelFio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(41, 15);
            this.labelFio.TabIndex = 6;
            this.labelFio.Text = "label6";
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Location = new System.Drawing.Point(370, 191);
            this.labelPassport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(41, 15);
            this.labelPassport.TabIndex = 7;
            this.labelPassport.Text = "label6";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(373, 129);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 15);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "label6";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(354, 222);
            this.labelAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(41, 15);
            this.labelAdress.TabIndex = 9;
            this.labelAdress.Text = "label6";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(356, 161);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 15);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(652, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Текущее состояние:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(306, 9);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(155, 27);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(469, 9);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(155, 27);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(632, 9);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(155, 27);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Создать билет";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // NameBook
            // 
            this.NameBook.AutoSize = true;
            this.NameBook.Location = new System.Drawing.Point(762, 98);
            this.NameBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameBook.Name = "NameBook";
            this.NameBook.Size = new System.Drawing.Size(11, 15);
            this.NameBook.TabIndex = 15;
            this.NameBook.Text = "-";
            // 
            // IssueDateBook
            // 
            this.IssueDateBook.AutoSize = true;
            this.IssueDateBook.Location = new System.Drawing.Point(746, 129);
            this.IssueDateBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IssueDateBook.Name = "IssueDateBook";
            this.IssueDateBook.Size = new System.Drawing.Size(11, 15);
            this.IssueDateBook.TabIndex = 16;
            this.IssueDateBook.Text = "-";
            // 
            // ReturnDateBook
            // 
            this.ReturnDateBook.AutoSize = true;
            this.ReturnDateBook.Location = new System.Drawing.Point(758, 160);
            this.ReturnDateBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReturnDateBook.Name = "ReturnDateBook";
            this.ReturnDateBook.Size = new System.Drawing.Size(11, 15);
            this.ReturnDateBook.TabIndex = 17;
            this.ReturnDateBook.Text = "-";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(655, 189);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(90, 27);
            this.ReturnButton.TabIndex = 18;
            this.ReturnButton.Text = "Вернуть";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ListIssues
            // 
            this.ListIssues.FormattingEnabled = true;
            this.ListIssues.ItemHeight = 15;
            this.ListIssues.Location = new System.Drawing.Point(889, 38);
            this.ListIssues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListIssues.Name = "ListIssues";
            this.ListIssues.Size = new System.Drawing.Size(212, 364);
            this.ListIssues.TabIndex = 19;
            this.ListIssues.SelectedIndexChanged += new System.EventHandler(this.ListIssues_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "E-mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Адрес:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Телефон:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Паспорт:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "ФИО:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(944, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Выданные книги:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(652, 98);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "Название книги:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(652, 129);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Дата выдачи:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(652, 160);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "Дата возврата:";
            // 
            // ExtendButton
            // 
            this.ExtendButton.Location = new System.Drawing.Point(753, 189);
            this.ExtendButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExtendButton.Name = "ExtendButton";
            this.ExtendButton.Size = new System.Drawing.Size(90, 27);
            this.ExtendButton.TabIndex = 29;
            this.ExtendButton.Text = "Продлить";
            this.ExtendButton.UseVisualStyleBackColor = true;
            this.ExtendButton.Click += new System.EventHandler(this.ExtendButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(302, 253);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 15);
            this.label16.TabIndex = 30;
            this.label16.Text = "Id:";
            // 
            // IdTicket
            // 
            this.IdTicket.AutoSize = true;
            this.IdTicket.Location = new System.Drawing.Point(330, 253);
            this.IdTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdTicket.Name = "IdTicket";
            this.IdTicket.Size = new System.Drawing.Size(17, 15);
            this.IdTicket.TabIndex = 31;
            this.IdTicket.Text = "Id";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(652, 237);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(185, 15);
            this.label17.TabIndex = 32;
            this.label17.Text = "Введите новую дату возврата:";
            this.label17.Visible = false;
            // 
            // AcceptExtendButton
            // 
            this.AcceptExtendButton.Location = new System.Drawing.Point(685, 292);
            this.AcceptExtendButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AcceptExtendButton.Name = "AcceptExtendButton";
            this.AcceptExtendButton.Size = new System.Drawing.Size(102, 27);
            this.AcceptExtendButton.TabIndex = 33;
            this.AcceptExtendButton.Text = "Подтвердить";
            this.AcceptExtendButton.UseVisualStyleBackColor = true;
            this.AcceptExtendButton.Visible = false;
            this.AcceptExtendButton.Click += new System.EventHandler(this.AcceptExtendButton_Click);
            // 
            // newDateReturn
            // 
            this.newDateReturn.Location = new System.Drawing.Point(655, 265);
            this.newDateReturn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newDateReturn.Name = "newDateReturn";
            this.newDateReturn.Size = new System.Drawing.Size(168, 21);
            this.newDateReturn.TabIndex = 34;
            this.newDateReturn.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 21);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 418);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newDateReturn);
            this.Controls.Add(this.AcceptExtendButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.IdTicket);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ExtendButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ListIssues);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ReturnDateBook);
            this.Controls.Add(this.IssueDateBook);
            this.Controls.Add(this.NameBook);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.labelFio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListTickets);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TicketsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Читательсике билеты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label NameBook;
        private System.Windows.Forms.Label IssueDateBook;
        private System.Windows.Forms.Label ReturnDateBook;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ListBox ListIssues;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ExtendButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label IdTicket;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button AcceptExtendButton;
        private System.Windows.Forms.TextBox newDateReturn;
        private System.Windows.Forms.TextBox textBox1;
    }
}