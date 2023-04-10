namespace Kursach_v1
{
    partial class MainForm
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
            this.add_book = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.name_book = new System.Windows.Forms.Label();
            this.author_book = new System.Windows.Forms.Label();
            this.ListBooks = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.TitleBook = new System.Windows.Forms.Label();
            this.AuthorBook = new System.Windows.Forms.Label();
            this.YearBook = new System.Windows.Forms.Label();
            this.StyleBook = new System.Windows.Forms.Label();
            this.PublishBook = new System.Windows.Forms.Label();
            this.PlaceBook = new System.Windows.Forms.Label();
            this.ConditionBook = new System.Windows.Forms.Label();
            this.NotesBook = new System.Windows.Forms.Label();
            this.EditBookButton = new System.Windows.Forms.Button();
            this.IssueBookButton = new System.Windows.Forms.Button();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.IdBook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AvailableBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_book
            // 
            this.add_book.Location = new System.Drawing.Point(14, 14);
            this.add_book.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(155, 27);
            this.add_book.TabIndex = 0;
            this.add_book.Text = "Добавить книгу";
            this.add_book.UseVisualStyleBackColor = true;
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(177, 14);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(155, 27);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(343, 14);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(155, 27);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Обновить (F5)";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Читательские билеты";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(672, 14);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "История";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(13, 60);
            this.search.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(45, 15);
            this.search.TabIndex = 5;
            this.search.Text = "Поиск:";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(68, 58);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(160, 21);
            this.textBox_search.TabIndex = 6;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // name_book
            // 
            this.name_book.AutoSize = true;
            this.name_book.Location = new System.Drawing.Point(14, 95);
            this.name_book.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.name_book.Name = "name_book";
            this.name_book.Size = new System.Drawing.Size(64, 15);
            this.name_book.TabIndex = 7;
            this.name_book.Text = "Название";
            // 
            // author_book
            // 
            this.author_book.AutoSize = true;
            this.author_book.Location = new System.Drawing.Point(142, 95);
            this.author_book.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.author_book.Name = "author_book";
            this.author_book.Size = new System.Drawing.Size(42, 15);
            this.author_book.TabIndex = 8;
            this.author_book.Text = "Автор";
            // 
            // ListBooks
            // 
            this.ListBooks.FormattingEnabled = true;
            this.ListBooks.ItemHeight = 15;
            this.ListBooks.Location = new System.Drawing.Point(14, 117);
            this.ListBooks.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ListBooks.Name = "ListBooks";
            this.ListBooks.Size = new System.Drawing.Size(219, 544);
            this.ListBooks.TabIndex = 9;
            this.ListBooks.SelectedIndexChanged += new System.EventHandler(this.ListBooks_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(835, 14);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 27);
            this.button5.TabIndex = 10;
            this.button5.Text = "Справка";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // TitleBook
            // 
            this.TitleBook.AutoSize = true;
            this.TitleBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleBook.Location = new System.Drawing.Point(238, 56);
            this.TitleBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TitleBook.Name = "TitleBook";
            this.TitleBook.Size = new System.Drawing.Size(57, 24);
            this.TitleBook.TabIndex = 12;
            this.TitleBook.Text = "Врем";
            // 
            // AuthorBook
            // 
            this.AuthorBook.AutoSize = true;
            this.AuthorBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorBook.Location = new System.Drawing.Point(502, 55);
            this.AuthorBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AuthorBook.Name = "AuthorBook";
            this.AuthorBook.Size = new System.Drawing.Size(49, 20);
            this.AuthorBook.TabIndex = 13;
            this.AuthorBook.Text = "Врем";
            // 
            // YearBook
            // 
            this.YearBook.AutoSize = true;
            this.YearBook.Location = new System.Drawing.Point(330, 104);
            this.YearBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.YearBook.Name = "YearBook";
            this.YearBook.Size = new System.Drawing.Size(38, 15);
            this.YearBook.TabIndex = 14;
            this.YearBook.Text = "Врем";
            // 
            // StyleBook
            // 
            this.StyleBook.AutoSize = true;
            this.StyleBook.Location = new System.Drawing.Point(282, 150);
            this.StyleBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StyleBook.Name = "StyleBook";
            this.StyleBook.Size = new System.Drawing.Size(38, 15);
            this.StyleBook.TabIndex = 15;
            this.StyleBook.Text = "Врем";
            // 
            // PublishBook
            // 
            this.PublishBook.AutoSize = true;
            this.PublishBook.Location = new System.Drawing.Point(342, 196);
            this.PublishBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PublishBook.Name = "PublishBook";
            this.PublishBook.Size = new System.Drawing.Size(38, 15);
            this.PublishBook.TabIndex = 16;
            this.PublishBook.Text = "Врем";
            // 
            // PlaceBook
            // 
            this.PlaceBook.AutoSize = true;
            this.PlaceBook.Location = new System.Drawing.Point(378, 242);
            this.PlaceBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlaceBook.Name = "PlaceBook";
            this.PlaceBook.Size = new System.Drawing.Size(38, 15);
            this.PlaceBook.TabIndex = 17;
            this.PlaceBook.Text = "Врем";
            // 
            // ConditionBook
            // 
            this.ConditionBook.AutoSize = true;
            this.ConditionBook.Location = new System.Drawing.Point(321, 288);
            this.ConditionBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ConditionBook.Name = "ConditionBook";
            this.ConditionBook.Size = new System.Drawing.Size(38, 15);
            this.ConditionBook.TabIndex = 18;
            this.ConditionBook.Text = "Врем";
            // 
            // NotesBook
            // 
            this.NotesBook.AutoSize = true;
            this.NotesBook.Location = new System.Drawing.Point(309, 334);
            this.NotesBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NotesBook.Name = "NotesBook";
            this.NotesBook.Size = new System.Drawing.Size(38, 15);
            this.NotesBook.TabIndex = 19;
            this.NotesBook.Text = "Врем";
            // 
            // EditBookButton
            // 
            this.EditBookButton.Location = new System.Drawing.Point(241, 501);
            this.EditBookButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.EditBookButton.Name = "EditBookButton";
            this.EditBookButton.Size = new System.Drawing.Size(151, 37);
            this.EditBookButton.TabIndex = 20;
            this.EditBookButton.Text = "Редактировать";
            this.EditBookButton.UseVisualStyleBackColor = true;
            this.EditBookButton.Click += new System.EventHandler(this.EditBookButton_Click);
            // 
            // IssueBookButton
            // 
            this.IssueBookButton.Location = new System.Drawing.Point(241, 556);
            this.IssueBookButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.IssueBookButton.Name = "IssueBookButton";
            this.IssueBookButton.Size = new System.Drawing.Size(151, 34);
            this.IssueBookButton.TabIndex = 21;
            this.IssueBookButton.Text = "Выдать";
            this.IssueBookButton.UseVisualStyleBackColor = true;
            this.IssueBookButton.Click += new System.EventHandler(this.IssueBookButton_Click);
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.Location = new System.Drawing.Point(241, 606);
            this.DeleteBookButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(151, 34);
            this.DeleteBookButton.TabIndex = 22;
            this.DeleteBookButton.Text = "Удалить";
            this.DeleteBookButton.UseVisualStyleBackColor = true;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click);
            // 
            // IdBook
            // 
            this.IdBook.AutoSize = true;
            this.IdBook.Location = new System.Drawing.Point(263, 380);
            this.IdBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.IdBook.Name = "IdBook";
            this.IdBook.Size = new System.Drawing.Size(17, 15);
            this.IdBook.TabIndex = 23;
            this.IdBook.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 380);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Заметки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Состояние:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Место в библиотеке:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Издательство:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Жанр:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Год издания:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 426);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Наличие:";
            // 
            // AvailableBook
            // 
            this.AvailableBook.AutoSize = true;
            this.AvailableBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvailableBook.Location = new System.Drawing.Point(308, 428);
            this.AvailableBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AvailableBook.Name = "AvailableBook";
            this.AvailableBook.Size = new System.Drawing.Size(38, 13);
            this.AvailableBook.TabIndex = 32;
            this.AvailableBook.Text = "Врем";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 677);
            this.Controls.Add(this.AvailableBook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IdBook);
            this.Controls.Add(this.DeleteBookButton);
            this.Controls.Add(this.IssueBookButton);
            this.Controls.Add(this.EditBookButton);
            this.Controls.Add(this.NotesBook);
            this.Controls.Add(this.ConditionBook);
            this.Controls.Add(this.PlaceBook);
            this.Controls.Add(this.PublishBook);
            this.Controls.Add(this.StyleBook);
            this.Controls.Add(this.YearBook);
            this.Controls.Add(this.AuthorBook);
            this.Controls.Add(this.TitleBook);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ListBooks);
            this.Controls.Add(this.author_book);
            this.Controls.Add(this.name_book);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.add_book);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_book;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label name_book;
        private System.Windows.Forms.Label author_book;
        private System.Windows.Forms.ListBox ListBooks;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label TitleBook;
        private System.Windows.Forms.Label AuthorBook;
        private System.Windows.Forms.Label YearBook;
        private System.Windows.Forms.Label StyleBook;
        private System.Windows.Forms.Label PublishBook;
        private System.Windows.Forms.Label PlaceBook;
        private System.Windows.Forms.Label ConditionBook;
        private System.Windows.Forms.Label NotesBook;
        private System.Windows.Forms.Button EditBookButton;
        private System.Windows.Forms.Button IssueBookButton;
        private System.Windows.Forms.Button DeleteBookButton;
        private System.Windows.Forms.Label IdBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label AvailableBook;
    }
}