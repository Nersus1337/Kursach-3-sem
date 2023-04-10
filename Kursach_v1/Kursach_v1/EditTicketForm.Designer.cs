namespace Kursach_v1
{
    partial class EditTicketForm
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
            this.EditTicket = new System.Windows.Forms.Button();
            this.EmailTicket = new System.Windows.Forms.TextBox();
            this.PhoneTicket = new System.Windows.Forms.TextBox();
            this.PassportTicket = new System.Windows.Forms.TextBox();
            this.AddressTicket = new System.Windows.Forms.TextBox();
            this.NameTicket = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditTicket
            // 
            this.EditTicket.Location = new System.Drawing.Point(74, 240);
            this.EditTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditTicket.Name = "EditTicket";
            this.EditTicket.Size = new System.Drawing.Size(200, 37);
            this.EditTicket.TabIndex = 53;
            this.EditTicket.Text = "Сохранить изменения";
            this.EditTicket.UseVisualStyleBackColor = true;
            this.EditTicket.Click += new System.EventHandler(this.EditTicket_Click);
            // 
            // EmailTicket
            // 
            this.EmailTicket.Location = new System.Drawing.Point(153, 126);
            this.EmailTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EmailTicket.Name = "EmailTicket";
            this.EmailTicket.Size = new System.Drawing.Size(172, 21);
            this.EmailTicket.TabIndex = 49;
            // 
            // PhoneTicket
            // 
            this.PhoneTicket.Location = new System.Drawing.Point(153, 90);
            this.PhoneTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PhoneTicket.Name = "PhoneTicket";
            this.PhoneTicket.Size = new System.Drawing.Size(172, 21);
            this.PhoneTicket.TabIndex = 48;
            // 
            // PassportTicket
            // 
            this.PassportTicket.Location = new System.Drawing.Point(153, 162);
            this.PassportTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PassportTicket.Name = "PassportTicket";
            this.PassportTicket.Size = new System.Drawing.Size(172, 21);
            this.PassportTicket.TabIndex = 47;
            // 
            // AddressTicket
            // 
            this.AddressTicket.Location = new System.Drawing.Point(153, 198);
            this.AddressTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddressTicket.Name = "AddressTicket";
            this.AddressTicket.Size = new System.Drawing.Size(172, 21);
            this.AddressTicket.TabIndex = 46;
            // 
            // NameTicket
            // 
            this.NameTicket.Location = new System.Drawing.Point(153, 54);
            this.NameTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NameTicket.Name = "NameTicket";
            this.NameTicket.Size = new System.Drawing.Size(172, 21);
            this.NameTicket.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "ФИО: *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Адрес:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Паспорт:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Номер телефона: *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Редактирование билета";
            // 
            // EditTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 298);
            this.Controls.Add(this.EditTicket);
            this.Controls.Add(this.EmailTicket);
            this.Controls.Add(this.PhoneTicket);
            this.Controls.Add(this.PassportTicket);
            this.Controls.Add(this.AddressTicket);
            this.Controls.Add(this.NameTicket);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EditTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование билета";
            this.Load += new System.EventHandler(this.EditTicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditTicket;
        public System.Windows.Forms.TextBox EmailTicket;
        public System.Windows.Forms.TextBox PhoneTicket;
        public System.Windows.Forms.TextBox PassportTicket;
        public System.Windows.Forms.TextBox AddressTicket;
        public System.Windows.Forms.TextBox NameTicket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}