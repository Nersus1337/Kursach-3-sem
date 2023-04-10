namespace Kursach_v1
{
    partial class AddTicketForm
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
            this.AddTicket = new System.Windows.Forms.Button();
            this.PhoneTicket = new System.Windows.Forms.TextBox();
            this.EmailTicket = new System.Windows.Forms.TextBox();
            this.AddressTicket = new System.Windows.Forms.TextBox();
            this.PassportTicket = new System.Windows.Forms.TextBox();
            this.NameTicket = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddTicket
            // 
            this.AddTicket.Location = new System.Drawing.Point(90, 238);
            this.AddTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddTicket.Name = "AddTicket";
            this.AddTicket.Size = new System.Drawing.Size(200, 37);
            this.AddTicket.TabIndex = 35;
            this.AddTicket.Text = "Добавить билет";
            this.AddTicket.UseVisualStyleBackColor = true;
            this.AddTicket.Click += new System.EventHandler(this.AddTicket_Click);
            // 
            // PhoneTicket
            // 
            this.PhoneTicket.Location = new System.Drawing.Point(187, 202);
            this.PhoneTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PhoneTicket.Name = "PhoneTicket";
            this.PhoneTicket.Size = new System.Drawing.Size(172, 21);
            this.PhoneTicket.TabIndex = 31;
            // 
            // EmailTicket
            // 
            this.EmailTicket.Location = new System.Drawing.Point(187, 164);
            this.EmailTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EmailTicket.Name = "EmailTicket";
            this.EmailTicket.Size = new System.Drawing.Size(172, 21);
            this.EmailTicket.TabIndex = 30;
            // 
            // AddressTicket
            // 
            this.AddressTicket.Location = new System.Drawing.Point(187, 126);
            this.AddressTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddressTicket.Name = "AddressTicket";
            this.AddressTicket.Size = new System.Drawing.Size(172, 21);
            this.AddressTicket.TabIndex = 29;
            // 
            // PassportTicket
            // 
            this.PassportTicket.Location = new System.Drawing.Point(187, 88);
            this.PassportTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PassportTicket.Name = "PassportTicket";
            this.PassportTicket.Size = new System.Drawing.Size(172, 21);
            this.PassportTicket.TabIndex = 28;
            // 
            // NameTicket
            // 
            this.NameTicket.Location = new System.Drawing.Point(187, 50);
            this.NameTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NameTicket.Name = "NameTicket";
            this.NameTicket.Size = new System.Drawing.Size(172, 21);
            this.NameTicket.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "ФИО: *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Данные паспорта:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Адрес проживания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Номер телефона: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Добавление нового билета";
            // 
            // AddTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 305);
            this.Controls.Add(this.AddTicket);
            this.Controls.Add(this.PhoneTicket);
            this.Controls.Add(this.EmailTicket);
            this.Controls.Add(this.AddressTicket);
            this.Controls.Add(this.PassportTicket);
            this.Controls.Add(this.NameTicket);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление билета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTicket;
        private System.Windows.Forms.TextBox PhoneTicket;
        private System.Windows.Forms.TextBox EmailTicket;
        private System.Windows.Forms.TextBox AddressTicket;
        private System.Windows.Forms.TextBox PassportTicket;
        private System.Windows.Forms.TextBox NameTicket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}