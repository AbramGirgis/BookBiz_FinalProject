namespace BookBizManagementSystem
{
    partial class AddClientForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFaxNumber = new System.Windows.Forms.MaskedTextBox();
            this.CreditLimitLabel = new System.Windows.Forms.Label();
            this.labelFaxNumber = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StreetNameLabel = new System.Windows.Forms.Label();
            this.StreetNumberlabel = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelAddBook = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreetName = new System.Windows.Forms.TextBox();
            this.textBoxStreetNumber = new System.Windows.Forms.TextBox();
            this.textBoxCreditLimit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(615, 656);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "*eg H4L 3X9";
            // 
            // maskedTextBoxPostalCode
            // 
            this.maskedTextBoxPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxPostalCode.Location = new System.Drawing.Point(348, 659);
            this.maskedTextBoxPostalCode.Margin = new System.Windows.Forms.Padding(6);
            this.maskedTextBoxPostalCode.Mask = "L>0L> 0L>0";
            this.maskedTextBoxPostalCode.Name = "maskedTextBoxPostalCode";
            this.maskedTextBoxPostalCode.Size = new System.Drawing.Size(238, 22);
            this.maskedTextBoxPostalCode.TabIndex = 55;
            this.maskedTextBoxPostalCode.ValidatingType = typeof(int);
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(348, 245);
            this.maskedTextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(6);
            this.maskedTextBoxPhoneNumber.Mask = "(000) 000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(238, 22);
            this.maskedTextBoxPhoneNumber.TabIndex = 49;
            // 
            // maskedTextBoxFaxNumber
            // 
            this.maskedTextBoxFaxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxFaxNumber.Location = new System.Drawing.Point(348, 314);
            this.maskedTextBoxFaxNumber.Margin = new System.Windows.Forms.Padding(6);
            this.maskedTextBoxFaxNumber.Mask = "(000) 000-0000";
            this.maskedTextBoxFaxNumber.Name = "maskedTextBoxFaxNumber";
            this.maskedTextBoxFaxNumber.Size = new System.Drawing.Size(238, 22);
            this.maskedTextBoxFaxNumber.TabIndex = 50;
            // 
            // CreditLimitLabel
            // 
            this.CreditLimitLabel.AutoSize = true;
            this.CreditLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditLimitLabel.Location = new System.Drawing.Point(81, 383);
            this.CreditLimitLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CreditLimitLabel.Name = "CreditLimitLabel";
            this.CreditLimitLabel.Size = new System.Drawing.Size(161, 32);
            this.CreditLimitLabel.TabIndex = 47;
            this.CreditLimitLabel.Text = "Credit limit";
            // 
            // labelFaxNumber
            // 
            this.labelFaxNumber.AutoSize = true;
            this.labelFaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFaxNumber.Location = new System.Drawing.Point(81, 314);
            this.labelFaxNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFaxNumber.Name = "labelFaxNumber";
            this.labelFaxNumber.Size = new System.Drawing.Size(174, 32);
            this.labelFaxNumber.TabIndex = 46;
            this.labelFaxNumber.Text = "Fax number";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(82, 245);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(212, 32);
            this.PhoneNumberLabel.TabIndex = 45;
            this.PhoneNumberLabel.Text = "Phone number";
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCodeLabel.Location = new System.Drawing.Point(81, 659);
            this.PostalCodeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(174, 32);
            this.PostalCodeLabel.TabIndex = 44;
            this.PostalCodeLabel.Text = "Postal code";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(82, 590);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(67, 32);
            this.CityLabel.TabIndex = 43;
            this.CityLabel.Text = "City";
            // 
            // StreetNameLabel
            // 
            this.StreetNameLabel.AutoSize = true;
            this.StreetNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetNameLabel.Location = new System.Drawing.Point(82, 521);
            this.StreetNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StreetNameLabel.Name = "StreetNameLabel";
            this.StreetNameLabel.Size = new System.Drawing.Size(179, 32);
            this.StreetNameLabel.TabIndex = 42;
            this.StreetNameLabel.Text = "Street name";
            // 
            // StreetNumberlabel
            // 
            this.StreetNumberlabel.AutoSize = true;
            this.StreetNumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetNumberlabel.Location = new System.Drawing.Point(81, 452);
            this.StreetNumberlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StreetNumberlabel.Name = "StreetNumberlabel";
            this.StreetNumberlabel.Size = new System.Drawing.Size(210, 32);
            this.StreetNumberlabel.TabIndex = 41;
            this.StreetNumberlabel.Text = "Street Number";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(81, 176);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(177, 32);
            this.labelCustomerName.TabIndex = 40;
            this.labelCustomerName.Text = "Client name";
            // 
            // labelAddBook
            // 
            this.labelAddBook.AutoSize = true;
            this.labelAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAddBook.Location = new System.Drawing.Point(429, 51);
            this.labelAddBook.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddBook.Name = "labelAddBook";
            this.labelAddBook.Size = new System.Drawing.Size(255, 55);
            this.labelAddBook.TabIndex = 63;
            this.labelAddBook.Text = "Add Client";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(879, 781);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 60);
            this.buttonBack.TabIndex = 79;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonReset.Location = new System.Drawing.Point(578, 781);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(200, 60);
            this.buttonReset.TabIndex = 78;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClient.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddClient.Location = new System.Drawing.Point(288, 781);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(244, 60);
            this.buttonAddClient.TabIndex = 77;
            this.buttonAddClient.Text = "ADD CLIENT";
            this.buttonAddClient.UseVisualStyleBackColor = false;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(348, 179);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(238, 29);
            this.textBoxClientName.TabIndex = 48;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(348, 593);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(238, 29);
            this.textBoxCity.TabIndex = 54;
            // 
            // textBoxStreetName
            // 
            this.textBoxStreetName.Location = new System.Drawing.Point(348, 524);
            this.textBoxStreetName.Name = "textBoxStreetName";
            this.textBoxStreetName.Size = new System.Drawing.Size(238, 29);
            this.textBoxStreetName.TabIndex = 53;
            // 
            // textBoxStreetNumber
            // 
            this.textBoxStreetNumber.Location = new System.Drawing.Point(348, 455);
            this.textBoxStreetNumber.Name = "textBoxStreetNumber";
            this.textBoxStreetNumber.Size = new System.Drawing.Size(238, 29);
            this.textBoxStreetNumber.TabIndex = 52;
            // 
            // textBoxCreditLimit
            // 
            this.textBoxCreditLimit.Location = new System.Drawing.Point(348, 387);
            this.textBoxCreditLimit.Name = "textBoxCreditLimit";
            this.textBoxCreditLimit.Size = new System.Drawing.Size(238, 29);
            this.textBoxCreditLimit.TabIndex = 51;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 906);
            this.Controls.Add(this.textBoxCreditLimit);
            this.Controls.Add(this.textBoxStreetNumber);
            this.Controls.Add(this.textBoxStreetName);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.labelAddBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxPostalCode);
            this.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.Controls.Add(this.maskedTextBoxFaxNumber);
            this.Controls.Add(this.CreditLimitLabel);
            this.Controls.Add(this.labelFaxNumber);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.StreetNameLabel);
            this.Controls.Add(this.StreetNumberlabel);
            this.Controls.Add(this.labelCustomerName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClientForm";
            this.Text = "Add Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPostalCode;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFaxNumber;
        private System.Windows.Forms.Label CreditLimitLabel;
        private System.Windows.Forms.Label labelFaxNumber;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label StreetNameLabel;
        private System.Windows.Forms.Label StreetNumberlabel;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelAddBook;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreetName;
        private System.Windows.Forms.TextBox textBoxStreetNumber;
        private System.Windows.Forms.TextBox textBoxCreditLimit;
    }
}