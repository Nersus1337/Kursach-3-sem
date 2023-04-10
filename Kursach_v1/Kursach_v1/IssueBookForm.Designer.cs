namespace Kursach_v1
{
    partial class IssueBookForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListTickets = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIssue = new System.Windows.Forms.TextBox();
            this.textBoxReturn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NameBook = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Поиск:";
            // 
            // ListTickets
            // 
            this.ListTickets.FormattingEnabled = true;
            this.ListTickets.ItemHeight = 15;
            this.ListTickets.Location = new System.Drawing.Point(13, 87);
            this.ListTickets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListTickets.Name = "ListTickets";
            this.ListTickets.Size = new System.Drawing.Size(256, 544);
            this.ListTickets.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список читательских билетов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата выдачи: *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Плановая дата возврата: *";
            // 
            // textBoxIssue
            // 
            this.textBoxIssue.Location = new System.Drawing.Point(457, 92);
            this.textBoxIssue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIssue.Name = "textBoxIssue";
            this.textBoxIssue.Size = new System.Drawing.Size(134, 21);
            this.textBoxIssue.TabIndex = 12;
            // 
            // textBoxReturn
            // 
            this.textBoxReturn.Location = new System.Drawing.Point(457, 119);
            this.textBoxReturn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxReturn.Name = "textBoxReturn";
            this.textBoxReturn.Size = new System.Drawing.Size(134, 21);
            this.textBoxReturn.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Книга:";
            // 
            // NameBook
            // 
            this.NameBook.AutoSize = true;
            this.NameBook.Location = new System.Drawing.Point(424, 60);
            this.NameBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameBook.Name = "NameBook";
            this.NameBook.Size = new System.Drawing.Size(99, 15);
            this.NameBook.TabIndex = 15;
            this.NameBook.Text = "Название книги";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(375, 162);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(119, 33);
            this.buttonConfirm.TabIndex = 16;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 21);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Id";
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 656);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.NameBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxReturn);
            this.Controls.Add(this.textBoxIssue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListTickets);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "IssueBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдача книги";
            this.Load += new System.EventHandler(this.IssueBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIssue;
        private System.Windows.Forms.TextBox textBoxReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NameBook;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}