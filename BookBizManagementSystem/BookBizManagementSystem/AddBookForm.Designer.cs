namespace BookBizManagementSystem
{
    partial class AddBookForm
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
            this.labelAddBook = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxISBN = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.buttonResetBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.labelFN = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddNewAuthor = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonResetAuthor = new System.Windows.Forms.Button();
            this.buttonAddAuthorExtra = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxListAuthors = new System.Windows.Forms.ComboBox();
            this.buttonAddAuthorBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxPublishedYear = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxFirstNameAuthor = new System.Windows.Forms.TextBox();
            this.textBoxLastNameAuthor = new System.Windows.Forms.TextBox();
            this.textBoxEmailAuthor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAddBook
            // 
            this.labelAddBook.AutoSize = true;
            this.labelAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAddBook.Location = new System.Drawing.Point(690, 41);
            this.labelAddBook.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddBook.Name = "labelAddBook";
            this.labelAddBook.Size = new System.Drawing.Size(241, 55);
            this.labelAddBook.TabIndex = 11;
            this.labelAddBook.Text = "Add Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "*ISBN eg 978-3-16-148410-0";
            // 
            // maskedTextBoxISBN
            // 
            this.maskedTextBoxISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxISBN.Location = new System.Drawing.Point(306, 169);
            this.maskedTextBoxISBN.Margin = new System.Windows.Forms.Padding(6);
            this.maskedTextBoxISBN.Mask = "000-0-00-000000-0";
            this.maskedTextBoxISBN.Name = "maskedTextBoxISBN";
            this.maskedTextBoxISBN.Size = new System.Drawing.Size(374, 32);
            this.maskedTextBoxISBN.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(843, 391);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 32);
            this.label8.TabIndex = 48;
            this.label8.Text = "Publisher Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(843, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 32);
            this.label7.TabIndex = 47;
            this.label7.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(843, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 32);
            this.label6.TabIndex = 46;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 32);
            this.label5.TabIndex = 45;
            this.label5.Text = "Year Published";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 32);
            this.label4.TabIndex = 44;
            this.label4.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 32);
            this.label3.TabIndex = 43;
            this.label3.Text = "Book Title";
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn.Location = new System.Drawing.Point(58, 169);
            this.isbn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(79, 32);
            this.isbn.TabIndex = 42;
            this.isbn.Text = "ISBN";
            // 
            // buttonResetBook
            // 
            this.buttonResetBook.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonResetBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonResetBook.Location = new System.Drawing.Point(1272, 501);
            this.buttonResetBook.Name = "buttonResetBook";
            this.buttonResetBook.Size = new System.Drawing.Size(200, 75);
            this.buttonResetBook.TabIndex = 60;
            this.buttonResetBook.Text = "RESET";
            this.buttonResetBook.UseVisualStyleBackColor = false;
            this.buttonResetBook.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddBook.Location = new System.Drawing.Point(988, 501);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(250, 75);
            this.buttonAddBook.TabIndex = 59;
            this.buttonAddBook.Text = "ADD BOOK";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(1326, 1084);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 60);
            this.buttonBack.TabIndex = 69;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(90, 1033);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(86, 32);
            this.labelEmail.TabIndex = 81;
            this.labelEmail.Text = "Email";
            this.labelEmail.Visible = false;
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLN.Location = new System.Drawing.Point(90, 974);
            this.labelLN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(150, 32);
            this.labelLN.TabIndex = 80;
            this.labelLN.Text = "Last Name";
            this.labelLN.Visible = false;
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFN.Location = new System.Drawing.Point(90, 915);
            this.labelFN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(151, 32);
            this.labelFN.TabIndex = 79;
            this.labelFN.Text = "First Name";
            this.labelFN.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 655);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 32);
            this.label9.TabIndex = 90;
            this.label9.Text = "Select the author";
            // 
            // buttonAddNewAuthor
            // 
            this.buttonAddNewAuthor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddNewAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewAuthor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddNewAuthor.Location = new System.Drawing.Point(700, 822);
            this.buttonAddNewAuthor.Name = "buttonAddNewAuthor";
            this.buttonAddNewAuthor.Size = new System.Drawing.Size(300, 60);
            this.buttonAddNewAuthor.TabIndex = 63;
            this.buttonAddNewAuthor.Text = "ADD NEW AUTHOR";
            this.buttonAddNewAuthor.UseVisualStyleBackColor = false;
            this.buttonAddNewAuthor.Click += new System.EventHandler(this.buttonAddNewAuthor_Click);
            // 
            // buttonResetAuthor
            // 
            this.buttonResetAuthor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonResetAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetAuthor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonResetAuthor.Location = new System.Drawing.Point(701, 932);
            this.buttonResetAuthor.Name = "buttonResetAuthor";
            this.buttonResetAuthor.Size = new System.Drawing.Size(230, 60);
            this.buttonResetAuthor.TabIndex = 68;
            this.buttonResetAuthor.Text = "RESET";
            this.buttonResetAuthor.UseVisualStyleBackColor = false;
            this.buttonResetAuthor.Click += new System.EventHandler(this.buttonResetAuthor_Click);
            // 
            // buttonAddAuthorExtra
            // 
            this.buttonAddAuthorExtra.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddAuthorExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAuthorExtra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddAuthorExtra.Location = new System.Drawing.Point(701, 1005);
            this.buttonAddAuthorExtra.Name = "buttonAddAuthorExtra";
            this.buttonAddAuthorExtra.Size = new System.Drawing.Size(230, 60);
            this.buttonAddAuthorExtra.TabIndex = 67;
            this.buttonAddAuthorExtra.Text = "ADD AUTHOR";
            this.buttonAddAuthorExtra.UseVisualStyleBackColor = false;
            this.buttonAddAuthorExtra.Click += new System.EventHandler(this.buttonAddAuthorExtra_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 836);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(609, 32);
            this.label10.TabIndex = 77;
            this.label10.Text = "**If not in the list, click here to add a new author";
            // 
            // comboBoxListAuthors
            // 
            this.comboBoxListAuthors.FormattingEnabled = true;
            this.comboBoxListAuthors.Location = new System.Drawing.Point(306, 655);
            this.comboBoxListAuthors.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxListAuthors.Name = "comboBoxListAuthors";
            this.comboBoxListAuthors.Size = new System.Drawing.Size(374, 32);
            this.comboBoxListAuthors.TabIndex = 61;
            this.comboBoxListAuthors.Visible = false;
            // 
            // buttonAddAuthorBook
            // 
            this.buttonAddAuthorBook.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddAuthorBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAuthorBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddAuthorBook.Location = new System.Drawing.Point(729, 621);
            this.buttonAddAuthorBook.Name = "buttonAddAuthorBook";
            this.buttonAddAuthorBook.Size = new System.Drawing.Size(330, 100);
            this.buttonAddAuthorBook.TabIndex = 62;
            this.buttonAddAuthorBook.Text = "ADD AUTHOR TO THE BOOK";
            this.buttonAddAuthorBook.UseVisualStyleBackColor = false;
            this.buttonAddAuthorBook.Click += new System.EventHandler(this.buttonAddAuthorBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 737);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1051, 32);
            this.label1.TabIndex = 96;
            this.label1.Text = "*Select from the list and click ADD AUTHOR again to add more authors to the book";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(306, 247);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(374, 29);
            this.textBoxTitle.TabIndex = 53;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(306, 321);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(374, 29);
            this.textBoxUnitPrice.TabIndex = 54;
            // 
            // textBoxPublishedYear
            // 
            this.textBoxPublishedYear.Location = new System.Drawing.Point(306, 394);
            this.textBoxPublishedYear.Name = "textBoxPublishedYear";
            this.textBoxPublishedYear.Size = new System.Drawing.Size(374, 29);
            this.textBoxPublishedYear.TabIndex = 55;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(1102, 247);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(374, 29);
            this.textBoxCategory.TabIndex = 56;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(1102, 395);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(370, 29);
            this.textBoxPublisher.TabIndex = 58;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(1102, 321);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(374, 29);
            this.textBoxQuantity.TabIndex = 57;
            // 
            // textBoxFirstNameAuthor
            // 
            this.textBoxFirstNameAuthor.Location = new System.Drawing.Point(290, 919);
            this.textBoxFirstNameAuthor.Name = "textBoxFirstNameAuthor";
            this.textBoxFirstNameAuthor.Size = new System.Drawing.Size(290, 29);
            this.textBoxFirstNameAuthor.TabIndex = 64;
            // 
            // textBoxLastNameAuthor
            // 
            this.textBoxLastNameAuthor.Location = new System.Drawing.Point(290, 978);
            this.textBoxLastNameAuthor.Name = "textBoxLastNameAuthor";
            this.textBoxLastNameAuthor.Size = new System.Drawing.Size(290, 29);
            this.textBoxLastNameAuthor.TabIndex = 65;
            // 
            // textBoxEmailAuthor
            // 
            this.textBoxEmailAuthor.Location = new System.Drawing.Point(290, 1037);
            this.textBoxEmailAuthor.Name = "textBoxEmailAuthor";
            this.textBoxEmailAuthor.Size = new System.Drawing.Size(290, 29);
            this.textBoxEmailAuthor.TabIndex = 66;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1184);
            this.Controls.Add(this.textBoxEmailAuthor);
            this.Controls.Add(this.textBoxLastNameAuthor);
            this.Controls.Add(this.textBoxFirstNameAuthor);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxPublishedYear);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddAuthorBook);
            this.Controls.Add(this.comboBoxListAuthors);
            this.Controls.Add(this.buttonAddAuthorExtra);
            this.Controls.Add(this.buttonResetAuthor);
            this.Controls.Add(this.buttonAddNewAuthor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonResetBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxISBN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.labelAddBook);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookForm";
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxISBN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.Button buttonResetBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddNewAuthor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonResetAuthor;
        private System.Windows.Forms.Button buttonAddAuthorExtra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxListAuthors;
        private System.Windows.Forms.Button buttonAddAuthorBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxPublishedYear;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxFirstNameAuthor;
        private System.Windows.Forms.TextBox textBoxLastNameAuthor;
        private System.Windows.Forms.TextBox textBoxEmailAuthor;
    }
}