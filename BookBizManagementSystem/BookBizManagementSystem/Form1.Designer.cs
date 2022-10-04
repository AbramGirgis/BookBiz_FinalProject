namespace BookBizManagementSystem
{
    partial class Form1
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.groupBoxSignin = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelUserRole = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSignin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelProjectTitle = new System.Windows.Forms.Label();
            this.labelCopyRight = new System.Windows.Forms.Label();
            this.groupBoxSignin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(64, 223);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(158, 36);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // groupBoxSignin
            // 
            this.groupBoxSignin.Controls.Add(this.buttonExit);
            this.groupBoxSignin.Controls.Add(this.labelUserRole);
            this.groupBoxSignin.Controls.Add(this.comboBoxRole);
            this.groupBoxSignin.Controls.Add(this.buttonCancel);
            this.groupBoxSignin.Controls.Add(this.buttonSignin);
            this.groupBoxSignin.Controls.Add(this.textBoxPassword);
            this.groupBoxSignin.Controls.Add(this.textBoxUsername);
            this.groupBoxSignin.Controls.Add(this.labelPassword);
            this.groupBoxSignin.Controls.Add(this.labelUsername);
            this.groupBoxSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSignin.Location = new System.Drawing.Point(197, 160);
            this.groupBoxSignin.Name = "groupBoxSignin";
            this.groupBoxSignin.Size = new System.Drawing.Size(778, 668);
            this.groupBoxSignin.TabIndex = 2;
            this.groupBoxSignin.TabStop = false;
            this.groupBoxSignin.Text = "Sign in";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonExit.Location = new System.Drawing.Point(559, 574);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(175, 70);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelUserRole
            // 
            this.labelUserRole.AutoSize = true;
            this.labelUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserRole.Location = new System.Drawing.Point(64, 117);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(157, 36);
            this.labelUserRole.TabIndex = 17;
            this.labelUserRole.Text = "User Role";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "MIS Manager",
            "Sales Manager",
            "Inventory Controller",
            "Order Clerk"});
            this.comboBoxRole.Location = new System.Drawing.Point(276, 108);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(446, 50);
            this.comboBoxRole.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCancel.Location = new System.Drawing.Point(513, 420);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(209, 60);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSignin
            // 
            this.buttonSignin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSignin.Location = new System.Drawing.Point(276, 420);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Size = new System.Drawing.Size(209, 60);
            this.buttonSignin.TabIndex = 5;
            this.buttonSignin.Text = "SIGN IN";
            this.buttonSignin.UseVisualStyleBackColor = false;
            this.buttonSignin.Click += new System.EventHandler(this.buttonSignin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(276, 314);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(446, 49);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(276, 214);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(446, 49);
            this.textBoxUsername.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(64, 323);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(155, 36);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelProjectTitle
            // 
            this.labelProjectTitle.AutoSize = true;
            this.labelProjectTitle.BackColor = System.Drawing.Color.RosyBrown;
            this.labelProjectTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelProjectTitle.Location = new System.Drawing.Point(280, 59);
            this.labelProjectTitle.Name = "labelProjectTitle";
            this.labelProjectTitle.Size = new System.Drawing.Size(613, 55);
            this.labelProjectTitle.TabIndex = 3;
            this.labelProjectTitle.Text = "BookBiz Management System";
            // 
            // labelCopyRight
            // 
            this.labelCopyRight.AutoSize = true;
            this.labelCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyRight.Location = new System.Drawing.Point(412, 898);
            this.labelCopyRight.Name = "labelCopyRight";
            this.labelCopyRight.Size = new System.Drawing.Size(368, 25);
            this.labelCopyRight.TabIndex = 4;
            this.labelCopyRight.Text = "BookBiz Management System© 2022";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 952);
            this.Controls.Add(this.labelCopyRight);
            this.Controls.Add(this.labelProjectTitle);
            this.Controls.Add(this.groupBoxSignin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Authentication Page";
            this.groupBoxSignin.ResumeLayout(false);
            this.groupBoxSignin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.GroupBox groupBoxSignin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserRole;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSignin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelProjectTitle;
        private System.Windows.Forms.Label labelCopyRight;
        private System.Windows.Forms.Button buttonExit;
    }
}

